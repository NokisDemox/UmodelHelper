using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UmodelHelper
{
    public partial class Main : Form
    {
        //Program version
        public static string UMHVERSION = "1.0";

        //Game and umodel list that is saved in %appdata% games.conf and umodel.conf
        private List<Juego> listajuegos = new List<Juego>();
        private List<UModel> listaumodel = new List<UModel>();
        private static DirectoryInfo saveDir = Directory.GetParent(Application.UserAppDataPath);
        private string savePathGame = Path.Combine(saveDir.FullName, "games.conf");
        private string savePathUmodel = Path.Combine(saveDir.FullName, "umodel.conf");

        //Selected Game and umodel
        private Juego selectedGame;
        private UModel selectedUmodel;

        public Main()
        {
            InitializeComponent();
        }

        //Save in .conf (txt) the new game or umodel
        private void Write(Juego game)
        {
            StreamWriter sw = new StreamWriter(savePathGame, true);
            sw.WriteLine(game.SaveString());
            sw.Close();
        }
        private void Write(UModel umodel)
        {
            StreamWriter sw = new StreamWriter(savePathUmodel, true);
            sw.WriteLine(umodel.SaveString());
            sw.Close();
        }


        //Save in .conf (txt) the new game
        private void Overwrite(Juego game)
        {
            //Index of game (will be the line to replace)
            int index = listajuegos.FindIndex(x => x.Name.Contains(game.Name));
            //Read all lines, change the one with the index and write everything
            string[] lines = System.IO.File.ReadAllLines(savePathGame);
            lines[index] = game.SaveString();
            System.IO.File.WriteAllLines(savePathGame, lines);
        }
        private void Overwrite(UModel umodel)
        {
            //Index of game (will be the line to replace)
            int index = listaumodel.FindIndex(x => x.Name.Contains(umodel.Name));
            //Read all lines, change the one with the index and write everything
            string[] lines = System.IO.File.ReadAllLines(savePathUmodel);
            lines[index] = umodel.SaveString();
            System.IO.File.WriteAllLines(savePathUmodel, lines);
        }


        //Delete game from file
        private void Unwrite(Juego game)
        {
            //Index of game (will be the line to replace)
            int index = listajuegos.FindIndex(x => x.Name.Equals(game.Name));
            //Read all lines, create a new array without the deleted game
            string[] lines = System.IO.File.ReadAllLines(savePathGame);
            string[] final = lines.Where(w => w != lines[index]).ToArray();
            System.IO.File.WriteAllLines(savePathGame, final);
        }
        private void Unwrite(UModel umodel)
        {
            //Index of game (will be the line to replace)
            int index = listaumodel.FindIndex(x => x.Name.Equals(umodel.Name));
            //Read all lines, create a new array without the deleted game
            string[] lines = System.IO.File.ReadAllLines(savePathUmodel);
            string[] final = lines.Where(w => w != lines[index]).ToArray();
            System.IO.File.WriteAllLines(savePathUmodel, final);
        }

        //Read saved games or umodel
        private void Read()
        {
            listajuegos.Clear();
            StreamReader sr = new StreamReader(savePathGame);
            string line = sr.ReadLine();
            while (line != null)
            {
                //if line is empty, skip it or if line start with comment character #
                if (line == "" || line.StartsWith("#"))
                {
                    line = sr.ReadLine();
                    continue;
                }
                //Create an empty game and split the line in the attributes
                Juego game = new Juego();
                String[] lines = line.Split(';');
                //Set the game attributes
                game.Name = lines[0];
                game.ExePath = lines[1];
                game.PakFolderPath = lines[2];
                game.UEVersion = lines[3];
                game.AESKey = lines[4];
                game.CustomArgs = lines[5];
                //Add game to list and read next line
                listajuegos.Add(game);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        private void ReadUmodel()
        {
            listaumodel.Clear();
            StreamReader sr = new StreamReader(savePathUmodel);
            string line = sr.ReadLine();
            while (line != null)
            {
                //if line is empty, skip it or if line start with comment simbol
                if (line == "" || line.StartsWith("#"))
                {
                    line = sr.ReadLine();
                    continue;
                }
                //Create an empty game and split the line in the attributes
                UModel umodel = new UModel();
                String[] lines = line.Split(';');
                //Set the game attributes
                umodel.Name = lines[0];
                umodel.Path = lines[1];
                //Add game to list and read next line
                listaumodel.Add(umodel);
                line = sr.ReadLine();
            }
            sr.Close();
        }


        //Display saved games on the list on the right
        private void Display()
        {
            lst_Games.Items.Clear();
            foreach (Juego g in listajuegos)
            {
                lst_Games.Items.Add(g.ToString());
            }
        }
        private void DisplayUmodel()
        {
            desplegable_Umodel.Items.Clear();
            foreach (UModel u in listaumodel)
            {
                desplegable_Umodel.Items.Add(u.Name);
            }
        }


        //When the main form starts             **************
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetView();
            lbl_UMHelperVersion.Text = "Version: " + UMHVERSION + " by NokisDemox";
        }

        //Reset the main view
        private void ResetView()
        {
            //Disable elements for the games
            setMainContentVisibility(false);
            //Disable buttons
            btn_DeleteGame.Enabled = false;
            btn_DuplicateGame.Enabled = false;
            btn_RunUmodel.Enabled = false;
            btn_OpenUmodel.Enabled = false;

            btn_OpenEXEFolder.Visible = false;
            btn_OpenPAKFolder.Visible = false;
            btn_OpenUHelp.Visible = false;
            //Hide exe icon
            pic_GameIcon.Visible = false;

            //Add icons to the buttons
            

            //Create save file if it doesnt exist
            StreamWriter sw = File.AppendText(savePathGame);
            sw.Close();
            sw = File.AppendText(savePathUmodel);
            sw.Close();
            //Read the saved games and display them
            Read();
            Display();
            //Read the saved umodels and display them
            ReadUmodel();
            DisplayUmodel();
        }


        //Add a game
        private void button1_Click(object sender, EventArgs e)
        {
            //Get game info in other form
            Juego newGame = new Juego();
            var addGameForm = new AddGameForm(newGame);
            addGameForm.ShowDialog();
            addGameForm = null;
            //Add it to the list if was created
            if(newGame.ToString()!=null && newGame.ToString() != "")
            {
                //get game version
                getGameVersion(newGame);
                //add it to list
                lst_Games.Items.Add(newGame.ToString());
                //Save the game on txt file
                Write(newGame);
                //After save, add to the private array the game too
                listajuegos.Add(newGame);
            }
            
        }


        //List of games
        private void lst_Games_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox lstGames = sender as ListBox;
            //if its null we cant work with it
            if (lstGames == null || lstGames.SelectedItem == null) return;
      
            string selectedName = lstGames.SelectedItem.ToString();
            //Check which game is
            Juego selectedGame = listajuegos.Find(x => x.Name.Contains(selectedName));

            //Check if game has version, if not, add it
            if (selectedGame.Version == "-1") getGameVersion(selectedGame);

            // ****** Display game info
            changeMainContent(selectedGame);
            // ****** Enable buttons on the bottom
            btn_EditGame.Enabled = true;
            btn_DeleteGame.Enabled = true;
            btn_DuplicateGame.Enabled = true;
            if (selectedUmodel != null) btn_RunUmodel.Enabled = true;

            // ****** Enable buttons on the main view
            btn_OpenEXEFolder.Visible = true;
            btn_OpenPAKFolder.Visible = true;
            btn_OpenUHelp.Visible = true;
            // ****** Set the selected game for the other functions of the app
            this.selectedGame = selectedGame;
            //Set the icon as image in the main window
            Icon icon = SystemIcons.Warning;
            try
            {
                pic_GameIcon.Image = System.Drawing.Icon.ExtractAssociatedIcon(selectedGame.ExePath).ToBitmap();
            }
            catch (Exception ex)
            {
                pic_GameIcon.Image = icon.ToBitmap();
            }
            //Show exe icon
            pic_GameIcon.Visible = true;
        }


        // Main content visibility method
        private void setMainContentVisibility (bool b)
        {
            lbl_MainGameName.Visible = b;
            lbl_MainAESK1.Visible = b;
            lbl_MainEXE1.Visible = b;
            lbl_MainPAK1.Visible = b;
            lbl_MainUEV1.Visible = b;
            lbl_MainAESK2.Visible = b;
            lbl_MainEXE2.Visible = b;
            lbl_MainPAK2.Visible = b;
            lbl_MainUEV2.Visible = b;
            lbl_mainInfo.Visible = b;
            lbl_GameVersion.Visible = b;
            lbl_GameVersion2.Visible = b;
            lbl_KeyBase64.Visible = b;
            lbl_KeyBase64_2.Visible = b;
            lbl_CustomArgs.Visible = b;
            lbl_CustomArgs2.Visible = b;
        }


        //Change main window values
        private void changeMainContent(Juego game)
        {
            //enable them 
            setMainContentVisibility(true);
            //set values
            lbl_MainGameName.Text = game.Name;
            lbl_MainAESK2.Text = game.AESKey;
            lbl_MainEXE2.Text = game.ExePath;
            lbl_MainPAK2.Text = game.PakFolderPath;
            lbl_MainUEV2.Text = game.UEVersion;
            lbl_GameVersion2.Text = game.Version=="-1" ? "File not found" : game.Version;
            lbl_CustomArgs2.Text = game.CustomArgs;
            //Set base64 KEY
            string b64 = game.AESKey.StartsWith("0x") || game.AESKey.StartsWith("0X") ? game.AESKey.Remove(0,2) : game.AESKey;
            lbl_KeyBase64_2.Text = HexStringToB64String(b64);
        }

        private void btn_EditGame_Click(object sender, EventArgs e)
        {
            //Get game info in other form
            var editGameForm = new EditGameForm(selectedGame);
            editGameForm.ShowDialog();
            editGameForm = null;
            //Check if it contains error
            if (selectedGame.ToString() != null && selectedGame.ToString() != "")
            {
                //Overwrite
                Overwrite(selectedGame);
                changeMainContent(selectedGame);
                Display();
            }
            else MessageBox.Show("Invalid data for the game.", "Edit game error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Add new umodel verison (similar to game)
        private void btn_AddUmodel_Click(object sender, EventArgs e)
        {
            //Get umodel info in other form
            UModel newUmodel = new UModel();
            var addUmodelForm = new AddUmodelForm(newUmodel);
            addUmodelForm.ShowDialog();
            addUmodelForm = null;
            //Add it to the list if was created
            if (newUmodel.Name != null && newUmodel.Name != "")
            {
                desplegable_Umodel.Items.Add(newUmodel.Name);
                //Save the game on txt file
                Write(newUmodel);
                //After save, add to the private array the game too
                listaumodel.Add(newUmodel);
            }
        }

        private void desplegable_Umodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox lstUmodel = sender as ComboBox;
            //if its null we cant work with it
            if (lstUmodel == null) return;

            string selectedName = lstUmodel.SelectedItem.ToString();
            //Check which game is
            UModel selectedumodel = listaumodel.Find(x => x.Name.Contains(selectedName));

            // ****** Enable buttons on the top and bottom
            btn_UmodelEdit.Enabled = true;
            btn_DeleteUmodel.Enabled = true;
            if (selectedGame != null) btn_RunUmodel.Enabled = true;

            // ****** Set the selected game for the other functions of the app
            this.selectedUmodel = selectedumodel;
            //Set the icon as image in the umodel panel (info button)
            Icon icon = SystemIcons.Warning;
            try
            {
                Icon icon2 = System.Drawing.Icon.ExtractAssociatedIcon(selectedUmodel.Path);
                //If its possible then file exists
                pic_UModelInfo.Image = SystemIcons.Information.ToBitmap();
                pic_UModelInfo.Tag = "";
                btn_OpenUmodel.Enabled = true;
            }
            catch (Exception ex)
            {
                pic_UModelInfo.Image = icon.ToBitmap();
                pic_UModelInfo.Tag = "warning";
                btn_OpenUmodel.Enabled = false;
            }
            //Show exe icon
            pic_UModelInfo.Visible = true;
        }

        private void btn_UmodelEdit_Click(object sender, EventArgs e)
        {
            //Get game info in other form
            var editUModelForm = new EditUmodelForm(selectedUmodel);
            editUModelForm.ShowDialog();
            editUModelForm = null;
            //Check if it contains error
            if (selectedUmodel.Name != null && selectedUmodel.Name != "")
            {
                //Overwrite
                Overwrite(selectedUmodel);
                DisplayUmodel();
            }
            else MessageBox.Show("Invalid data for the game.", "Edit game error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_DeleteGame_Click(object sender, EventArgs e)
        {
            if (selectedGame.ToString() == null || selectedGame.ToString() == "") return;

            DialogResult result = MessageBox.Show("Are you sure you want to delete: " + selectedGame.Name + " ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Delete it from the file
                Unwrite(selectedGame);
                //Remove it from the list of games
                listajuegos.Remove(selectedGame);
                //Set the selected game to null and reset the form
                selectedGame = null;
                ResetView();
            }
            else return;
        }

        private void btn_DuplicateGame_Click(object sender, EventArgs e)
        {
            //Get game info in other form
            Juego newGame = new Juego(selectedGame);
            newGame.Name = selectedGame.Name + System.DateTime.Now.ToString("_mm_ss");
            //Add it to the list if was created
            if (newGame.ToString() != null && newGame.ToString() != "")
            {
                lst_Games.Items.Add(newGame.ToString());
                //Save the game on txt file
                Write(newGame);
                //After save, add to the private array the game too
                listajuegos.Add(newGame);
                Display();
            }
        }


        //Open a folder
        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.Arguments = folderPath;
                startInfo.FileName = "explorer.exe ";
                Process.Start(startInfo);
            }
            else MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));            
        }

        private void btn_OpenEXEFolder_Click(object sender, EventArgs e)
        {
            string folderPath = lbl_MainEXE2.Text.TrimEnd('\\').Remove(lbl_MainEXE2.Text.LastIndexOf('\\') + 1);
            OpenFolder(folderPath);
        }

        private void btn_OpenPAKFolder_Click(object sender, EventArgs e)
        {
            OpenFolder(lbl_MainPAK2.Text);
        }


        // OPEN UMODEL ********
        private void btn_OpenUmodel_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(lbl_MainPAK2.Text))
                MessageBox.Show(string.Format(" Game directory does not exist! \n {0}", lbl_MainPAK2.Text));
            
            //Umodel errors
            if (selectedUmodel == null) MessageBox.Show(string.Format("Umodel is not selected!"));
            if (selectedUmodel.Path == null) MessageBox.Show(string.Format("Umodel directory does not exist! \n {0}", lbl_MainPAK2.Text)); ;

            string umodelFolder = selectedUmodel.Path.TrimEnd('\\').Remove(selectedUmodel.Path.LastIndexOf('\\') + 1);

            if (!Directory.Exists(umodelFolder))
                MessageBox.Show(string.Format("Umodel directory does not exist! \n {0}", lbl_MainPAK2.Text));

            //umodel command
            ProcessStartInfo command = new ProcessStartInfo();
            //where umodel is (current version path)
            command.FileName = this.selectedUmodel.Path;
            //Add the aes, game version and path of game
            string args = " -aes=" + selectedGame.AESKey;
            args += " -game=ue" + selectedGame.UEVersion;
            args += " \"" + selectedGame.PakFolderPath + "\" ";
            args += selectedGame.CustomArgs;

            command.Arguments = args;

            //run it
            Process.Start(command);

        }

        //Add version of file
        private void getGameVersion(Juego game)
        {
            FileVersionInfo myFileVersionInfo = null;
            try
            {
                myFileVersionInfo = FileVersionInfo.GetVersionInfo(game.ExePath);
            }
            catch (Exception ex)
            {

            }
            if (myFileVersionInfo != null) game.Version = myFileVersionInfo.FileVersion == "" ? "Version not found" : myFileVersionInfo.FileVersion;
            //MessageBox.Show(myFileVersionInfo.ToString(), "Edit game error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void btn_DeleteUmodel_Click(object sender, EventArgs e)
        {
            if (selectedUmodel.ToString() == null || selectedUmodel.ToString() == "") return;

            DialogResult result = MessageBox.Show("Are you sure you want to delete: " + selectedUmodel.Name + " ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Delete it from the file
                Unwrite(selectedUmodel);
                //Remove it from the list of games
                listaumodel.Remove(selectedUmodel);
                //Set the selected game to null and reset the form
                selectedUmodel = null;
                ResetView();
            }
            else return;         
        }

        private void pic_UModelInfo_Click(object sender, EventArgs e)
        {
            if (pic_UModelInfo.Image == null) return;
            if ((string)pic_UModelInfo.Tag != "")
            {
                MessageBox.Show("The path of this umodel version is not an umodel.exe.", "Umodel path error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //umodel command
            Process command = new Process();
            //Redirect std out
            command.StartInfo.UseShellExecute = false;
            command.StartInfo.RedirectStandardOutput = true;
            //where umodel is (current version path) + version parameter
            command.StartInfo.FileName = this.selectedUmodel.Path;
            command.StartInfo.Arguments = " -version";
            //run it
            command.Start();
            //Get output
            string output = command.StandardOutput.ReadToEnd();
            command.WaitForExit();
            //Show version info
            MessageBox.Show(output, "Umodel version", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_OpenUmodel_Click_1(object sender, EventArgs e)
        {
            //Umodel errors
            if (selectedUmodel == null) MessageBox.Show(string.Format("Umodel is not selected!"));
            if (selectedUmodel.Path == null) MessageBox.Show(string.Format("Umodel directory does not exist! \n {0}", lbl_MainPAK2.Text)); ;

            string umodelFolder = selectedUmodel.Path.TrimEnd('\\').Remove(selectedUmodel.Path.LastIndexOf('\\') + 1);

            if (!Directory.Exists(umodelFolder))
                MessageBox.Show(string.Format("Umodel directory does not exist! \n {0}", lbl_MainPAK2.Text));

            //umodel command
            ProcessStartInfo command = new ProcessStartInfo();
            //where umodel is (current version path)
            command.FileName = this.selectedUmodel.Path;
            //Add the aes, game version and path of game
            command.Arguments = " -gui";
            //run it
            Process.Start(command);
        }

        private void link_UMHHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NokisDemox/UmodelHelper");
            
        }



        //method to convert string -> HEX -> base64
        public static string HexStringToB64String(string inputHex)
        {
            if (inputHex.Length != 64) return "AES key has to have 66 characters starting with \"0x\" or 64 characters ";
            var resultantArray = new byte[inputHex.Length / 2];
            for (var i = 0; i < resultantArray.Length; i++)
            {
               resultantArray[i] = System.Convert.ToByte(inputHex.Substring(i * 2, 2), 16);
            }
            return System.Convert.ToBase64String(resultantArray);
        }

        private void btn_OpenUHelp_Click(object sender, EventArgs e)
        {
            if (pic_UModelInfo.Image == null || (string)pic_UModelInfo.Tag != "") return;
           
            string command = "/K " + this.selectedUmodel.Path + " -help";
            Process.Start("CMD.exe", command);
        }
    }
    
}
