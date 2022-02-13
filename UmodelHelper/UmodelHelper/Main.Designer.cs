namespace UmodelHelper
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lst_Games = new System.Windows.Forms.ListBox();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.link_UMHHelp = new System.Windows.Forms.LinkLabel();
            this.lbl_UMHelperVersion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_AddGame = new System.Windows.Forms.Button();
            this.panelMainTop = new System.Windows.Forms.Panel();
            this.pic_UModelInfo = new System.Windows.Forms.PictureBox();
            this.btn_DeleteUmodel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_UmodelEdit = new System.Windows.Forms.Button();
            this.desplegable_Umodel = new System.Windows.Forms.ComboBox();
            this.btn_AddUmodel = new System.Windows.Forms.Button();
            this.lbl_UmodelChoose = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btn_OpenUHelp = new System.Windows.Forms.Button();
            this.lbl_CustomArgs2 = new System.Windows.Forms.TextBox();
            this.lbl_CustomArgs = new System.Windows.Forms.Label();
            this.lbl_KeyBase64_2 = new System.Windows.Forms.TextBox();
            this.lbl_KeyBase64 = new System.Windows.Forms.Label();
            this.lbl_MainAESK2 = new System.Windows.Forms.TextBox();
            this.lbl_MainUEV2 = new System.Windows.Forms.TextBox();
            this.lbl_MainPAK2 = new System.Windows.Forms.TextBox();
            this.lbl_GameVersion2 = new System.Windows.Forms.TextBox();
            this.lbl_MainEXE2 = new System.Windows.Forms.TextBox();
            this.lbl_GameVersion = new System.Windows.Forms.Label();
            this.btn_OpenEXEFolder = new System.Windows.Forms.Button();
            this.btn_OpenPAKFolder = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btn_OpenUmodel = new System.Windows.Forms.Button();
            this.btn_DuplicateGame = new System.Windows.Forms.Button();
            this.btn_DeleteGame = new System.Windows.Forms.Button();
            this.btn_EditGame = new System.Windows.Forms.Button();
            this.btn_RunUmodel = new System.Windows.Forms.Button();
            this.pic_GameIcon = new System.Windows.Forms.PictureBox();
            this.lbl_mainInfo = new System.Windows.Forms.Label();
            this.lbl_MainAESK1 = new System.Windows.Forms.Label();
            this.lbl_MainUEV1 = new System.Windows.Forms.Label();
            this.lbl_MainPAK1 = new System.Windows.Forms.Label();
            this.lbl_MainEXE1 = new System.Windows.Forms.Label();
            this.lbl_MainGameName = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UModelInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.lst_Games);
            this.panelLeft.Controls.Add(this.panelLeftTop);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 493);
            this.panelLeft.TabIndex = 2;
            // 
            // lst_Games
            // 
            this.lst_Games.BackColor = System.Drawing.Color.Silver;
            this.lst_Games.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Games.FormattingEnabled = true;
            this.lst_Games.Location = new System.Drawing.Point(0, 135);
            this.lst_Games.Name = "lst_Games";
            this.lst_Games.Size = new System.Drawing.Size(200, 358);
            this.lst_Games.TabIndex = 4;
            this.lst_Games.SelectedIndexChanged += new System.EventHandler(this.lst_Games_SelectedIndexChanged_1);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BackColor = System.Drawing.Color.Silver;
            this.panelLeftTop.Controls.Add(this.link_UMHHelp);
            this.panelLeftTop.Controls.Add(this.lbl_UMHelperVersion);
            this.panelLeftTop.Controls.Add(this.pictureBox2);
            this.panelLeftTop.Controls.Add(this.btn_AddGame);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(200, 135);
            this.panelLeftTop.TabIndex = 3;
            // 
            // link_UMHHelp
            // 
            this.link_UMHHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.link_UMHHelp.AutoSize = true;
            this.link_UMHHelp.Location = new System.Drawing.Point(39, 78);
            this.link_UMHHelp.Name = "link_UMHHelp";
            this.link_UMHHelp.Size = new System.Drawing.Size(110, 13);
            this.link_UMHHelp.TabIndex = 25;
            this.link_UMHHelp.TabStop = true;
            this.link_UMHHelp.Text = "Help with the program";
            this.link_UMHHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_UMHHelp_LinkClicked);
            // 
            // lbl_UMHelperVersion
            // 
            this.lbl_UMHelperVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_UMHelperVersion.AutoSize = true;
            this.lbl_UMHelperVersion.Location = new System.Drawing.Point(28, 65);
            this.lbl_UMHelperVersion.Name = "lbl_UMHelperVersion";
            this.lbl_UMHelperVersion.Size = new System.Drawing.Size(182, 13);
            this.lbl_UMHelperVersion.TabIndex = 24;
            this.lbl_UMHelperVersion.Text = "This program version by NokisDemox";
            this.lbl_UMHelperVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UmodelHelper.Properties.Resources.icontest1;
            this.pictureBox2.Location = new System.Drawing.Point(65, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btn_AddGame
            // 
            this.btn_AddGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_AddGame.Location = new System.Drawing.Point(0, 105);
            this.btn_AddGame.Name = "btn_AddGame";
            this.btn_AddGame.Size = new System.Drawing.Size(200, 30);
            this.btn_AddGame.TabIndex = 2;
            this.btn_AddGame.Text = "Add a new game";
            this.btn_AddGame.UseVisualStyleBackColor = true;
            this.btn_AddGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMainTop
            // 
            this.panelMainTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMainTop.Controls.Add(this.pic_UModelInfo);
            this.panelMainTop.Controls.Add(this.btn_DeleteUmodel);
            this.panelMainTop.Controls.Add(this.pictureBox1);
            this.panelMainTop.Controls.Add(this.btn_UmodelEdit);
            this.panelMainTop.Controls.Add(this.desplegable_Umodel);
            this.panelMainTop.Controls.Add(this.btn_AddUmodel);
            this.panelMainTop.Controls.Add(this.lbl_UmodelChoose);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.Location = new System.Drawing.Point(200, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(744, 65);
            this.panelMainTop.TabIndex = 3;
            // 
            // pic_UModelInfo
            // 
            this.pic_UModelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_UModelInfo.Location = new System.Drawing.Point(701, 20);
            this.pic_UModelInfo.Name = "pic_UModelInfo";
            this.pic_UModelInfo.Size = new System.Drawing.Size(25, 25);
            this.pic_UModelInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UModelInfo.TabIndex = 22;
            this.pic_UModelInfo.TabStop = false;
            this.pic_UModelInfo.Click += new System.EventHandler(this.pic_UModelInfo_Click);
            // 
            // btn_DeleteUmodel
            // 
            this.btn_DeleteUmodel.Enabled = false;
            this.btn_DeleteUmodel.Location = new System.Drawing.Point(336, 18);
            this.btn_DeleteUmodel.Name = "btn_DeleteUmodel";
            this.btn_DeleteUmodel.Size = new System.Drawing.Size(87, 30);
            this.btn_DeleteUmodel.TabIndex = 5;
            this.btn_DeleteUmodel.Text = "Delete Umodel";
            this.btn_DeleteUmodel.UseVisualStyleBackColor = true;
            this.btn_DeleteUmodel.Click += new System.EventHandler(this.btn_DeleteUmodel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UmodelHelper.Properties.Resources.umodel;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_UmodelEdit
            // 
            this.btn_UmodelEdit.Enabled = false;
            this.btn_UmodelEdit.Location = new System.Drawing.Point(210, 18);
            this.btn_UmodelEdit.Name = "btn_UmodelEdit";
            this.btn_UmodelEdit.Size = new System.Drawing.Size(120, 30);
            this.btn_UmodelEdit.TabIndex = 3;
            this.btn_UmodelEdit.Text = "Edit Umodel version";
            this.btn_UmodelEdit.UseVisualStyleBackColor = true;
            this.btn_UmodelEdit.Click += new System.EventHandler(this.btn_UmodelEdit_Click);
            // 
            // desplegable_Umodel
            // 
            this.desplegable_Umodel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.desplegable_Umodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desplegable_Umodel.FormattingEnabled = true;
            this.desplegable_Umodel.Location = new System.Drawing.Point(574, 24);
            this.desplegable_Umodel.Name = "desplegable_Umodel";
            this.desplegable_Umodel.Size = new System.Drawing.Size(121, 21);
            this.desplegable_Umodel.TabIndex = 2;
            this.desplegable_Umodel.SelectedIndexChanged += new System.EventHandler(this.desplegable_Umodel_SelectedIndexChanged);
            // 
            // btn_AddUmodel
            // 
            this.btn_AddUmodel.Location = new System.Drawing.Point(54, 18);
            this.btn_AddUmodel.Name = "btn_AddUmodel";
            this.btn_AddUmodel.Size = new System.Drawing.Size(150, 30);
            this.btn_AddUmodel.TabIndex = 1;
            this.btn_AddUmodel.Text = "Add new Umodel version";
            this.btn_AddUmodel.UseVisualStyleBackColor = true;
            this.btn_AddUmodel.Click += new System.EventHandler(this.btn_AddUmodel_Click);
            // 
            // lbl_UmodelChoose
            // 
            this.lbl_UmodelChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UmodelChoose.AutoSize = true;
            this.lbl_UmodelChoose.Location = new System.Drawing.Point(485, 27);
            this.lbl_UmodelChoose.Name = "lbl_UmodelChoose";
            this.lbl_UmodelChoose.Size = new System.Drawing.Size(83, 13);
            this.lbl_UmodelChoose.TabIndex = 0;
            this.lbl_UmodelChoose.Text = "Umodel version:";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.btn_OpenUHelp);
            this.panelMain.Controls.Add(this.lbl_CustomArgs2);
            this.panelMain.Controls.Add(this.lbl_CustomArgs);
            this.panelMain.Controls.Add(this.lbl_KeyBase64_2);
            this.panelMain.Controls.Add(this.lbl_KeyBase64);
            this.panelMain.Controls.Add(this.lbl_MainAESK2);
            this.panelMain.Controls.Add(this.lbl_MainUEV2);
            this.panelMain.Controls.Add(this.lbl_MainPAK2);
            this.panelMain.Controls.Add(this.lbl_GameVersion2);
            this.panelMain.Controls.Add(this.lbl_MainEXE2);
            this.panelMain.Controls.Add(this.lbl_GameVersion);
            this.panelMain.Controls.Add(this.btn_OpenEXEFolder);
            this.panelMain.Controls.Add(this.btn_OpenPAKFolder);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.pic_GameIcon);
            this.panelMain.Controls.Add(this.lbl_mainInfo);
            this.panelMain.Controls.Add(this.lbl_MainAESK1);
            this.panelMain.Controls.Add(this.lbl_MainUEV1);
            this.panelMain.Controls.Add(this.lbl_MainPAK1);
            this.panelMain.Controls.Add(this.lbl_MainEXE1);
            this.panelMain.Controls.Add(this.lbl_MainGameName);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(744, 428);
            this.panelMain.TabIndex = 4;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btn_OpenUHelp
            // 
            this.btn_OpenUHelp.Location = new System.Drawing.Point(15, 269);
            this.btn_OpenUHelp.Name = "btn_OpenUHelp";
            this.btn_OpenUHelp.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenUHelp.TabIndex = 26;
            this.btn_OpenUHelp.Text = "Show help";
            this.btn_OpenUHelp.UseVisualStyleBackColor = true;
            this.btn_OpenUHelp.Visible = false;
            this.btn_OpenUHelp.Click += new System.EventHandler(this.btn_OpenUHelp_Click);
            // 
            // lbl_CustomArgs2
            // 
            this.lbl_CustomArgs2.BackColor = System.Drawing.Color.White;
            this.lbl_CustomArgs2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_CustomArgs2.Location = new System.Drawing.Point(99, 299);
            this.lbl_CustomArgs2.Name = "lbl_CustomArgs2";
            this.lbl_CustomArgs2.ReadOnly = true;
            this.lbl_CustomArgs2.Size = new System.Drawing.Size(392, 13);
            this.lbl_CustomArgs2.TabIndex = 25;
            this.lbl_CustomArgs2.Text = "-png -aes=\"mypath\\file.txt\"";
            // 
            // lbl_CustomArgs
            // 
            this.lbl_CustomArgs.AutoSize = true;
            this.lbl_CustomArgs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CustomArgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomArgs.Location = new System.Drawing.Point(96, 274);
            this.lbl_CustomArgs.Name = "lbl_CustomArgs";
            this.lbl_CustomArgs.Size = new System.Drawing.Size(167, 13);
            this.lbl_CustomArgs.TabIndex = 24;
            this.lbl_CustomArgs.Text = "Custom arguments umodel * ";
            // 
            // lbl_KeyBase64_2
            // 
            this.lbl_KeyBase64_2.BackColor = System.Drawing.Color.White;
            this.lbl_KeyBase64_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_KeyBase64_2.Location = new System.Drawing.Point(259, 216);
            this.lbl_KeyBase64_2.Name = "lbl_KeyBase64_2";
            this.lbl_KeyBase64_2.ReadOnly = true;
            this.lbl_KeyBase64_2.Size = new System.Drawing.Size(600, 13);
            this.lbl_KeyBase64_2.TabIndex = 23;
            this.lbl_KeyBase64_2.Text = "XXXXXXXXXXXXXXXXXX";
            // 
            // lbl_KeyBase64
            // 
            this.lbl_KeyBase64.AutoSize = true;
            this.lbl_KeyBase64.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KeyBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeyBase64.Location = new System.Drawing.Point(95, 216);
            this.lbl_KeyBase64.Name = "lbl_KeyBase64";
            this.lbl_KeyBase64.Size = new System.Drawing.Size(114, 13);
            this.lbl_KeyBase64.TabIndex = 22;
            this.lbl_KeyBase64.Text = "AES Key (Base 64)";
            // 
            // lbl_MainAESK2
            // 
            this.lbl_MainAESK2.BackColor = System.Drawing.Color.White;
            this.lbl_MainAESK2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_MainAESK2.Location = new System.Drawing.Point(259, 181);
            this.lbl_MainAESK2.Name = "lbl_MainAESK2";
            this.lbl_MainAESK2.ReadOnly = true;
            this.lbl_MainAESK2.Size = new System.Drawing.Size(600, 13);
            this.lbl_MainAESK2.TabIndex = 21;
            this.lbl_MainAESK2.Text = "0xXXXXXXXXXXXXXXXXXX";
            // 
            // lbl_MainUEV2
            // 
            this.lbl_MainUEV2.BackColor = System.Drawing.Color.White;
            this.lbl_MainUEV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_MainUEV2.Location = new System.Drawing.Point(261, 144);
            this.lbl_MainUEV2.Name = "lbl_MainUEV2";
            this.lbl_MainUEV2.ReadOnly = true;
            this.lbl_MainUEV2.Size = new System.Drawing.Size(400, 13);
            this.lbl_MainUEV2.TabIndex = 20;
            this.lbl_MainUEV2.Text = "4.XX";
            // 
            // lbl_MainPAK2
            // 
            this.lbl_MainPAK2.BackColor = System.Drawing.Color.White;
            this.lbl_MainPAK2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_MainPAK2.Location = new System.Drawing.Point(261, 109);
            this.lbl_MainPAK2.Name = "lbl_MainPAK2";
            this.lbl_MainPAK2.ReadOnly = true;
            this.lbl_MainPAK2.Size = new System.Drawing.Size(600, 13);
            this.lbl_MainPAK2.TabIndex = 19;
            this.lbl_MainPAK2.Text = "path\\paks";
            // 
            // lbl_GameVersion2
            // 
            this.lbl_GameVersion2.BackColor = System.Drawing.Color.White;
            this.lbl_GameVersion2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_GameVersion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameVersion2.Location = new System.Drawing.Point(261, 83);
            this.lbl_GameVersion2.Name = "lbl_GameVersion2";
            this.lbl_GameVersion2.ReadOnly = true;
            this.lbl_GameVersion2.Size = new System.Drawing.Size(400, 13);
            this.lbl_GameVersion2.TabIndex = 18;
            this.lbl_GameVersion2.Text = "2.2";
            // 
            // lbl_MainEXE2
            // 
            this.lbl_MainEXE2.BackColor = System.Drawing.Color.White;
            this.lbl_MainEXE2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_MainEXE2.Location = new System.Drawing.Point(259, 57);
            this.lbl_MainEXE2.Name = "lbl_MainEXE2";
            this.lbl_MainEXE2.ReadOnly = true;
            this.lbl_MainEXE2.Size = new System.Drawing.Size(600, 13);
            this.lbl_MainEXE2.TabIndex = 17;
            this.lbl_MainEXE2.Text = "path\\game.exe";
            // 
            // lbl_GameVersion
            // 
            this.lbl_GameVersion.AutoSize = true;
            this.lbl_GameVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GameVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameVersion.Location = new System.Drawing.Point(96, 83);
            this.lbl_GameVersion.Name = "lbl_GameVersion";
            this.lbl_GameVersion.Size = new System.Drawing.Size(97, 13);
            this.lbl_GameVersion.TabIndex = 15;
            this.lbl_GameVersion.Text = "Executable version";
            // 
            // btn_OpenEXEFolder
            // 
            this.btn_OpenEXEFolder.Location = new System.Drawing.Point(15, 53);
            this.btn_OpenEXEFolder.Name = "btn_OpenEXEFolder";
            this.btn_OpenEXEFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenEXEFolder.TabIndex = 14;
            this.btn_OpenEXEFolder.Text = "Open folder";
            this.btn_OpenEXEFolder.UseVisualStyleBackColor = true;
            this.btn_OpenEXEFolder.Visible = false;
            this.btn_OpenEXEFolder.Click += new System.EventHandler(this.btn_OpenEXEFolder_Click);
            // 
            // btn_OpenPAKFolder
            // 
            this.btn_OpenPAKFolder.Location = new System.Drawing.Point(14, 104);
            this.btn_OpenPAKFolder.Name = "btn_OpenPAKFolder";
            this.btn_OpenPAKFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenPAKFolder.TabIndex = 13;
            this.btn_OpenPAKFolder.Text = "Open folder";
            this.btn_OpenPAKFolder.UseVisualStyleBackColor = true;
            this.btn_OpenPAKFolder.Visible = false;
            this.btn_OpenPAKFolder.Click += new System.EventHandler(this.btn_OpenPAKFolder_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btn_OpenUmodel);
            this.panelBottom.Controls.Add(this.btn_DuplicateGame);
            this.panelBottom.Controls.Add(this.btn_DeleteGame);
            this.panelBottom.Controls.Add(this.btn_EditGame);
            this.panelBottom.Controls.Add(this.btn_RunUmodel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 373);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(744, 55);
            this.panelBottom.TabIndex = 0;
            // 
            // btn_OpenUmodel
            // 
            this.btn_OpenUmodel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OpenUmodel.BackColor = System.Drawing.Color.Transparent;
            this.btn_OpenUmodel.Enabled = false;
            this.btn_OpenUmodel.Location = new System.Drawing.Point(502, 13);
            this.btn_OpenUmodel.Name = "btn_OpenUmodel";
            this.btn_OpenUmodel.Size = new System.Drawing.Size(86, 30);
            this.btn_OpenUmodel.TabIndex = 4;
            this.btn_OpenUmodel.Text = "Open Umodel";
            this.btn_OpenUmodel.UseVisualStyleBackColor = false;
            this.btn_OpenUmodel.Click += new System.EventHandler(this.btn_OpenUmodel_Click_1);
            // 
            // btn_DuplicateGame
            // 
            this.btn_DuplicateGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DuplicateGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_DuplicateGame.Enabled = false;
            this.btn_DuplicateGame.Location = new System.Drawing.Point(130, 13);
            this.btn_DuplicateGame.Name = "btn_DuplicateGame";
            this.btn_DuplicateGame.Size = new System.Drawing.Size(110, 30);
            this.btn_DuplicateGame.TabIndex = 3;
            this.btn_DuplicateGame.Text = "Duplicate game";
            this.btn_DuplicateGame.UseVisualStyleBackColor = false;
            this.btn_DuplicateGame.Click += new System.EventHandler(this.btn_DuplicateGame_Click);
            // 
            // btn_DeleteGame
            // 
            this.btn_DeleteGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteGame.Enabled = false;
            this.btn_DeleteGame.Location = new System.Drawing.Point(14, 13);
            this.btn_DeleteGame.Name = "btn_DeleteGame";
            this.btn_DeleteGame.Size = new System.Drawing.Size(110, 30);
            this.btn_DeleteGame.TabIndex = 2;
            this.btn_DeleteGame.Text = "Delete game data";
            this.btn_DeleteGame.UseVisualStyleBackColor = false;
            this.btn_DeleteGame.Click += new System.EventHandler(this.btn_DeleteGame_Click);
            // 
            // btn_EditGame
            // 
            this.btn_EditGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditGame.Enabled = false;
            this.btn_EditGame.Location = new System.Drawing.Point(246, 13);
            this.btn_EditGame.Name = "btn_EditGame";
            this.btn_EditGame.Size = new System.Drawing.Size(110, 30);
            this.btn_EditGame.TabIndex = 1;
            this.btn_EditGame.Text = "Edit game data";
            this.btn_EditGame.UseVisualStyleBackColor = false;
            this.btn_EditGame.Click += new System.EventHandler(this.btn_EditGame_Click);
            // 
            // btn_RunUmodel
            // 
            this.btn_RunUmodel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RunUmodel.BackColor = System.Drawing.Color.Transparent;
            this.btn_RunUmodel.Enabled = false;
            this.btn_RunUmodel.Location = new System.Drawing.Point(594, 13);
            this.btn_RunUmodel.Name = "btn_RunUmodel";
            this.btn_RunUmodel.Size = new System.Drawing.Size(133, 30);
            this.btn_RunUmodel.TabIndex = 0;
            this.btn_RunUmodel.Text = "Run Umodel with game";
            this.btn_RunUmodel.UseVisualStyleBackColor = false;
            this.btn_RunUmodel.Click += new System.EventHandler(this.btn_OpenUmodel_Click);
            // 
            // pic_GameIcon
            // 
            this.pic_GameIcon.Location = new System.Drawing.Point(54, 12);
            this.pic_GameIcon.Name = "pic_GameIcon";
            this.pic_GameIcon.Size = new System.Drawing.Size(35, 35);
            this.pic_GameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_GameIcon.TabIndex = 12;
            this.pic_GameIcon.TabStop = false;
            // 
            // lbl_mainInfo
            // 
            this.lbl_mainInfo.AutoSize = true;
            this.lbl_mainInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mainInfo.Location = new System.Drawing.Point(96, 243);
            this.lbl_mainInfo.Name = "lbl_mainInfo";
            this.lbl_mainInfo.Size = new System.Drawing.Size(308, 13);
            this.lbl_mainInfo.TabIndex = 11;
            this.lbl_mainInfo.Text = "(*) Marked variables will be used for umodel, write them correctly";
            // 
            // lbl_MainAESK1
            // 
            this.lbl_MainAESK1.AutoSize = true;
            this.lbl_MainAESK1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainAESK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainAESK1.Location = new System.Drawing.Point(95, 181);
            this.lbl_MainAESK1.Name = "lbl_MainAESK1";
            this.lbl_MainAESK1.Size = new System.Drawing.Size(99, 13);
            this.lbl_MainAESK1.TabIndex = 9;
            this.lbl_MainAESK1.Text = "AES Key (Hex) *";
            // 
            // lbl_MainUEV1
            // 
            this.lbl_MainUEV1.AutoSize = true;
            this.lbl_MainUEV1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainUEV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainUEV1.Location = new System.Drawing.Point(95, 144);
            this.lbl_MainUEV1.Name = "lbl_MainUEV1";
            this.lbl_MainUEV1.Size = new System.Drawing.Size(142, 13);
            this.lbl_MainUEV1.TabIndex = 7;
            this.lbl_MainUEV1.Text = "Unreal Engine Version *";
            // 
            // lbl_MainPAK1
            // 
            this.lbl_MainPAK1.AutoSize = true;
            this.lbl_MainPAK1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainPAK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainPAK1.Location = new System.Drawing.Point(95, 109);
            this.lbl_MainPAK1.Name = "lbl_MainPAK1";
            this.lbl_MainPAK1.Size = new System.Drawing.Size(134, 13);
            this.lbl_MainPAK1.TabIndex = 5;
            this.lbl_MainPAK1.Text = "Folder with .pak files *";
            // 
            // lbl_MainEXE1
            // 
            this.lbl_MainEXE1.AutoSize = true;
            this.lbl_MainEXE1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainEXE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainEXE1.Location = new System.Drawing.Point(96, 57);
            this.lbl_MainEXE1.Name = "lbl_MainEXE1";
            this.lbl_MainEXE1.Size = new System.Drawing.Size(96, 13);
            this.lbl_MainEXE1.TabIndex = 3;
            this.lbl_MainEXE1.Text = "Game .exe path";
            this.lbl_MainEXE1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_MainGameName
            // 
            this.lbl_MainGameName.AutoSize = true;
            this.lbl_MainGameName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_MainGameName.Location = new System.Drawing.Point(114, 12);
            this.lbl_MainGameName.Name = "lbl_MainGameName";
            this.lbl_MainGameName.Size = new System.Drawing.Size(146, 31);
            this.lbl_MainGameName.TabIndex = 2;
            this.lbl_MainGameName.Text = "Game Title";
            this.lbl_MainGameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 493);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMainTop);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "UmodelHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMainTop.ResumeLayout(false);
            this.panelMainTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UModelInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_GameIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btn_AddGame;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Panel panelMainTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListBox lst_Games;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btn_RunUmodel;
        private System.Windows.Forms.Button btn_EditGame;
        private System.Windows.Forms.Label lbl_MainGameName;
        private System.Windows.Forms.Label lbl_MainEXE1;
        private System.Windows.Forms.Label lbl_MainPAK1;
        private System.Windows.Forms.Label lbl_MainAESK1;
        private System.Windows.Forms.Label lbl_MainUEV1;
        private System.Windows.Forms.ComboBox desplegable_Umodel;
        private System.Windows.Forms.Button btn_AddUmodel;
        private System.Windows.Forms.Label lbl_UmodelChoose;
        private System.Windows.Forms.Button btn_UmodelEdit;
        private System.Windows.Forms.Button btn_DuplicateGame;
        private System.Windows.Forms.Button btn_DeleteGame;
        private System.Windows.Forms.Label lbl_mainInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_GameIcon;
        private System.Windows.Forms.Button btn_OpenEXEFolder;
        private System.Windows.Forms.Button btn_OpenPAKFolder;
        private System.Windows.Forms.Label lbl_GameVersion;
        private System.Windows.Forms.Button btn_DeleteUmodel;
        private System.Windows.Forms.TextBox lbl_MainEXE2;
        private System.Windows.Forms.TextBox lbl_GameVersion2;
        private System.Windows.Forms.TextBox lbl_MainAESK2;
        private System.Windows.Forms.TextBox lbl_MainUEV2;
        private System.Windows.Forms.TextBox lbl_MainPAK2;
        private System.Windows.Forms.PictureBox pic_UModelInfo;
        private System.Windows.Forms.Button btn_OpenUmodel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel link_UMHHelp;
        private System.Windows.Forms.Label lbl_UMHelperVersion;
        private System.Windows.Forms.Label lbl_KeyBase64;
        private System.Windows.Forms.TextBox lbl_KeyBase64_2;
        private System.Windows.Forms.TextBox lbl_CustomArgs2;
        private System.Windows.Forms.Label lbl_CustomArgs;
        private System.Windows.Forms.Button btn_OpenUHelp;
    }
}

