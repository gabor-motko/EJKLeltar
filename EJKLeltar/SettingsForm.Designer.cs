namespace EJKLeltar
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
			this.startUpGroup = new System.Windows.Forms.GroupBox();
			this.newOnStartupCheck = new System.Windows.Forms.RadioButton();
			this.openLastStartupCheck = new System.Windows.Forms.RadioButton();
			this.startUpGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// startUpGroup
			// 
			this.startUpGroup.Controls.Add(this.openLastStartupCheck);
			this.startUpGroup.Controls.Add(this.newOnStartupCheck);
			this.startUpGroup.Location = new System.Drawing.Point(12, 12);
			this.startUpGroup.Name = "startUpGroup";
			this.startUpGroup.Size = new System.Drawing.Size(250, 68);
			this.startUpGroup.TabIndex = 0;
			this.startUpGroup.TabStop = false;
			this.startUpGroup.Text = "Indításkor";
			// 
			// newOnStartupCheck
			// 
			this.newOnStartupCheck.AutoSize = true;
			this.newOnStartupCheck.Location = new System.Drawing.Point(6, 19);
			this.newOnStartupCheck.Name = "newOnStartupCheck";
			this.newOnStartupCheck.Size = new System.Drawing.Size(99, 17);
			this.newOnStartupCheck.TabIndex = 0;
			this.newOnStartupCheck.TabStop = true;
			this.newOnStartupCheck.Text = "Új dokumentum";
			this.newOnStartupCheck.UseVisualStyleBackColor = true;
			// 
			// openLastStartupCheck
			// 
			this.openLastStartupCheck.AutoSize = true;
			this.openLastStartupCheck.Location = new System.Drawing.Point(6, 42);
			this.openLastStartupCheck.Name = "openLastStartupCheck";
			this.openLastStartupCheck.Size = new System.Drawing.Size(128, 17);
			this.openLastStartupCheck.TabIndex = 0;
			this.openLastStartupCheck.TabStop = true;
			this.openLastStartupCheck.Text = "Legutóbbi megnyitása";
			this.openLastStartupCheck.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 300);
			this.Controls.Add(this.startUpGroup);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Beállítások";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.startUpGroup.ResumeLayout(false);
			this.startUpGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox startUpGroup;
		private System.Windows.Forms.RadioButton newOnStartupCheck;
		private System.Windows.Forms.RadioButton openLastStartupCheck;
	}
}