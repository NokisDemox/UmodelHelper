using System;
using System.Windows.Forms;

namespace UmodelHelper
{
    public partial class EditGameForm : Form
    {
        Juego editJuego;
        public EditGameForm(Juego nuevo)
        {
            InitializeComponent();
            this.editJuego = nuevo;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //set variables of games
            if (txt_GameName.Text == "") txt_GameName.Text = System.DateTime.Now.ToString("MM/dd_HH:mm:ss");
            this.editJuego.Name = txt_GameName.Text;
            this.editJuego.ExePath = txt_GamePath.Text;
            this.editJuego.PakFolderPath = txt_pakFolder.Text;
            this.editJuego.UEVersion = txt_UEVersion.Text;
            this.editJuego.AESKey = txt_AESKeys.Text;
            this.editJuego.CustomArgs = txt_CustomArgs.Text;
            //close it
            this.Close();
        }
        //Explore exe file
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(openFileDialogEXE.ShowDialog() == DialogResult.OK)
            {
                //Open file
                txt_GamePath.Text = openFileDialogEXE.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        //Explore exe file
        private void btn_PakExplore_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialogPAK.ShowDialog() == DialogResult.OK)
            {
                //Open folder
                txt_pakFolder.Text = folderBrowserDialogPAK.SelectedPath;
            }
        }

        private void EditGameForm_Load(object sender, EventArgs e)
        {
            txt_GameName.Text = this.editJuego.Name;
            txt_GamePath.Text = this.editJuego.ExePath;
            txt_pakFolder.Text = this.editJuego.PakFolderPath;
            txt_UEVersion.Text = this.editJuego.UEVersion;
            txt_AESKeys.Text = this.editJuego.AESKey;
            txt_CustomArgs.Text = this.editJuego.CustomArgs;
        }
    }
}
