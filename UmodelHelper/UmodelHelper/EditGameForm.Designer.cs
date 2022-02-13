namespace UmodelHelper
{
    partial class EditGameForm
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
            this.txt_GamePath = new System.Windows.Forms.TextBox();
            this.lbl_exePath = new System.Windows.Forms.Label();
            this.lbl_pakFolder = new System.Windows.Forms.Label();
            this.txt_pakFolder = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.openFileDialogEXE = new System.Windows.Forms.OpenFileDialog();
            this.btn_ExeExplore = new System.Windows.Forms.Button();
            this.btn_PakExplore = new System.Windows.Forms.Button();
            this.folderBrowserDialogPAK = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_GameName = new System.Windows.Forms.Label();
            this.txt_GameName = new System.Windows.Forms.TextBox();
            this.lbl_UEV = new System.Windows.Forms.Label();
            this.txt_UEVersion = new System.Windows.Forms.TextBox();
            this.lbl_UEVHelp = new System.Windows.Forms.Label();
            this.lbl_AESK = new System.Windows.Forms.Label();
            this.txt_AESKeys = new System.Windows.Forms.TextBox();
            this.lbl_CustomArgs = new System.Windows.Forms.Label();
            this.txt_CustomArgs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_GamePath
            // 
            this.txt_GamePath.Location = new System.Drawing.Point(140, 47);
            this.txt_GamePath.Name = "txt_GamePath";
            this.txt_GamePath.Size = new System.Drawing.Size(246, 20);
            this.txt_GamePath.TabIndex = 1;
            // 
            // lbl_exePath
            // 
            this.lbl_exePath.AutoSize = true;
            this.lbl_exePath.Location = new System.Drawing.Point(21, 50);
            this.lbl_exePath.Name = "lbl_exePath";
            this.lbl_exePath.Size = new System.Drawing.Size(82, 13);
            this.lbl_exePath.TabIndex = 1;
            this.lbl_exePath.Text = "Game .exe path";
            this.lbl_exePath.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_pakFolder
            // 
            this.lbl_pakFolder.AutoSize = true;
            this.lbl_pakFolder.Location = new System.Drawing.Point(21, 85);
            this.lbl_pakFolder.Name = "lbl_pakFolder";
            this.lbl_pakFolder.Size = new System.Drawing.Size(103, 13);
            this.lbl_pakFolder.TabIndex = 2;
            this.lbl_pakFolder.Text = "Folder with .pak files";
            this.lbl_pakFolder.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_pakFolder
            // 
            this.txt_pakFolder.Location = new System.Drawing.Point(140, 82);
            this.txt_pakFolder.Name = "txt_pakFolder";
            this.txt_pakFolder.Size = new System.Drawing.Size(246, 20);
            this.txt_pakFolder.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(301, 226);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(143, 226);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogEXE
            // 
            this.openFileDialogEXE.FileName = "openFileDialog1";
            this.openFileDialogEXE.Filter = "Executable files (*.exe) | *.exe";
            this.openFileDialogEXE.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_ExeExplore
            // 
            this.btn_ExeExplore.Location = new System.Drawing.Point(392, 47);
            this.btn_ExeExplore.Name = "btn_ExeExplore";
            this.btn_ExeExplore.Size = new System.Drawing.Size(88, 23);
            this.btn_ExeExplore.TabIndex = 2;
            this.btn_ExeExplore.Text = "Explore file";
            this.btn_ExeExplore.UseVisualStyleBackColor = true;
            this.btn_ExeExplore.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_PakExplore
            // 
            this.btn_PakExplore.Location = new System.Drawing.Point(392, 80);
            this.btn_PakExplore.Name = "btn_PakExplore";
            this.btn_PakExplore.Size = new System.Drawing.Size(88, 23);
            this.btn_PakExplore.TabIndex = 4;
            this.btn_PakExplore.Text = "Explore folder";
            this.btn_PakExplore.UseVisualStyleBackColor = true;
            this.btn_PakExplore.Click += new System.EventHandler(this.btn_PakExplore_Click);
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.AutoSize = true;
            this.lbl_GameName.Location = new System.Drawing.Point(21, 19);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(70, 13);
            this.lbl_GameName.TabIndex = 8;
            this.lbl_GameName.Text = "Game name: ";
            // 
            // txt_GameName
            // 
            this.txt_GameName.Location = new System.Drawing.Point(140, 12);
            this.txt_GameName.Name = "txt_GameName";
            this.txt_GameName.Size = new System.Drawing.Size(246, 20);
            this.txt_GameName.TabIndex = 0;
            // 
            // lbl_UEV
            // 
            this.lbl_UEV.AutoSize = true;
            this.lbl_UEV.Location = new System.Drawing.Point(21, 121);
            this.lbl_UEV.Name = "lbl_UEV";
            this.lbl_UEV.Size = new System.Drawing.Size(112, 13);
            this.lbl_UEV.TabIndex = 10;
            this.lbl_UEV.Text = "Unreal Engine Version";
            // 
            // txt_UEVersion
            // 
            this.txt_UEVersion.Location = new System.Drawing.Point(140, 118);
            this.txt_UEVersion.Name = "txt_UEVersion";
            this.txt_UEVersion.Size = new System.Drawing.Size(75, 20);
            this.txt_UEVersion.TabIndex = 5;
            // 
            // lbl_UEVHelp
            // 
            this.lbl_UEVHelp.AutoSize = true;
            this.lbl_UEVHelp.Location = new System.Drawing.Point(242, 121);
            this.lbl_UEVHelp.Name = "lbl_UEVHelp";
            this.lbl_UEVHelp.Size = new System.Drawing.Size(88, 13);
            this.lbl_UEVHelp.TabIndex = 12;
            this.lbl_UEVHelp.Text = "For example 4.22";
            // 
            // lbl_AESK
            // 
            this.lbl_AESK.AutoSize = true;
            this.lbl_AESK.Location = new System.Drawing.Point(21, 159);
            this.lbl_AESK.Name = "lbl_AESK";
            this.lbl_AESK.Size = new System.Drawing.Size(63, 13);
            this.lbl_AESK.TabIndex = 13;
            this.lbl_AESK.Text = "AES Key (s)";
            // 
            // txt_AESKeys
            // 
            this.txt_AESKeys.Location = new System.Drawing.Point(140, 156);
            this.txt_AESKeys.Name = "txt_AESKeys";
            this.txt_AESKeys.Size = new System.Drawing.Size(246, 20);
            this.txt_AESKeys.TabIndex = 6;
            // 
            // lbl_CustomArgs
            // 
            this.lbl_CustomArgs.AutoSize = true;
            this.lbl_CustomArgs.Location = new System.Drawing.Point(21, 191);
            this.lbl_CustomArgs.Name = "lbl_CustomArgs";
            this.lbl_CustomArgs.Size = new System.Drawing.Size(94, 26);
            this.lbl_CustomArgs.TabIndex = 14;
            this.lbl_CustomArgs.Text = "Custom arguments\r\nfor umodel";
            // 
            // txt_CustomArgs
            // 
            this.txt_CustomArgs.Location = new System.Drawing.Point(140, 191);
            this.txt_CustomArgs.Name = "txt_CustomArgs";
            this.txt_CustomArgs.Size = new System.Drawing.Size(246, 20);
            this.txt_CustomArgs.TabIndex = 15;
            // 
            // EditGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.txt_CustomArgs);
            this.Controls.Add(this.lbl_CustomArgs);
            this.Controls.Add(this.txt_AESKeys);
            this.Controls.Add(this.lbl_AESK);
            this.Controls.Add(this.lbl_UEVHelp);
            this.Controls.Add(this.txt_UEVersion);
            this.Controls.Add(this.lbl_UEV);
            this.Controls.Add(this.txt_GameName);
            this.Controls.Add(this.lbl_GameName);
            this.Controls.Add(this.btn_PakExplore);
            this.Controls.Add(this.btn_ExeExplore);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_pakFolder);
            this.Controls.Add(this.lbl_pakFolder);
            this.Controls.Add(this.lbl_exePath);
            this.Controls.Add(this.txt_GamePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditGameForm";
            this.Text = "Edit game data";
            this.Load += new System.EventHandler(this.EditGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_GamePath;
        private System.Windows.Forms.Label lbl_exePath;
        private System.Windows.Forms.Label lbl_pakFolder;
        private System.Windows.Forms.TextBox txt_pakFolder;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialogEXE;
        private System.Windows.Forms.Button btn_ExeExplore;
        private System.Windows.Forms.Button btn_PakExplore;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPAK;
        private System.Windows.Forms.Label lbl_GameName;
        private System.Windows.Forms.TextBox txt_GameName;
        private System.Windows.Forms.Label lbl_UEV;
        private System.Windows.Forms.TextBox txt_UEVersion;
        private System.Windows.Forms.Label lbl_UEVHelp;
        private System.Windows.Forms.Label lbl_AESK;
        private System.Windows.Forms.TextBox txt_AESKeys;
        private System.Windows.Forms.Label lbl_CustomArgs;
        private System.Windows.Forms.TextBox txt_CustomArgs;
    }
}