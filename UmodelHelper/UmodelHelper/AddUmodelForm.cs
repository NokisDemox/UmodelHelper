using System;
using System.Windows.Forms;

namespace UmodelHelper
{
    public partial class AddUmodelForm : Form
    {
        UModel newUmodel;
        public AddUmodelForm(UModel edit)
        {
            InitializeComponent();
            this.newUmodel = edit;
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
            if (txt_UmodelName.Text == "") txt_UmodelName.Text = "UM" + System.DateTime.Now.ToString("_mm_ss");
            this.newUmodel.Name = txt_UmodelName.Text;
            this.newUmodel.Path = txt_UmodelPath.Text;
            //close it
            this.Close();
        }
        //Explore exe file
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(openFileDialogEXE.ShowDialog() == DialogResult.OK)
            {
                //Open file
                txt_UmodelPath.Text = openFileDialogEXE.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void link_UmodelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gildor2/UEViewer");
        }
    }
}
