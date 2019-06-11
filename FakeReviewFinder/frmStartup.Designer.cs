namespace FakeReviewFinder
{
	partial class frmStartup
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
			this.label1 = new System.Windows.Forms.Label();
			this.butOpen = new System.Windows.Forms.Button();
			this.butNewProject = new System.Windows.Forms.Button();
			this.butClose = new System.Windows.Forms.Button();
			this.butSelectFolder = new System.Windows.Forms.Button();
			this.cmbPath = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Project";
			// 
			// butOpen
			// 
			this.butOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butOpen.Enabled = false;
			this.butOpen.Location = new System.Drawing.Point(437, 43);
			this.butOpen.Name = "butOpen";
			this.butOpen.Size = new System.Drawing.Size(75, 23);
			this.butOpen.TabIndex = 2;
			this.butOpen.Text = "Open project";
			this.butOpen.UseVisualStyleBackColor = true;
			this.butOpen.Click += new System.EventHandler(this.ButOpen_Click);
			// 
			// butNewProject
			// 
			this.butNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butNewProject.Enabled = false;
			this.butNewProject.Location = new System.Drawing.Point(356, 43);
			this.butNewProject.Name = "butNewProject";
			this.butNewProject.Size = new System.Drawing.Size(75, 23);
			this.butNewProject.TabIndex = 3;
			this.butNewProject.Text = "New project";
			this.butNewProject.UseVisualStyleBackColor = true;
			this.butNewProject.Click += new System.EventHandler(this.ButOpen_Click);
			// 
			// butClose
			// 
			this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butClose.Location = new System.Drawing.Point(518, 43);
			this.butClose.Name = "butClose";
			this.butClose.Size = new System.Drawing.Size(75, 23);
			this.butClose.TabIndex = 4;
			this.butClose.Text = "Close";
			this.butClose.UseVisualStyleBackColor = true;
			this.butClose.Click += new System.EventHandler(this.ButClose_Click);
			// 
			// butSelectFolder
			// 
			this.butSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butSelectFolder.Location = new System.Drawing.Point(559, 13);
			this.butSelectFolder.Name = "butSelectFolder";
			this.butSelectFolder.Size = new System.Drawing.Size(34, 23);
			this.butSelectFolder.TabIndex = 5;
			this.butSelectFolder.Text = "...";
			this.butSelectFolder.UseVisualStyleBackColor = true;
			this.butSelectFolder.Click += new System.EventHandler(this.ButSelectFolder_Click);
			// 
			// cmbPath
			// 
			this.cmbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbPath.FormattingEnabled = true;
			this.cmbPath.Location = new System.Drawing.Point(58, 16);
			this.cmbPath.Name = "cmbPath";
			this.cmbPath.Size = new System.Drawing.Size(496, 21);
			this.cmbPath.Sorted = true;
			this.cmbPath.TabIndex = 6;
			this.cmbPath.TextChanged += new System.EventHandler(this.CmbPath_TextChanged);
			// 
			// frmStartup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 76);
			this.Controls.Add(this.cmbPath);
			this.Controls.Add(this.butSelectFolder);
			this.Controls.Add(this.butClose);
			this.Controls.Add(this.butNewProject);
			this.Controls.Add(this.butOpen);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmStartup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fake Review Finder";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStartup_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butOpen;
		private System.Windows.Forms.Button butNewProject;
		private System.Windows.Forms.Button butClose;
		private System.Windows.Forms.Button butSelectFolder;
		private System.Windows.Forms.ComboBox cmbPath;
	}
}