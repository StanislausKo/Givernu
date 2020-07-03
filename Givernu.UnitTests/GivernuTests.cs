using System;
using System.Collections.Generic;
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
			//string
		}

		[Test]
		public void SearchingWorkingDirectory_InitialsParentContainsGit_Succeeds()
		{

		}

		[Test]
		public void SearchingWorkingDirectory_NoInitialsParentContainsGit_ResultsInNullCurrentDirectory()
		{

		}
	}
}
