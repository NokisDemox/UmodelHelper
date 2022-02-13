namespace UmodelHelper
{
    partial class EditUmodelForm
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
            this.txt_UmodelPath = new System.Windows.Forms.TextBox();
            this.lbl_Umodelexe = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.openFileDialogEXE = new System.Windows.Forms.OpenFileDialog();
            this.btn_ExeExplore = new System.Windows.Forms.Button();
            this.lbl_UmodelVersion = new System.Windows.Forms.Label();
            this.txt_UmodelName = new System.Windows.Forms.TextBox();
            this.lbl_UmodelVersion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_UmodelPath
            // 
            this.txt_UmodelPath.Location = new System.Drawing.Point(140, 47);
            this.txt_UmodelPath.Name = "txt_UmodelPath";
            this.txt_UmodelPath.Size = new System.Drawing.Size(246, 20);
            this.txt_UmodelPath.TabIndex = 1;
            // 
            // lbl_Umodelexe
            // 
            this.lbl_Umodelexe.AutoSize = true;
            this.lbl_Umodelexe.Location = new System.Drawing.Point(21, 50);
            this.lbl_Umodelexe.Name = "lbl_Umodelexe";
            this.lbl_Umodelexe.Size = new System.Drawing.Size(87, 13);
            this.lbl_Umodelexe.TabIndex = 1;
            this.lbl_Umodelexe.Text = "Umodel.exe path";
            this.lbl_Umodelexe.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(298, 98);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(140, 98);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
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
            this.btn_ExeExplore.TabIndex = 6;
            this.btn_ExeExplore.Text = "Explore file";
            this.btn_ExeExplore.UseVisualStyleBackColor = true;
            this.btn_ExeExplore.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_UmodelVersion
            // 
            this.lbl_UmodelVersion.AutoSize = true;
            this.lbl_UmodelVersion.Location = new System.Drawing.Point(21, 15);
            this.lbl_UmodelVersion.Name = "lbl_UmodelVersion";
            this.lbl_UmodelVersion.Size = new System.Drawing.Size(90, 13);
            this.lbl_UmodelVersion.TabIndex = 8;
            this.lbl_UmodelVersion.Text = "Umodel Version : ";
            // 
            // txt_UmodelName
            // 
            this.txt_UmodelName.Location = new System.Drawing.Point(140, 12);
            this.txt_UmodelName.Name = "txt_UmodelName";
            this.txt_UmodelName.Size = new System.Drawing.Size(176, 20);
            this.txt_UmodelName.TabIndex = 0;
            // 
            // lbl_UmodelVersion2
            // 
            this.lbl_UmodelVersion2.AutoSize = true;
            this.lbl_UmodelVersion2.Location = new System.Drawing.Point(322, 15);
            this.lbl_UmodelVersion2.Name = "lbl_UmodelVersion2";
            this.lbl_UmodelVersion2.Size = new System.Drawing.Size(158, 13);
            this.lbl_UmodelVersion2.TabIndex = 9;
            this.lbl_UmodelVersion2.Text = "Version number or custom name";
            // 
            // EditUmodelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 139);
            this.Controls.Add(this.lbl_UmodelVersion2);
            this.Controls.Add(this.txt_UmodelName);
            this.Controls.Add(this.lbl_UmodelVersion);
            this.Controls.Add(this.btn_ExeExplore);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Umodelexe);
            this.Controls.Add(this.txt_UmodelPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditUmodelForm";
            this.Text = "Edit Umodel Version";
            this.Load += new System.EventHandler(this.EditUmodelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UmodelPath;
        private System.Windows.Forms.Label lbl_Umodelexe;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialogEXE;
        private System.Windows.Forms.Button btn_ExeExplore;
        private System.Windows.Forms.Label lbl_UmodelVersion;
        private System.Windows.Forms.TextBox txt_UmodelName;
        private System.Windows.Forms.Label lbl_UmodelVersion2;
    }
}