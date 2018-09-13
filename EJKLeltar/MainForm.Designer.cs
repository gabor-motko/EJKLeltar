namespace EJKLeltar
{
	partial class MainForm
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
			this.mainList = new System.Windows.Forms.ListView();
			this.codeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mainListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchText = new System.Windows.Forms.TextBox();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.borrowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.returnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titleText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.idText = new System.Windows.Forms.TextBox();
			this.quantityGroup = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.totalText = new System.Windows.Forms.TextBox();
			this.inText = new System.Windows.Forms.TextBox();
			this.outText = new System.Windows.Forms.TextBox();
			this.operationGroup = new System.Windows.Forms.GroupBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.returnButton = new System.Windows.Forms.Button();
			this.borrowButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.commentText = new System.Windows.Forms.TextBox();
			this.subjectDrop = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.subjectText = new System.Windows.Forms.TextBox();
			this.openDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.mainListContextMenu.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.quantityGroup.SuspendLayout();
			this.operationGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainList
			// 
			this.mainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeHeader,
            this.titleHeader});
			this.mainList.FullRowSelect = true;
			this.mainList.GridLines = true;
			this.mainList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.mainList.HideSelection = false;
			this.mainList.Location = new System.Drawing.Point(12, 53);
			this.mainList.MultiSelect = false;
			this.mainList.Name = "mainList";
			this.mainList.Size = new System.Drawing.Size(341, 397);
			this.mainList.TabIndex = 0;
			this.mainList.UseCompatibleStateImageBehavior = false;
			this.mainList.View = System.Windows.Forms.View.Details;
			this.mainList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mainList_ItemSelectionChanged);
			this.mainList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainList_MouseClick);
			// 
			// codeHeader
			// 
			this.codeHeader.Text = "Kód";
			this.codeHeader.Width = 88;
			// 
			// titleHeader
			// 
			this.titleHeader.Text = "Cím";
			this.titleHeader.Width = 238;
			// 
			// mainListContextMenu
			// 
			this.mainListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.toolStripSeparator3,
            this.newToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.toolStripSeparator4,
            this.deleteToolStripMenuItem});
			this.mainListContextMenu.Name = "mainListContextMenu";
			this.mainListContextMenu.Size = new System.Drawing.Size(151, 126);
			// 
			// borrowToolStripMenuItem
			// 
			this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
			this.borrowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.borrowToolStripMenuItem.Text = "Kikölcsönzés...";
			this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowButton_Click);
			// 
			// returnToolStripMenuItem
			// 
			this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
			this.returnToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.returnToolStripMenuItem.Text = "Visszavétel...";
			this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnButton_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.newToolStripMenuItem.Text = "Új könyv...";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
			this.editToolStripMenuItem1.Text = "Szerkesztés...";
			this.editToolStripMenuItem1.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(147, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.deleteToolStripMenuItem.Text = "Törlés";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
			// 
			// searchText
			// 
			this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchText.Location = new System.Drawing.Point(12, 27);
			this.searchText.Name = "searchText";
			this.searchText.Size = new System.Drawing.Size(168, 20);
			this.searchText.TabIndex = 1;
			this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyDown);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
			this.mainMenuStrip.TabIndex = 2;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.saveCopyToolStripMenuItem,
            this.toolStripSeparator8,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&Fájl";
			// 
			// newFileToolStripMenuItem
			// 
			this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
			this.newFileToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.newFileToolStripMenuItem.Text = "Új dokumentum";
			this.newFileToolStripMenuItem.Visible = false;
			this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
			// 
			// openFileToolStripMenuItem
			// 
			this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
			this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openFileToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.openFileToolStripMenuItem.Text = "Megnyitás...";
			this.openFileToolStripMenuItem.Visible = false;
			this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.saveToolStripMenuItem.Text = "Mentés";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.saveAsToolStripMenuItem.Text = "Mentés másként...";
			this.saveAsToolStripMenuItem.Visible = false;
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.importToolStripMenuItem.Text = "Importálás...";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// saveCopyToolStripMenuItem
			// 
			this.saveCopyToolStripMenuItem.Name = "saveCopyToolStripMenuItem";
			this.saveCopyToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.saveCopyToolStripMenuItem.Text = "Másolat mentése...";
			this.saveCopyToolStripMenuItem.Click += new System.EventHandler(this.saveCopyToolStripMenuItem_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(239, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.exitToolStripMenuItem.Text = "Kilépés";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.toolStripSeparator6,
            this.borrowToolStripMenuItem1,
            this.returnToolStripMenuItem1,
            this.toolStripSeparator5,
            this.deleteToolStripMenuItem1,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.editToolStripMenuItem.Text = "Sz&erkesztés";
			// 
			// newBookToolStripMenuItem
			// 
			this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
			this.newBookToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newBookToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.newBookToolStripMenuItem.Text = "Új könyv felvétele...";
			this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
			// 
			// editBookToolStripMenuItem
			// 
			this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
			this.editBookToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.editBookToolStripMenuItem.Text = "Kiválasztott könyv szerkesztése...";
			this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(241, 6);
			// 
			// borrowToolStripMenuItem1
			// 
			this.borrowToolStripMenuItem1.Name = "borrowToolStripMenuItem1";
			this.borrowToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
			this.borrowToolStripMenuItem1.Text = "Kikölcsönzés";
			this.borrowToolStripMenuItem1.Click += new System.EventHandler(this.borrowButton_Click);
			// 
			// returnToolStripMenuItem1
			// 
			this.returnToolStripMenuItem1.Name = "returnToolStripMenuItem1";
			this.returnToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
			this.returnToolStripMenuItem1.Text = "Visszavétel";
			this.returnToolStripMenuItem1.Click += new System.EventHandler(this.returnButton_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(241, 6);
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
			this.deleteToolStripMenuItem1.Text = "Kiválasztott könyv törlése";
			this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.settingsToolStripMenuItem.Text = "Beállítások...";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator7,
            this.updateToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.helpToolStripMenuItem.Text = "Súg&ó";
			// 
			// showHelpToolStripMenuItem
			// 
			this.showHelpToolStripMenuItem.Enabled = false;
			this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
			this.showHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.showHelpToolStripMenuItem.Text = "Súgó";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.aboutToolStripMenuItem.Text = "Névjegy";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(114, 6);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.updateToolStripMenuItem.Text = "Frissítés";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// titleText
			// 
			this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.titleText.BackColor = System.Drawing.SystemColors.Window;
			this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.titleText.Location = new System.Drawing.Point(359, 27);
			this.titleText.Multiline = true;
			this.titleText.Name = "titleText";
			this.titleText.ReadOnly = true;
			this.titleText.Size = new System.Drawing.Size(413, 68);
			this.titleText.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(359, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kiadói azonosító";
			// 
			// idText
			// 
			this.idText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.idText.BackColor = System.Drawing.SystemColors.Window;
			this.idText.Location = new System.Drawing.Point(495, 101);
			this.idText.Name = "idText";
			this.idText.ReadOnly = true;
			this.idText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.idText.Size = new System.Drawing.Size(277, 20);
			this.idText.TabIndex = 6;
			// 
			// quantityGroup
			// 
			this.quantityGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.quantityGroup.Controls.Add(this.label4);
			this.quantityGroup.Controls.Add(this.label3);
			this.quantityGroup.Controls.Add(this.label2);
			this.quantityGroup.Controls.Add(this.totalText);
			this.quantityGroup.Controls.Add(this.inText);
			this.quantityGroup.Controls.Add(this.outText);
			this.quantityGroup.Location = new System.Drawing.Point(359, 153);
			this.quantityGroup.Name = "quantityGroup";
			this.quantityGroup.Size = new System.Drawing.Size(413, 79);
			this.quantityGroup.TabIndex = 8;
			this.quantityGroup.TabStop = false;
			this.quantityGroup.Text = "Darab";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(295, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Összesen";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(168, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Kikölcsönözve";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(41, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Raktáron";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// totalText
			// 
			this.totalText.BackColor = System.Drawing.SystemColors.Window;
			this.totalText.Location = new System.Drawing.Point(285, 53);
			this.totalText.Name = "totalText";
			this.totalText.ReadOnly = true;
			this.totalText.Size = new System.Drawing.Size(96, 20);
			this.totalText.TabIndex = 0;
			// 
			// inText
			// 
			this.inText.BackColor = System.Drawing.SystemColors.Window;
			this.inText.Location = new System.Drawing.Point(31, 53);
			this.inText.Name = "inText";
			this.inText.ReadOnly = true;
			this.inText.Size = new System.Drawing.Size(96, 20);
			this.inText.TabIndex = 0;
			// 
			// outText
			// 
			this.outText.BackColor = System.Drawing.SystemColors.Window;
			this.outText.Location = new System.Drawing.Point(158, 53);
			this.outText.Name = "outText";
			this.outText.ReadOnly = true;
			this.outText.Size = new System.Drawing.Size(96, 20);
			this.outText.TabIndex = 0;
			// 
			// operationGroup
			// 
			this.operationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.operationGroup.Controls.Add(this.deleteButton);
			this.operationGroup.Controls.Add(this.addButton);
			this.operationGroup.Controls.Add(this.editButton);
			this.operationGroup.Controls.Add(this.returnButton);
			this.operationGroup.Controls.Add(this.borrowButton);
			this.operationGroup.Location = new System.Drawing.Point(359, 238);
			this.operationGroup.Name = "operationGroup";
			this.operationGroup.Size = new System.Drawing.Size(413, 126);
			this.operationGroup.TabIndex = 4;
			this.operationGroup.TabStop = false;
			this.operationGroup.Text = "Műveletek";
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(282, 97);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(125, 23);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "Törlés";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(144, 97);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(125, 23);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Leltárba vétel";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(6, 97);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(125, 23);
			this.editButton.TabIndex = 2;
			this.editButton.Text = "Módosítás";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
			// 
			// returnButton
			// 
			this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.returnButton.Location = new System.Drawing.Point(220, 19);
			this.returnButton.Name = "returnButton";
			this.returnButton.Size = new System.Drawing.Size(187, 33);
			this.returnButton.TabIndex = 1;
			this.returnButton.Text = "Visszavétel";
			this.returnButton.UseVisualStyleBackColor = true;
			this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
			// 
			// borrowButton
			// 
			this.borrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.borrowButton.Location = new System.Drawing.Point(6, 19);
			this.borrowButton.Name = "borrowButton";
			this.borrowButton.Size = new System.Drawing.Size(187, 33);
			this.borrowButton.TabIndex = 0;
			this.borrowButton.Text = "Kikölcsönzés";
			this.borrowButton.UseVisualStyleBackColor = true;
			this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchButton.Location = new System.Drawing.Point(276, 25);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(77, 23);
			this.searchButton.TabIndex = 3;
			this.searchButton.Text = "Keresés";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// commentText
			// 
			this.commentText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.commentText.BackColor = System.Drawing.SystemColors.Window;
			this.commentText.Location = new System.Drawing.Point(359, 370);
			this.commentText.Multiline = true;
			this.commentText.Name = "commentText";
			this.commentText.ReadOnly = true;
			this.commentText.Size = new System.Drawing.Size(410, 80);
			this.commentText.TabIndex = 9;
			// 
			// subjectDrop
			// 
			this.subjectDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.subjectDrop.Enabled = false;
			this.subjectDrop.FormattingEnabled = true;
			this.subjectDrop.Location = new System.Drawing.Point(186, 27);
			this.subjectDrop.Name = "subjectDrop";
			this.subjectDrop.Size = new System.Drawing.Size(84, 21);
			this.subjectDrop.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(359, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Szakma";
			// 
			// subjectText
			// 
			this.subjectText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.subjectText.BackColor = System.Drawing.SystemColors.Window;
			this.subjectText.Location = new System.Drawing.Point(495, 127);
			this.subjectText.Name = "subjectText";
			this.subjectText.ReadOnly = true;
			this.subjectText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.subjectText.Size = new System.Drawing.Size(277, 20);
			this.subjectText.TabIndex = 7;
			// 
			// openDialog
			// 
			this.openDialog.Filter = "\"EJK dokumentum|*.ejk|XML dokumentum|*.xml|Minden fájl|*.*\"";
			this.openDialog.Multiselect = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 462);
			this.Controls.Add(this.subjectDrop);
			this.Controls.Add(this.commentText);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.operationGroup);
			this.Controls.Add(this.quantityGroup);
			this.Controls.Add(this.subjectText);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.idText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.titleText);
			this.Controls.Add(this.searchText);
			this.Controls.Add(this.mainList);
			this.Controls.Add(this.mainMenuStrip);
			this.Icon = global::EJKLeltar.Properties.Resources.MainIcon;
			this.KeyPreview = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.Text = "Leltár";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.mainListContextMenu.ResumeLayout(false);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.quantityGroup.ResumeLayout(false);
			this.quantityGroup.PerformLayout();
			this.operationGroup.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView mainList;
		private System.Windows.Forms.TextBox searchText;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader codeHeader;
		private System.Windows.Forms.ColumnHeader titleHeader;
		private System.Windows.Forms.TextBox titleText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox idText;
		private System.Windows.Forms.GroupBox quantityGroup;
		private System.Windows.Forms.GroupBox operationGroup;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.TextBox commentText;
		private System.Windows.Forms.TextBox totalText;
		private System.Windows.Forms.TextBox outText;
		private System.Windows.Forms.TextBox inText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button borrowButton;
		private System.Windows.Forms.Button returnButton;
		private System.Windows.Forms.ContextMenuStrip mainListContextMenu;
		private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.ComboBox subjectDrop;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox subjectText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem saveCopyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openDialog;
		private System.Windows.Forms.SaveFileDialog saveDialog;
	}
}

