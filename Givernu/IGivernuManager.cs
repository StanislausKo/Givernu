using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Givernu
{
	public interface IGivernuManager
	{
		#region Properties
		/// <summary>
		/// The directory containing a ".git" subdirectory that is the current one.
		/// Null if there is none.
		/// </summary>
		string CurrentDirectory							{get;set;}

		/// <summary>
		/// Dictionary containing Git IDs as the keys and lists of tags that are made on them.
		/// </summary>
		Dictionary<string, List<string>> TagsDictionary {get;set;}

		/// <summary>
		/// List of git entries for Current Directory.
		/// </summary>
		List<GitEntry> GitEntries						{get;set;}
		#endregion

		/// <summary>
		/// Looks for a Git directory in the initial folder or its direct parents.
		/// </summary>
		/// <param name="initialFolder">The folder to start serrch.</param>
		void FindGitDirectory(string initialFolder);

		/// <summary>
		/// Creates the tag dictionary by parsing the "info\refs" subfolder of the ".git" folder of CurrentDirectory.
		/// </summary>
		void CreateTagDictionary();

		/// <summary>
		/// Creates the list of git entries in CurrentDirectory.
		/// </summary>
		void CreateGitEntries();

		/// <summary>
		/// Sorts Git entries by DateTime and assigns indices.
		/// </summary>
		void SortGitEntries();
	}
}
