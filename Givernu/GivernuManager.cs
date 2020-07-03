using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Givernu
{
	public class GivernuManager : IGivernuManager
	{
		#region Private Data
		private static readonly string _gitFolder = ".git";
		#endregion

		#region Properties
		public string CurrentDirectory							{get;set;}

		public Dictionary<string, List<string>> TagsDictionary	{get;set;}	= new Dictionary<string, List<string>>();

		public List<GitEntry> GitEntries						{get;set;}	= new List<GitEntry>();
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
			throw new NotImplementedException();
		}

		public void CreateGitEntries()
		{
			throw new NotImplementedException();
		}
	}
}
