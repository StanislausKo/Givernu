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
	}
}
