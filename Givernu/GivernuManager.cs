using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Givernu
{
	public class GivernuManager : IGivernuManager
	{
		#region Properties
		public string CurrentDirectory							{get;set;}

		public Dictionary<string, List<string>> TagsDictionary	{get;set;}	= new Dictionary<string, List<string>>();

		public List<GitEntry> GitEntries						{get;set;}	= new List<GitEntry>();
		#endregion

		public void FindGitDirectory(string initialFolder)
		{
			throw new NotImplementedException();
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
