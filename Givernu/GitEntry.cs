/***********************************************************************************
* File:         GitEntry.cs                                                        *
* Contents:     Class GitEntry                                                     *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2020-07-10 14:17                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Xml.Linq;

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

		#region XML
		public XElement ToXElement()
		{
			XElement x	= new XElement("GitEntry");

			x.Add(new XAttribute("Number", this.Number));
			x.Add(new XAttribute("ID", this.ID));
			x.Add(new XAttribute("Branch", this.Branch));
			x.Add(new XAttribute("Author", this.Author));
			x.Add(new XAttribute("DateTime", this.DateTime.ToString("yyyy-MM-dd HH:mm")));

			x.Add(new XElement("Description", this.Description));
			XElement xTags	= new XElement("Tags");
			x.Add(xTags);

			foreach (string tag in this.Tags)
			{
				xTags.Add(new XElement("Tag", tag));
			}

			return x;
		}
		#endregion

		#region CSV
		public string ToCsv(string separator)
		{
			string	csv	= String.Join
										(
											separator, 
											new string[]
														{
															this.Number.ToString(), 
															this.ID, 
															this.Branch, 
															this.Description, 
															this.Author, 
															this.DateTime.ToString("yyyy-MM-dd HH:mm"), 
															String.Join(",", this.Tags.ToArray())
														}
										);

			return csv;
		}
		#endregion

		#region Text
		public string	ToText()
		{
			return ToCsv("\t");
		}
		#endregion
	}
}
