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
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(933, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
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
			this._lvGivernu.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lvGivernu.FullRowSelect = true;
			this._lvGivernu.HideSelection = false;
			this._lvGivernu.Location = new System.Drawing.Point(0, 49);
			this._lvGivernu.Margin = new System.Windows.Forms.Padding(0);
			this._lvGivernu.Name = "_lvGivernu";
			this._lvGivernu.Size = new System.Drawing.Size(933, 448);
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
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
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
	}
}

