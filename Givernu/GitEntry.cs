using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Givernu
{
	public class GitEntry
	{
		#region Properties
		public	int				Number			{get;set;}
		public	string			ID				{get;set;}
		public	string			Branch			{get;set;}
		public	string			Description		{get;set;}
		public	string			Author			{get;set;}
		public	DateTime		DateTime		{get;set;}
		public	List<string>	Tags			{get;set;}	= new List<string>();
		#endregion

		public static Dictionary<string, List<string>> TagsDictionary = new Dictionary<string, List<string>>();

		public static void LoadTagsDictionary(string fileName)
		{
			// 31f906f5393540717d815667fce4568c027ba268	refs/tags/Tag_001^{}
			using (StreamReader reader = new StreamReader(fileName))
			{
				string[] lines	= reader.ReadToEnd().Split(new string[]{"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);

				foreach (string line in lines)
				{
					if (line.Contains("refs/tags/") && line.EndsWith("{}"))
					{
						string[] cells			= line.Split(new string[]{"\t"}, StringSplitOptions.RemoveEmptyEntries);

						string key				= cells[0].Trim();
						string value			= cells[1].TrimEnd('{', '}', '^').Replace("refs/tags/", "");

						if (!TagsDictionary.ContainsKey(key))
						{
							TagsDictionary.Add(key, new List<string>());
						}

						TagsDictionary[key].Add(value);
					}
				}
			}
		}

		public static List<GitEntry>	Load(string fileName)
		{
			List<GitEntry> entries	= new List<GitEntry>();

			// c0bdf9e19ff3fb3887d6214a0f67a0f5e1156b96 3f9497d9c59bc9651449f241ade44d28fb0e1899 AlexKonnen <alex@pikkatech.eu> 1590132666 +0200	commit: Transferred Onomastics and tools
			using (StreamReader reader = new StreamReader(fileName))
			{
				string[] lines				= reader.ReadToEnd().Split(new string[]{"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);

				int counter					= 1;
				foreach (string line in lines)
				{
					string[] lineParts		= line.Split(new string[]{"\t"}, StringSplitOptions.RemoveEmptyEntries);
					string data				= lineParts[0];
					string description		= lineParts[1].Replace("commit:", "").Trim();

					string[] cells			= data.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);

					GitEntry gitEntry		= new GitEntry();
					gitEntry.Number			= counter++;
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

					entries.Add(gitEntry);
				}
			}

			return entries;
		}
	}
}
