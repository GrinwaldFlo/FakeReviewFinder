namespace FakeReviewFinder
{
	partial class ucUser
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
			this.flow = new System.Windows.Forms.FlowLayoutPanel();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLevel = new System.Windows.Forms.Label();
			this.lblNbReview = new System.Windows.Forms.Label();
			this.lblNbRating = new System.Windows.Forms.Label();
			this.lblPoints = new System.Windows.Forms.Label();
			this.lblUrl = new System.Windows.Forms.Label();
			this.flow.SuspendLayout();
			this.SuspendLayout();
			// 
			// flow
			// 
			this.flow.BackColor = System.Drawing.Color.Black;
			this.flow.Controls.Add(this.lblName);
			this.flow.Controls.Add(this.lblLevel);
			this.flow.Controls.Add(this.lblNbReview);
			this.flow.Controls.Add(this.lblNbRating);
			this.flow.Controls.Add(this.lblPoints);
			this.flow.Controls.Add(this.lblUrl);
			this.flow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flow.Location = new System.Drawing.Point(0, 0);
			this.flow.Name = "flow";
			this.flow.Size = new System.Drawing.Size(348, 16);
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
			this.lblName.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblLevel
			// 
			this.lblLevel.BackColor = System.Drawing.Color.White;
			this.lblLevel.Location = new System.Drawing.Point(152, 0);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(29, 13);
			this.lblLevel.TabIndex = 1;
			this.lblLevel.Text = "9";
			this.lblLevel.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblNbReview
			// 
			this.lblNbReview.BackColor = System.Drawing.Color.White;
			this.lblNbReview.Location = new System.Drawing.Point(187, 0);
			this.lblNbReview.Name = "lblNbReview";
			this.lblNbReview.Size = new System.Drawing.Size(29, 13);
			this.lblNbReview.TabIndex = 2;
			this.lblNbReview.Text = "999";
			this.lblNbReview.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblNbRating
			// 
			this.lblNbRating.BackColor = System.Drawing.Color.White;
			this.lblNbRating.Location = new System.Drawing.Point(222, 0);
			this.lblNbRating.Name = "lblNbRating";
			this.lblNbRating.Size = new System.Drawing.Size(29, 13);
			this.lblNbRating.TabIndex = 3;
			this.lblNbRating.Text = "999";
			this.lblNbRating.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblPoints
			// 
			this.lblPoints.BackColor = System.Drawing.Color.White;
			this.lblPoints.Location = new System.Drawing.Point(257, 0);
			this.lblPoints.Name = "lblPoints";
			this.lblPoints.Size = new System.Drawing.Size(36, 13);
			this.lblPoints.TabIndex = 4;
			this.lblPoints.Text = "9999";
			this.lblPoints.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// lblUrl
			// 
			this.lblUrl.BackColor = System.Drawing.Color.White;
			this.lblUrl.Location = new System.Drawing.Point(299, 0);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(36, 13);
			this.lblUrl.TabIndex = 5;
			this.lblUrl.Text = "URL";
			this.lblUrl.Click += new System.EventHandler(this.lblUrl_Click);
			this.lblUrl.MouseHover += new System.EventHandler(this.lblName_MouseHover);
			// 
			// ucUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flow);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ucUser";
			this.Size = new System.Drawing.Size(348, 16);
			this.flow.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flow;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblLevel;
		private System.Windows.Forms.Label lblNbReview;
		private System.Windows.Forms.Label lblNbRating;
		private System.Windows.Forms.Label lblPoints;
		private System.Windows.Forms.Label lblUrl;
	}
}
