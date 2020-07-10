using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Givernu
{
	public partial class GivernuForm : Form
	{
		private GivernuManager _givernuManager	= new GivernuManager();

		public GivernuForm()
		{
			InitializeComponent();
			this._givernuManager.GitEntriesViewer	= this._lvGivernu;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			string folder		= Directory.GetCurrentDirectory();
			this._lblInfo.Text	= folder;
			
			this._givernuManager.HandleDirectory(folder);
		}

		private void OnFileQuit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnFileExportSelectedToXml(object sender, EventArgs e)
		{
			XElement x	= this._givernuManager.ToXElement(true);

			SaveFileDialog sfd	= new SaveFileDialog();
			sfd.Filter			= "XML files (*.xml)|*.xml";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				x.Save(sfd.FileName);
			}
		}

		private void OnFileExportSelectedToCsv(object sender, EventArgs e)
		{
			string csv	= this._givernuManager.ToCsv(true);

			SaveFileDialog sfd	= new SaveFileDialog();
			sfd.Filter			= "CSV files (*.csv)|*.csv";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(sfd.FileName))
				{
					writer.Write(csv);
				}
			}
		}

		private void OnFileExportSelectedToText(object sender, EventArgs e)
		{
			string text	= this._givernuManager.ToText(true);

			SaveFileDialog sfd	= new SaveFileDialog();
			sfd.Filter			= "Text files (*.txt)|*.txt";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(sfd.FileName))
				{
					writer.Write(text);
				}
			}
		}

		private void OnFileExportAllToXml(object sender, EventArgs e)
		{
			XElement x	= this._givernuManager.ToXElement(false);

			SaveFileDialog sfd	= new SaveFileDialog();
			sfd.Filter			= "XML files (*.xml)|*.xml";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				x.Save(sfd.FileName);
			}
		}

		private void OnFileExportAllToCsv(object sender, EventArgs e)
		{
			string csv	= this._givernuManager.ToCsv(false);

			SaveFileDialog sfd	= new SaveFileDialog();
			sfd.Filter			= "CSV files (*.csv)|*.csv";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(sfd.FileName))
				{
					writer.Write(csv);
				}
			}
		}

		private void OnFileExportAllToText(object sender, EventArgs e)
		{
			string text	= this._givernuManager.ToText(false);

			SaveFileDialog sfd	= new SaveFileDialog();
			sfd.Filter			= "Text files (*.txt)|*.txt";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(sfd.FileName))
				{
					writer.Write(text);
				}
			}
		}

		private void OnCopyRevisionHackToClipboard(object sender, EventArgs e)
		{
			if (this._givernuManager.GitEntriesViewer.SelectedItems.Count == 1)
			{
				GitEntry gitEntry	= this._givernuManager.GitEntriesViewer.SelectedItems[0].Tag as GitEntry;

				Clipboard.SetText(gitEntry.ID);
			}
		}

		private void OnCopySelectedRevisionToClipboard(object sender, EventArgs e)
		{
			if (this._givernuManager.GitEntriesViewer.SelectedItems.Count == 1)
			{
				GitEntry gitEntry	= this._givernuManager.GitEntriesViewer.SelectedItems[0].Tag as GitEntry;

				Clipboard.SetText(gitEntry.ToText());
			}
		}
	}
}
