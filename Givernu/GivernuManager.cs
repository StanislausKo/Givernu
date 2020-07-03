﻿using System;
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
		private static readonly string _gitFolder		= ".git";
		private static readonly string _refsTagsFolder	= "refs\\tags";
		private static readonly string _refsTags		= "refs/tags/";
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

			//using (StreamReader reader = new StreamReader(tagsFolderName))
			//{
			//	//string[] lines	= reader.ReadToEnd().Split(new string[]{"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);

			//	//foreach (string line in lines)
			//	//{
			//	//	if (line.Contains(_refsTags) && line.EndsWith("{}"))
			//	//	{
			//	//		string[] cells			= line.Split(new string[]{"\t"}, StringSplitOptions.RemoveEmptyEntries);

			//	//		string key				= cells[0].Trim();
			//	//		string value			= cells[1].TrimEnd('{', '}', '^').Replace(_refsTags, "");

			//	//		if (!TagsDictionary.ContainsKey(key))
			//	//		{
			//	//			TagsDictionary.Add(key, new List<string>());
			//	//		}

			//	//		TagsDictionary[key].Add(value);
			//	//	}
			//	//}
			//}
		}

		public void CreateGitEntries()
		{
			throw new NotImplementedException();
		}
	}
}
