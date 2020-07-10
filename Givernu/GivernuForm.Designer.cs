namespace Givernu
{
	partial class GivernuForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GivernuForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this._lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this._lvGivernu = new System.Windows.Forms.ListView();
			this.RevisionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GitID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Branch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this._cmsGivernu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.revisionHackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this._cmsGivernu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Consolas", 10F);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(933, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(933, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblInfo});
			this.statusStrip1.Location = new System.Drawing.Point(0, 497);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(933, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// _lblInfo
			// 
			this._lblInfo.Font = new System.Drawing.Font("Consolas", 10F);
			this._lblInfo.Name = "_lblInfo";
			this._lblInfo.Size = new System.Drawing.Size(32, 17);
			this._lblInfo.Text = "***";
			// 
			// _lvGivernu
			// 
			this._lvGivernu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RevisionNumber,
            this.GitID,
            this.DateTime,
            this.Branch,
            this.Description,
            this.Author,
            this.Tags});
			this._lvGivernu.ContextMenuStrip = this._cmsGivernu;
			this._lvGivernu.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lvGivernu.FullRowSelect = true;
			this._lvGivernu.HideSelection = false;
			this._lvGivernu.Location = new System.Drawing.Point(0, 50);
			this._lvGivernu.Margin = new System.Windows.Forms.Padding(0);
			this._lvGivernu.Name = "_lvGivernu";
			this._lvGivernu.Size = new System.Drawing.Size(933, 447);
			this._lvGivernu.TabIndex = 3;
			this._lvGivernu.UseCompatibleStateImageBehavior = false;
			this._lvGivernu.View = System.Windows.Forms.View.Details;
			// 
			// RevisionNumber
			// 
			this.RevisionNumber.Text = "Rev";
			// 
			// GitID
			// 
			this.GitID.Text = "Git Id";
			this.GitID.Width = 91;
			// 
			// DateTime
			// 
			this.DateTime.Text = "Date/Time";
			this.DateTime.Width = 85;
			// 
			// Branch
			// 
			this.Branch.DisplayIndex = 4;
			this.Branch.Text = "Branch";
			// 
			// Description
			// 
			this.Description.DisplayIndex = 3;
			this.Description.Text = "Description";
			this.Description.Width = 114;
			// 
			// Author
			// 
			this.Author.Text = "Author";
			// 
			// Tags
			// 
			this.Tags.Text = "Tags";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exportAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.cSVToolStripMenuItem,
            this.textToolStripMenuItem});
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.exportToolStripMenuItem.Text = "Export &Selected";
			// 
			// exportAllToolStripMenuItem
			// 
			this.exportAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.cSVToolStripMenuItem1,
            this.textToolStripMenuItem1});
			this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
			this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.exportAllToolStripMenuItem.Text = "Export &All";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnFileQuit);
			// 
			// xMLToolStripMenuItem
			// 
			this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
			this.xMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
			this.xMLToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.xMLToolStripMenuItem.Text = "&XML";
			this.xMLToolStripMenuItem.Click += new System.EventHandler(this.OnFileExportSelectedToXml);
			// 
			// cSVToolStripMenuItem
			// 
			this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
			this.cSVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
			this.cSVToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.cSVToolStripMenuItem.Text = "&CSV";
			this.cSVToolStripMenuItem.Click += new System.EventHandler(this.OnFileExportSelectedToCsv);
			// 
			// textToolStripMenuItem
			// 
			this.textToolStripMenuItem.Name = "textToolStripMenuItem";
			this.textToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
			this.textToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.textToolStripMenuItem.Text = "&Text";
			this.textToolStripMenuItem.Click += new System.EventHandler(this.OnFileExportSelectedToText);
			// 
			// xMLToolStripMenuItem1
			// 
			this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
			this.xMLToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
			this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
			this.xMLToolStripMenuItem1.Text = "&XML";
			this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.OnFileExportAllToXml);
			// 
			// cSVToolStripMenuItem1
			// 
			this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
			this.cSVToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
			this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
			this.cSVToolStripMenuItem1.Text = "&CSV";
			this.cSVToolStripMenuItem1.Click += new System.EventHandler(this.OnFileExportAllToCsv);
			// 
			// textToolStripMenuItem1
			// 
			this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
			this.textToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
			this.textToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
			this.textToolStripMenuItem1.Text = "&Text";
			this.textToolStripMenuItem1.Click += new System.EventHandler(this.OnFileExportAllToText);
			// 
			// _cmsGivernu
			// 
			this._cmsGivernu.Font = new System.Drawing.Font("Consolas", 10F);
			this._cmsGivernu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
			this._cmsGivernu.Name = "_cmsGivernu";
			this._cmsGivernu.Size = new System.Drawing.Size(213, 26);
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisionHackToolStripMenuItem,
            this.allToolStripMenuItem});
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.copyToClipboardToolStripMenuItem.Text = "Copy To &Clipboard";
			// 
			// revisionHackToolStripMenuItem
			// 
			this.revisionHackToolStripMenuItem.Name = "revisionHackToolStripMenuItem";
			this.revisionHackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.revisionHackToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.revisionHackToolStripMenuItem.Text = "&Revision Hack";
			this.revisionHackToolStripMenuItem.Click += new System.EventHandler(this.OnCopyRevisionHackToClipboard);
			// 
			// allToolStripMenuItem
			// 
			this.allToolStripMenuItem.Name = "allToolStripMenuItem";
			this.allToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.allToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.allToolStripMenuItem.Text = "&All";
			this.allToolStripMenuItem.Click += new System.EventHandler(this.OnCopySelectedRevisionToClipboard);
			// 
			// GivernuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 519);
			this.Controls.Add(this._lvGivernu);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GivernuForm";
			this.Text = "Givernu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this._cmsGivernu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ListView _lvGivernu;
		private System.Windows.Forms.ColumnHeader RevisionNumber;
		private System.Windows.Forms.ColumnHeader GitID;
		private System.Windows.Forms.ColumnHeader DateTime;
		private System.Windows.Forms.ColumnHeader Branch;
		private System.Windows.Forms.ColumnHeader Description;
		private System.Windows.Forms.ColumnHeader Author;
		private System.Windows.Forms.ColumnHeader Tags;
		private System.Windows.Forms.ToolStripStatusLabel _lblInfo;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip _cmsGivernu;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem revisionHackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
	}
}

