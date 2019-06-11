namespace FakeReviewFinder
{
	partial class frmMaps
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaps));
			this.txtURL = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.butPastUrl = new System.Windows.Forms.ToolStripButton();
			this.butProcess = new System.Windows.Forms.ToolStripButton();
			this.butSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.butFindMissingNames = new System.Windows.Forms.ToolStripButton();
			this.panChrome = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblResult = new System.Windows.Forms.ToolStripStatusLabel();
			this.timAff = new System.Windows.Forms.Timer(this.components);
			this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.butUpdateUser = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtURL
			// 
			this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtURL.Location = new System.Drawing.Point(12, 28);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(724, 20);
			this.txtURL.TabIndex = 0;
			this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtURL_KeyPress);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butPastUrl,
            this.butProcess,
            this.butSave,
            this.toolStripSeparator1,
            this.butFindMissingNames,
            this.toolStripSeparator2,
            this.butUpdateUser});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(999, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// butPastUrl
			// 
			this.butPastUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butPastUrl.Image = ((System.Drawing.Image)(resources.GetObject("butPastUrl.Image")));
			this.butPastUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butPastUrl.Name = "butPastUrl";
			this.butPastUrl.Size = new System.Drawing.Size(57, 22);
			this.butPastUrl.Text = "Past URL";
			this.butPastUrl.Click += new System.EventHandler(this.butPastUrl_Click);
			// 
			// butProcess
			// 
			this.butProcess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butProcess.Image = ((System.Drawing.Image)(resources.GetObject("butProcess.Image")));
			this.butProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butProcess.Name = "butProcess";
			this.butProcess.Size = new System.Drawing.Size(51, 22);
			this.butProcess.Text = "Process";
			this.butProcess.Click += new System.EventHandler(this.butProcess_Click);
			// 
			// butSave
			// 
			this.butSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butSave.Image = ((System.Drawing.Image)(resources.GetObject("butSave.Image")));
			this.butSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butSave.Name = "butSave";
			this.butSave.Size = new System.Drawing.Size(35, 22);
			this.butSave.Text = "Save";
			this.butSave.Click += new System.EventHandler(this.butSave_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// butFindMissingNames
			// 
			this.butFindMissingNames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butFindMissingNames.Image = ((System.Drawing.Image)(resources.GetObject("butFindMissingNames.Image")));
			this.butFindMissingNames.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butFindMissingNames.Name = "butFindMissingNames";
			this.butFindMissingNames.Size = new System.Drawing.Size(116, 22);
			this.butFindMissingNames.Text = "Find missing names";
			this.butFindMissingNames.Click += new System.EventHandler(this.butFindMissingNames_Click);
			// 
			// panChrome
			// 
			this.panChrome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panChrome.Location = new System.Drawing.Point(3, 3);
			this.panChrome.Name = "panChrome";
			this.panChrome.Size = new System.Drawing.Size(481, 522);
			this.panChrome.TabIndex = 2;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblResult});
			this.statusStrip1.Location = new System.Drawing.Point(0, 585);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(999, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblResult
			// 
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(48, 17);
			this.lblResult.Text = "Result...";
			// 
			// timAff
			// 
			this.timAff.Enabled = true;
			this.timAff.Tick += new System.EventHandler(this.timAff_Tick);
			// 
			// flowReviews
			// 
			this.flowReviews.AutoScroll = true;
			this.flowReviews.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowReviews.Location = new System.Drawing.Point(490, 3);
			this.flowReviews.Name = "flowReviews";
			this.flowReviews.Size = new System.Drawing.Size(482, 522);
			this.flowReviews.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panChrome, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowReviews, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 54);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 528);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// butUpdateUser
			// 
			this.butUpdateUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("butUpdateUser.Image")));
			this.butUpdateUser.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butUpdateUser.Name = "butUpdateUser";
			this.butUpdateUser.Size = new System.Drawing.Size(79, 22);
			this.butUpdateUser.Text = "Update users";
			this.butUpdateUser.Click += new System.EventHandler(this.butUpdateUser_Click);
			// 
			// frmMaps
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(999, 607);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.txtURL);
			this.Name = "frmMaps";
			this.Text = "Maps";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaps_FormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Panel panChrome;
		private System.Windows.Forms.ToolStripButton butProcess;
		private System.Windows.Forms.ToolStripButton butPastUrl;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblResult;
		private System.Windows.Forms.Timer timAff;
		private System.Windows.Forms.ToolStripButton butSave;
		private System.Windows.Forms.FlowLayoutPanel flowReviews;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton butFindMissingNames;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton butUpdateUser;
	}
}

