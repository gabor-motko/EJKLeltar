﻿namespace EJKLeltar
{
	partial class SettingsForm
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
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.newOnStartupCheck = new System.Windows.Forms.RadioButton();
			this.openLastStartupCheck = new System.Windows.Forms.RadioButton();
			this.startUpGroup = new System.Windows.Forms.GroupBox();
			this.defaultOnStartupCheck = new System.Windows.Forms.RadioButton();
			this.backupSameDirCheck = new System.Windows.Forms.RadioButton();
			this.backupSelectDirCheck = new System.Windows.Forms.RadioButton();
			this.browseBackupButton = new System.Windows.Forms.Button();
			this.backupPathText = new System.Windows.Forms.TextBox();
			this.backupNumber = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.backupGroup = new System.Windows.Forms.GroupBox();
			this.startUpGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.backupNumber)).BeginInit();
			this.backupGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Location = new System.Drawing.Point(419, 226);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(113, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Mégse";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(300, 226);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(113, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// newOnStartupCheck
			// 
			this.newOnStartupCheck.AutoSize = true;
			this.newOnStartupCheck.Enabled = false;
			this.newOnStartupCheck.Location = new System.Drawing.Point(6, 42);
			this.newOnStartupCheck.Name = "newOnStartupCheck";
			this.newOnStartupCheck.Size = new System.Drawing.Size(99, 17);
			this.newOnStartupCheck.TabIndex = 0;
			this.newOnStartupCheck.Text = "Új dokumentum";
			this.newOnStartupCheck.UseVisualStyleBackColor = true;
			// 
			// openLastStartupCheck
			// 
			this.openLastStartupCheck.AutoSize = true;
			this.openLastStartupCheck.Enabled = false;
			this.openLastStartupCheck.Location = new System.Drawing.Point(6, 65);
			this.openLastStartupCheck.Name = "openLastStartupCheck";
			this.openLastStartupCheck.Size = new System.Drawing.Size(128, 17);
			this.openLastStartupCheck.TabIndex = 0;
			this.openLastStartupCheck.Text = "Legutóbbi megnyitása";
			this.openLastStartupCheck.UseVisualStyleBackColor = true;
			// 
			// startUpGroup
			// 
			this.startUpGroup.Controls.Add(this.defaultOnStartupCheck);
			this.startUpGroup.Controls.Add(this.openLastStartupCheck);
			this.startUpGroup.Controls.Add(this.newOnStartupCheck);
			this.startUpGroup.Location = new System.Drawing.Point(12, 12);
			this.startUpGroup.Name = "startUpGroup";
			this.startUpGroup.Size = new System.Drawing.Size(318, 93);
			this.startUpGroup.TabIndex = 0;
			this.startUpGroup.TabStop = false;
			this.startUpGroup.Text = "Indításkor";
			// 
			// defaultOnStartupCheck
			// 
			this.defaultOnStartupCheck.AutoSize = true;
			this.defaultOnStartupCheck.Checked = true;
			this.defaultOnStartupCheck.Enabled = false;
			this.defaultOnStartupCheck.Location = new System.Drawing.Point(6, 19);
			this.defaultOnStartupCheck.Name = "defaultOnStartupCheck";
			this.defaultOnStartupCheck.Size = new System.Drawing.Size(153, 17);
			this.defaultOnStartupCheck.TabIndex = 0;
			this.defaultOnStartupCheck.TabStop = true;
			this.defaultOnStartupCheck.Text = "Alapértelmezett megnyitása";
			this.defaultOnStartupCheck.UseVisualStyleBackColor = true;
			// 
			// backupSameDirCheck
			// 
			this.backupSameDirCheck.AutoSize = true;
			this.backupSameDirCheck.Checked = true;
			this.backupSameDirCheck.Location = new System.Drawing.Point(6, 19);
			this.backupSameDirCheck.Name = "backupSameDirCheck";
			this.backupSameDirCheck.Size = new System.Drawing.Size(168, 17);
			this.backupSameDirCheck.TabIndex = 0;
			this.backupSameDirCheck.TabStop = true;
			this.backupSameDirCheck.Text = "A fájllal megegyező mappában";
			this.backupSameDirCheck.UseVisualStyleBackColor = true;
			// 
			// backupSelectDirCheck
			// 
			this.backupSelectDirCheck.AutoSize = true;
			this.backupSelectDirCheck.Location = new System.Drawing.Point(6, 42);
			this.backupSelectDirCheck.Name = "backupSelectDirCheck";
			this.backupSelectDirCheck.Size = new System.Drawing.Size(135, 17);
			this.backupSelectDirCheck.TabIndex = 0;
			this.backupSelectDirCheck.TabStop = true;
			this.backupSelectDirCheck.Text = "A megadott mappában:";
			this.backupSelectDirCheck.UseVisualStyleBackColor = true;
			// 
			// browseBackupButton
			// 
			this.browseBackupButton.Location = new System.Drawing.Point(390, 39);
			this.browseBackupButton.Name = "browseBackupButton";
			this.browseBackupButton.Size = new System.Drawing.Size(30, 23);
			this.browseBackupButton.TabIndex = 1;
			this.browseBackupButton.Text = "...";
			this.browseBackupButton.UseVisualStyleBackColor = true;
			// 
			// backupPathText
			// 
			this.backupPathText.Location = new System.Drawing.Point(147, 41);
			this.backupPathText.Name = "backupPathText";
			this.backupPathText.Size = new System.Drawing.Size(237, 20);
			this.backupPathText.TabIndex = 2;
			// 
			// backupNumber
			// 
			this.backupNumber.Location = new System.Drawing.Point(102, 71);
			this.backupNumber.Name = "backupNumber";
			this.backupNumber.Size = new System.Drawing.Size(120, 20);
			this.backupNumber.TabIndex = 3;
			this.backupNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mentések száma:";
			// 
			// backupGroup
			// 
			this.backupGroup.Controls.Add(this.label1);
			this.backupGroup.Controls.Add(this.backupNumber);
			this.backupGroup.Controls.Add(this.backupPathText);
			this.backupGroup.Controls.Add(this.browseBackupButton);
			this.backupGroup.Controls.Add(this.backupSelectDirCheck);
			this.backupGroup.Controls.Add(this.backupSameDirCheck);
			this.backupGroup.Location = new System.Drawing.Point(12, 111);
			this.backupGroup.Name = "backupGroup";
			this.backupGroup.Size = new System.Drawing.Size(441, 103);
			this.backupGroup.TabIndex = 2;
			this.backupGroup.TabStop = false;
			this.backupGroup.Text = "Biztonsági mentés";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 261);
			this.Controls.Add(this.backupGroup);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.startUpGroup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Beállítások";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.startUpGroup.ResumeLayout(false);
			this.startUpGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.backupNumber)).EndInit();
			this.backupGroup.ResumeLayout(false);
			this.backupGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.RadioButton newOnStartupCheck;
		private System.Windows.Forms.RadioButton openLastStartupCheck;
		private System.Windows.Forms.GroupBox startUpGroup;
		private System.Windows.Forms.RadioButton backupSameDirCheck;
		private System.Windows.Forms.RadioButton backupSelectDirCheck;
		private System.Windows.Forms.Button browseBackupButton;
		private System.Windows.Forms.TextBox backupPathText;
		private System.Windows.Forms.NumericUpDown backupNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox backupGroup;
		private System.Windows.Forms.RadioButton defaultOnStartupCheck;
	}
}