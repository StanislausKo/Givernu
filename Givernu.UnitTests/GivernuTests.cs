using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Givernu.UnitTests
{
	[TestFixture]
	public class GivernuTests
	{
		[Test]
		public void SearchingWorkingDirectory_InitialContainsGit_Succeeds()
		{
			string folder = "..\\..\\";
			GivernuManager gm	= new GivernuManager();
			gm.FindGitDirectory(folder);

			Assert.That(gm.CurrentDirectory != null);
		}

		[Test]
		public void SearchingWorkingDirectory_InitialsParentContainsGit_Succeeds()
		{
			string folder = Directory.GetCurrentDirectory();
			GivernuManager gm	= new GivernuManager();
			gm.FindGitDirectory(folder);

			Assert.That(gm.CurrentDirectory != null);
		}

		[Test]
		public void SearchingWorkingDirectory_NoInitialsParentContainsGit_ResultsInNullCurrentDirectory()
		{
			string folder = "c:\\Temp";
			GivernuManager gm	= new GivernuManager();
			gm.FindGitDirectory(folder);

			Assert.That(gm.CurrentDirectory == null);
		}
	}
}
