namespace EJKLeltar
{
	partial class AboutForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.viewLicenseLink = new System.Windows.Forms.LinkLabel();
			this.githubLink = new System.Windows.Forms.LinkLabel();
			this.mailLink = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EJKLeltar.Properties.Resources.gpl_logo;
			this.pictureBox1.Location = new System.Drawing.Point(255, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(127, 51);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Copyright (c) Motkó Gábor 2018";
			// 
			// viewLicenseLink
			// 
			this.viewLicenseLink.AutoSize = true;
			this.viewLicenseLink.LinkArea = new System.Windows.Forms.LinkArea(21, 13);
			this.viewLicenseLink.Location = new System.Drawing.Point(15, 57);
			this.viewLicenseLink.Name = "viewLicenseLink";
			this.viewLicenseLink.Size = new System.Drawing.Size(186, 17);
			this.viewLicenseLink.TabIndex = 2;
			this.viewLicenseLink.TabStop = true;
			this.viewLicenseLink.Text = "GNU GPL-3.0-or-later (megtekintés)";
			this.viewLicenseLink.UseCompatibleTextRendering = true;
			this.viewLicenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewLicenseLink_LinkClicked);
			// 
			// githubLink
			// 
			this.githubLink.AutoSize = true;
			this.githubLink.Location = new System.Drawing.Point(12, 33);
			this.githubLink.Name = "githubLink";
			this.githubLink.Size = new System.Drawing.Size(40, 13);
			this.githubLink.TabIndex = 3;
			this.githubLink.TabStop = true;
			this.githubLink.Text = "GitHub";
			this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
			// 
			// mailLink
			// 
			this.mailLink.AutoSize = true;
			this.mailLink.Location = new System.Drawing.Point(75, 33);
			this.mailLink.Name = "mailLink";
			this.mailLink.Size = new System.Drawing.Size(139, 13);
			this.mailLink.TabIndex = 4;
			this.mailLink.TabStop = true;
			this.mailLink.Text = "gabor.motko.95@gmail.com";
			this.mailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mailLink_LinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 83);
			this.Controls.Add(this.mailLink);
			this.Controls.Add(this.githubLink);
			this.Controls.Add(this.viewLicenseLink);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.Text = "Névjegy";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel viewLicenseLink;
		private System.Windows.Forms.LinkLabel githubLink;
		private System.Windows.Forms.LinkLabel mailLink;
	}
}