using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Givernu
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			string fileName = @"R:\.git\logs\refs\heads\master";

			string tagsFileName = @"R:\.git\info\refs";

			GitEntry.LoadTagsDictionary(tagsFileName);
			var z = GitEntry.Load(fileName);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
