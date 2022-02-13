using System;
using System.Windows.Forms;

namespace UmodelHelper
{
    public partial class AddGameForm : Form
    {
        Juego nuevoJuego;
        private bool hexKey = true;
        public AddGameForm(Juego nuevo)
        {
            InitializeComponent();
            this.nuevoJuego = nuevo;
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
            if (txt_GameName.Text == "") txt_GameName.Text = "Game_" + System.DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");
            this.nuevoJuego.Name = txt_GameName.Text;
            this.nuevoJuego.ExePath = txt_GamePath.Text;
            this.nuevoJuego.PakFolderPath = txt_pakFolder.Text;
            this.nuevoJuego.UEVersion = txt_UEVersion.Text;
            this.nuevoJuego.CustomArgs = txt_CustomArgs.Text;
            //Set KEY
            if (hexKey) this.nuevoJuego.AESKey = txt_AESKeys.Text;
            else
            {
                string key = "";
                try
                {
                    byte[] bytes = Convert.FromBase64String(txt_AESKeys.Text);
                    key = BitConverter.ToString(bytes);
                    key = key.Replace("-", string.Empty);
                }
                catch (Exception ex)
                {
                    key = "Error converting the key from Base 64 to HEX";
                }
                this.nuevoJuego.AESKey = "0x" + key;
            }
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

        private void rbtn_HEX_CheckedChanged(object sender, EventArgs e)
        {
            hexKey = true;
        }

        private void rbtn_B64_CheckedChanged(object sender, EventArgs e)
        {
            hexKey = false;
        }
    }
}
