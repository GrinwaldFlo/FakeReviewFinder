namespace FakeReviewFinder
{
	partial class ucShop
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flow = new System.Windows.Forms.FlowLayoutPanel();
			this.lblName = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblUrl = new System.Windows.Forms.Label();
			this.lblMenu = new System.Windows.Forms.Label();
			this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flow.SuspendLayout();
			this.cMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// flow
			// 
			this.flow.BackColor = System.Drawing.Color.Black;
			this.flow.Controls.Add(this.lblName);
			this.flow.Controls.Add(this.lblAddress);
			this.flow.Controls.Add(this.lblUrl);
			this.flow.Controls.Add(this.lblMenu);
			this.flow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flow.Location = new System.Drawing.Point(0, 0);
			this.flow.Name = "flow";
			this.flow.Size = new System.Drawing.Size(361, 14);
			this.flow.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.BackColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(3, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(143, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			this.lblName.DoubleClick += new System.EventHandler(this.lblName_DoubleClick);
			this.lblName.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblAddress
			// 
			this.lblAddress.BackColor = System.Drawing.Color.White;
			this.lblAddress.Location = new System.Drawing.Point(152, 0);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(120, 13);
			this.lblAddress.TabIndex = 1;
			this.lblAddress.Text = "9";
			this.lblAddress.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblUrl
			// 
			this.lblUrl.BackColor = System.Drawing.Color.White;
			this.lblUrl.Location = new System.Drawing.Point(278, 0);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(36, 13);
			this.lblUrl.TabIndex = 5;
			this.lblUrl.Text = "URL";
			this.lblUrl.Click += new System.EventHandler(this.lblUrl_Click);
			this.lblUrl.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblMenu
			// 
			this.lblMenu.BackColor = System.Drawing.Color.White;
			this.lblMenu.ContextMenuStrip = this.cMenu;
			this.lblMenu.Location = new System.Drawing.Point(320, 0);
			this.lblMenu.Name = "lblMenu";
			this.lblMenu.Size = new System.Drawing.Size(37, 13);
			this.lblMenu.TabIndex = 6;
			this.lblMenu.Text = "menu";
			this.lblMenu.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// cMenu
			// 
			this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyReviewToolStripMenuItem});
			this.cMenu.Name = "cMenu";
			this.cMenu.Size = new System.Drawing.Size(140, 26);
			// 
			// copyReviewToolStripMenuItem
			// 
			this.copyReviewToolStripMenuItem.Name = "copyReviewToolStripMenuItem";
			this.copyReviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyReviewToolStripMenuItem.Text = "Copy review";
			this.copyReviewToolStripMenuItem.Click += new System.EventHandler(this.copyReviewToolStripMenuItem_Click);
			// 
			// ucShop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flow);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ucShop";
			this.Size = new System.Drawing.Size(361, 14);
			this.flow.ResumeLayout(false);
			this.cMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flow;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.Label lblMenu;
		private System.Windows.Forms.ContextMenuStrip cMenu;
		private System.Windows.Forms.ToolStripMenuItem copyReviewToolStripMenuItem;
	}
}
