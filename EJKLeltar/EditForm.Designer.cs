namespace EJKLeltar
{
	partial class EditForm
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
			this.titleText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.idText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.commentText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.countNumber = new System.Windows.Forms.NumericUpDown();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.outNumber = new System.Windows.Forms.NumericUpDown();
			this.subjectDrop = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.countNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.outNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// titleText
			// 
			this.titleText.Location = new System.Drawing.Point(82, 12);
			this.titleText.Name = "titleText";
			this.titleText.Size = new System.Drawing.Size(308, 20);
			this.titleText.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 15);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cím";
			// 
			// idText
			// 
			this.idText.Location = new System.Drawing.Point(82, 38);
			this.idText.Name = "idText";
			this.idText.Size = new System.Drawing.Size(117, 20);
			this.idText.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 41);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Azonosító";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 67);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Darab";
			// 
			// commentText
			// 
			this.commentText.Location = new System.Drawing.Point(82, 90);
			this.commentText.Multiline = true;
			this.commentText.Name = "commentText";
			this.commentText.Size = new System.Drawing.Size(308, 101);
			this.commentText.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 93);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Megjegyzés";
			// 
			// countNumber
			// 
			this.countNumber.Location = new System.Drawing.Point(139, 65);
			this.countNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.countNumber.Name = "countNumber";
			this.countNumber.Size = new System.Drawing.Size(79, 20);
			this.countNumber.TabIndex = 2;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(294, 203);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(96, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(192, 203);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(96, 23);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(82, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "összesen";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(266, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "kiadva";
			// 
			// outNumber
			// 
			this.outNumber.Location = new System.Drawing.Point(311, 65);
			this.outNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.outNumber.Name = "outNumber";
			this.outNumber.Size = new System.Drawing.Size(79, 20);
			this.outNumber.TabIndex = 2;
			// 
			// subjectDrop
			// 
			this.subjectDrop.FormattingEnabled = true;
			this.subjectDrop.Location = new System.Drawing.Point(273, 38);
			this.subjectDrop.Name = "subjectDrop";
			this.subjectDrop.Size = new System.Drawing.Size(117, 21);
			this.subjectDrop.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(222, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Szakma";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// EditForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(402, 238);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.subjectDrop);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.outNumber);
			this.Controls.Add(this.countNumber);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.commentText);
			this.Controls.Add(this.idText);
			this.Controls.Add(this.titleText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditForm";
			this.Text = "EditForm";
			((System.ComponentModel.ISupportInitialize)(this.countNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.outNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox titleText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox idText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox commentText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown countNumber;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown outNumber;
		private System.Windows.Forms.ComboBox subjectDrop;
		private System.Windows.Forms.Label label7;
	}
}