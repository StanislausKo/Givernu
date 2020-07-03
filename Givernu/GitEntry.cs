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
	}
}
