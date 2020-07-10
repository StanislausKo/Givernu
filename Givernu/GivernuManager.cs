using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Givernu
{
	public class GivernuManager : IGivernuManager
	{
		#region Private Data
		private static readonly string _gitFolder		= ".git";
		private static readonly string _refsTagsFolder	= "refs\\tags";
		private static readonly string _logsRefsHeads	= "logs\\refs\\heads";
		#endregion

		#region Properties
		public string							CurrentDirectory	{get;set;}

		public Dictionary<string, List<string>> TagsDictionary		{get;set;}	= new Dictionary<string, List<string>>();

		public List<GitEntry>					GitEntries			{get;set;}	= new List<GitEntry>();
				
		/// <summary>
		/// ListView to display entries
		/// </summary>
		public ListView							GitEntriesViewer	{get;set;}	= null;
		#endregion

		public void FindGitDirectory(string initialFolder)
		{
			if (Directory.Exists(Path.Combine(initialFolder, _gitFolder)))
			{
				this.CurrentDirectory = initialFolder;
			}
			else
			{
				DirectoryInfo diParent	= Directory.GetParent(initialFolder);

				if (diParent  != null)
				{
					this.FindGitDirectory(diParent.FullName);
				}
				else
				{
					return;
				}
			}
		}

		public void CreateTagDictionary()
		{
			if (String.IsNullOrEmpty(this.CurrentDirectory))
			{
				return;
			}

			string tagsFolderName	= Path.Combine(this.CurrentDirectory, _gitFolder, _refsTagsFolder);

			string[] fileNames			= Directory.GetFiles(tagsFolderName);

			foreach (string fileName in fileNames)
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					string gitID	= reader.ReadLine();

					if (!TagsDictionary.ContainsKey(gitID))
					{
						TagsDictionary.Add(gitID, new List<string>());
					}

					TagsDictionary[gitID].Add(new FileInfo(fileName).Name);
				}
			}
		}

		public void CreateGitEntries()
		{
			if (String.IsNullOrEmpty(this.CurrentDirectory))
			{
				return;
			}
			
			string logRefsFolderName	= Path.Combine(this.CurrentDirectory, _gitFolder, _logsRefsHeads);

			string[] fileNames			= Directory.GetFiles(logRefsFolderName);

			foreach (string fileName in fileNames)
			{
				this.ProceedLogFile(fileName);
			}
		}

		/// <summary>
		/// Sorts Git entries by DateTime and assigns indices.
		/// </summary>
		public void SortGitEntries()
		{
			if (String.IsNullOrEmpty(this.CurrentDirectory))
			{
				return;
			}

			this.GitEntries.Sort(delegate(GitEntry x, GitEntry y)
			{
				if (x.DateTime < y.DateTime)
				{
					return -1;
				}
				else if (x.DateTime > y.DateTime)
				{
					return 1;
				}
				else
				{
					return 0;
				}
			});

			for (int i = 0; i < this.GitEntries.Count; i++)
			{
				this.GitEntries[i].Number	= i + 1;
			}
		}

		/// <summary>
		/// Displays the entries in the attached ListView
		/// </summary>
		public void DisplayGitEntries()
		{
			if (this.GitEntriesViewer == null)
			{
				return;
			}

			this.GitEntriesViewer.Items.Clear();

			foreach (GitEntry gitEntry in this.GitEntries)
			{
				string tags			= String.Join(",", gitEntry.Tags);
				ListViewItem lvi	= new ListViewItem
														(
															new string[]
																		{
																			gitEntry.Number.ToString(), 
																			gitEntry.ID, 
																			gitEntry.DateTime.ToString("yyyy-MM-dd@HH:mm"), 
																			gitEntry.Branch, 
																			gitEntry.Description, 
																			gitEntry.Author, 
																			tags
																		}
														);

				lvi.Tag				= gitEntry;

				this.GitEntriesViewer.Items.Add(lvi);
			}

			this.GitEntriesViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this.GitEntriesViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		public void HandleDirectory(string folderName)
		{
			this.FindGitDirectory(folderName);
			this.CreateTagDictionary();
			this.CreateGitEntries();
			this.SortGitEntries();
			this.DisplayGitEntries();
		}

		private void ProceedLogFile(string fileName)
		{
			using (StreamReader reader = new StreamReader(fileName))
			{
				string[] lines				= reader.ReadToEnd().Split(new string[]{"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);

				foreach (string line in lines)
				{
					GitEntry gitEntry		= new GitEntry();

					string[] lineParts		= line.Split(new string[]{"\t"}, StringSplitOptions.RemoveEmptyEntries);
					string data				= lineParts[0];
					string description		= lineParts[1].Replace("commit:", "").Trim();

					string[] cells			= data.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);

					gitEntry.Number			= 0;
					gitEntry.ID				= cells[1];
					gitEntry.Author			= cells[2];
					gitEntry.Description	= description;
					gitEntry.Branch			= new FileInfo(fileName).Name;

					long unixSeconds		= Int64.Parse(cells[4]);
					float hourOffset		= Single.Parse(cells[5].Substring(0, 3));
					float minuteOffset		= Single.Parse(cells[5].Substring(3, 2));

					DateTimeOffset dto		= DateTimeOffset.FromUnixTimeSeconds(unixSeconds);

					gitEntry.DateTime		= dto.DateTime.AddHours(hourOffset).AddMinutes(minuteOffset);

					gitEntry.Tags			= TagsDictionary.ContainsKey(gitEntry.ID)? TagsDictionary[gitEntry.ID] : new List<string>();

					this.GitEntries.Add(gitEntry);
				}
			}
		}

		public XElement ToXElement(bool selected = false)
		{
			GitEntry[] entries	= null;
			
			if (selected)
			{
				entries			= this.GitEntriesViewer.SelectedItems.OfType<ListViewItem>().Select(lvi => lvi.Tag as GitEntry).ToArray();
			}
			else
			{
				entries			= this.GitEntriesViewer.Items.OfType<ListViewItem>().Select(lvi => lvi.Tag as GitEntry).ToArray();
			}

			return this.EntriesToXElement(entries);
		}

		public string	ToCsv(bool selected = false, string separator = ";")
		{
			GitEntry[] entries	= null;
			
			if (selected)
			{
				entries			= this.GitEntriesViewer.SelectedItems.OfType<ListViewItem>().Select(lvi => lvi.Tag as GitEntry).ToArray();
			}
			else
			{
				entries			= this.GitEntriesViewer.Items.OfType<ListViewItem>().Select(lvi => lvi.Tag as GitEntry).ToArray();
			}

			return this.EntriesToCsv(entries, separator);
		}

		public string	ToText(bool selected = false)
		{
			return ToCsv(selected, "\t");
		}

		private XElement EntriesToXElement(GitEntry[] entries)
		{
			XElement x	= new XElement("GitEntries");

			foreach (GitEntry entry in entries)
			{
				x.Add(entry.ToXElement());
			}

			return x;
		}

		private string EntriesToCsv(GitEntry[] entries, string separator)
		{
			string result	= "";

			foreach (GitEntry entry in entries)
			{
				result	+= $"{entry.ToCsv(separator)}\r\n";
			}

			return result;
		}
	}
}
