namespace FakeReviewFinder
{
	partial class frmData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmData));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.butUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtMinReview = new System.Windows.Forms.ToolStripTextBox();
			this.butSwiss = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.butAddMore = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.butCheckShop = new System.Windows.Forms.ToolStripButton();
			this.flowUser = new System.Windows.Forms.FlowLayoutPanel();
			this.flowShop = new System.Windows.Forms.FlowLayoutPanel();
			this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowReviewShop = new System.Windows.Forms.FlowLayoutPanel();
			this.timAff = new System.Windows.Forms.Timer(this.components);
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.copyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.findAffinityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.copyGridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.copyLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butUpdate,
            this.toolStripLabel1,
            this.txtMinReview,
            this.butSwiss,
            this.toolStripSeparator1,
            this.butAddMore,
            this.toolStripSeparator2,
            this.butCheckShop,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(834, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// butUpdate
			// 
			this.butUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butUpdate.Image = ((System.Drawing.Image)(resources.GetObject("butUpdate.Image")));
			this.butUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butUpdate.Name = "butUpdate";
			this.butUpdate.Size = new System.Drawing.Size(50, 22);
			this.butUpdate.Text = "Refresh";
			this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
			this.toolStripLabel1.Text = "Min review";
			// 
			// txtMinReview
			// 
			this.txtMinReview.Name = "txtMinReview";
			this.txtMinReview.Size = new System.Drawing.Size(25, 25);
			this.txtMinReview.Text = "4";
			this.txtMinReview.TextChanged += new System.EventHandler(this.txtMinReview_TextChanged);
			// 
			// butSwiss
			// 
			this.butSwiss.CheckOnClick = true;
			this.butSwiss.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butSwiss.Image = ((System.Drawing.Image)(resources.GetObject("butSwiss.Image")));
			this.butSwiss.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butSwiss.Name = "butSwiss";
			this.butSwiss.Size = new System.Drawing.Size(67, 22);
			this.butSwiss.Text = "Swiss Only";
			this.butSwiss.Click += new System.EventHandler(this.butSwiss_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// butAddMore
			// 
			this.butAddMore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butAddMore.Image = ((System.Drawing.Image)(resources.GetObject("butAddMore.Image")));
			this.butAddMore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butAddMore.Name = "butAddMore";
			this.butAddMore.Size = new System.Drawing.Size(64, 22);
			this.butAddMore.Text = "Add more";
			this.butAddMore.Click += new System.EventHandler(this.butAddMore_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// butCheckShop
			// 
			this.butCheckShop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.butCheckShop.Image = ((System.Drawing.Image)(resources.GetObject("butCheckShop.Image")));
			this.butCheckShop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butCheckShop.Name = "butCheckShop";
			this.butCheckShop.Size = new System.Drawing.Size(78, 22);
			this.butCheckShop.Text = "Check shops";
			this.butCheckShop.Click += new System.EventHandler(this.butCheckShop_Click);
			// 
			// flowUser
			// 
			this.flowUser.AutoScroll = true;
			this.flowUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowUser.Location = new System.Drawing.Point(3, 3);
			this.flowUser.Name = "flowUser";
			this.flowUser.Size = new System.Drawing.Size(199, 487);
			this.flowUser.TabIndex = 1;
			// 
			// flowShop
			// 
			this.flowShop.AutoScroll = true;
			this.flowShop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowShop.Location = new System.Drawing.Point(413, 3);
			this.flowShop.Name = "flowShop";
			this.flowShop.Size = new System.Drawing.Size(199, 487);
			this.flowShop.TabIndex = 2;
			// 
			// flowReviews
			// 
			this.flowReviews.AutoScroll = true;
			this.flowReviews.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowReviews.Location = new System.Drawing.Point(208, 3);
			this.flowReviews.Name = "flowReviews";
			this.flowReviews.Size = new System.Drawing.Size(199, 487);
			this.flowReviews.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.flowReviewShop, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowUser, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowReviews, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowShop, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 493);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// flowReviewShop
			// 
			this.flowReviewShop.AutoScroll = true;
			this.flowReviewShop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowReviewShop.Location = new System.Drawing.Point(618, 3);
			this.flowReviewShop.Name = "flowReviewShop";
			this.flowReviewShop.Size = new System.Drawing.Size(201, 487);
			this.flowReviewShop.TabIndex = 5;
			// 
			// timAff
			// 
			this.timAff.Enabled = true;
			this.timAff.Tick += new System.EventHandler(this.timAff_Tick);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyUserToolStripMenuItem,
            this.copyShopToolStripMenuItem,
            this.copyGridToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(48, 22);
			this.toolStripDropDownButton1.Text = "Copy";
			// 
			// copyUserToolStripMenuItem
			// 
			this.copyUserToolStripMenuItem.Name = "copyUserToolStripMenuItem";
			this.copyUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyUserToolStripMenuItem.Text = "Copy User";
			this.copyUserToolStripMenuItem.Click += new System.EventHandler(this.copyUserToolStripMenuItem_Click);
			// 
			// copyShopToolStripMenuItem
			// 
			this.copyShopToolStripMenuItem.Name = "copyShopToolStripMenuItem";
			this.copyShopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyShopToolStripMenuItem.Text = "Copy Shop";
			this.copyShopToolStripMenuItem.Click += new System.EventHandler(this.copyShopToolStripMenuItem_Click);
			// 
			// copyGridToolStripMenuItem
			// 
			this.copyGridToolStripMenuItem.Name = "copyGridToolStripMenuItem";
			this.copyGridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyGridToolStripMenuItem.Text = "Copy Grid";
			this.copyGridToolStripMenuItem.Click += new System.EventHandler(this.copyGridToolStripMenuItem_Click);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAffinityToolStripMenuItem,
            this.copyUserToolStripMenuItem1,
            this.copyGridToolStripMenuItem1,
            this.copyLToolStripMenuItem});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(59, 22);
			this.toolStripDropDownButton2.Text = "Affinity";
			// 
			// findAffinityToolStripMenuItem
			// 
			this.findAffinityToolStripMenuItem.Name = "findAffinityToolStripMenuItem";
			this.findAffinityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.findAffinityToolStripMenuItem.Text = "Find affinity";
			this.findAffinityToolStripMenuItem.Click += new System.EventHandler(this.findAffinityToolStripMenuItem_Click);
			// 
			// copyUserToolStripMenuItem1
			// 
			this.copyUserToolStripMenuItem1.Name = "copyUserToolStripMenuItem1";
			this.copyUserToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.copyUserToolStripMenuItem1.Text = "Copy User - Shop";
			this.copyUserToolStripMenuItem1.Click += new System.EventHandler(this.copyUserToolStripMenuItem1_Click);
			// 
			// copyGridToolStripMenuItem1
			// 
			this.copyGridToolStripMenuItem1.Name = "copyGridToolStripMenuItem1";
			this.copyGridToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.copyGridToolStripMenuItem1.Text = "Copy Grid";
			this.copyGridToolStripMenuItem1.Click += new System.EventHandler(this.copyGridToolStripMenuItem1_Click);
			// 
			// copyLToolStripMenuItem
			// 
			this.copyLToolStripMenuItem.Name = "copyLToolStripMenuItem";
			this.copyLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyLToolStripMenuItem.Text = "Copy Links";
			this.copyLToolStripMenuItem.Click += new System.EventHandler(this.copyLToolStripMenuItem_Click);
			// 
			// frmData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 521);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmData";
			this.Text = "Data";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmData_FormClosing);
			this.Load += new System.EventHandler(this.frmData_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.FlowLayoutPanel flowUser;
		private System.Windows.Forms.FlowLayoutPanel flowShop;
		private System.Windows.Forms.ToolStripButton butUpdate;
		private System.Windows.Forms.FlowLayoutPanel flowReviews;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowReviewShop;
		private System.Windows.Forms.Timer timAff;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox txtMinReview;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton butAddMore;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton butSwiss;
		private System.Windows.Forms.ToolStripButton butCheckShop;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem copyUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyShopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyGridToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem findAffinityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyUserToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyGridToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyLToolStripMenuItem;
	}
}