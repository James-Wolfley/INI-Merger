using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INIEditor
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            populateTextBoxes();
        }

        private void masterFileBrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "INI Files (*.ini)|*.ini";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    masterFileTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void browseCopyToFolderBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowsingDialog = new FolderBrowserDialog())
            {
                if (folderBrowsingDialog.ShowDialog() == DialogResult.OK)
                {
                    copyToFolderTextBox.Text = folderBrowsingDialog.SelectedPath;
                }
            }
        }

        private void findFilesToEditBtn_Click(object sender, EventArgs e)
        {
            if (copyToFolderTextBox.Text != "" && filenameToCopyTextBox.Text != "")
            {
                string[] files = Directory.GetFiles(copyToFolderTextBox.Text, filenameToCopyTextBox.Text, SearchOption.AllDirectories);
                filesToEditListBox.Items.Clear();
                foreach (string file in files)
                {
                    filesToEditListBox.Items.Add(file);
                }
                statusLabel.Text = "Status : Ready";
            }
            else if (copyToFolderTextBox.Text == "")
            {
                statusLabel.Text = "Status : Error no folder to look in.";
            }
            else if (filenameToCopyTextBox.Text == "")
            {
                statusLabel.Text = "Status : Error no filename to look for.";
            }
        }

        private void applyEditsBtn_Click(object sender, EventArgs e)
        {
            if (masterFileTextBox.Text == "")
            {
                statusLabel.Text = "Status : No master file selected";
                return;
            }
            else if (statusLabel.Text != "Status : Ready")
            {
                statusLabel.Text = "Status : Files have not been found yet";
                return;
            }
            var parser = new IniParser.Parser.IniDataParser();
            parser.Configuration.AllowDuplicateKeys = true;
            var fileParser = new FileIniDataParser();
            IniData user_config = parser.Parse(File.ReadAllText(masterFileTextBox.Text));
            foreach (string file in filesToEditListBox.Items)
            {
                IniData config = parser.Parse(File.ReadAllText(file));
                config.Merge(user_config);
                fileParser.WriteFile(file, config);
                statusLabel.Text = "Status : Working";
            }
            statusLabel.Text = "Status : Finished";
        }


        private string getSettingFilePath()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string strSettingsINIFilePath = System.IO.Path.Combine(strWorkPath, "Settings.ini");
            return strSettingsINIFilePath;
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            string filePath = getSettingFilePath();
            var fileParser = new FileIniDataParser();
            IniData data = fileParser.ReadFile(filePath);
            data["GeneralConfiguration"]["masterFile"] = masterFileTextBox.Text;
            data["GeneralConfiguration"]["copyToFolder"] = copyToFolderTextBox.Text;
            data["GeneralConfiguration"]["filenameToCopy"] = filenameToCopyTextBox.Text;
            fileParser.WriteFile(filePath, data);
            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);
            statusLabel.Text = "Status : Files Saved";
        }

        private void populateTextBoxes()
        {
            string filePath = getSettingFilePath();
            var fileParser = new FileIniDataParser();
            if (!File.Exists(filePath))
            {
                string createText = "GeneralConfiguration" + Environment.NewLine + "masterFile = " + Environment.NewLine + "copyToFolder = " + Environment.NewLine + "filenameToCopy = ";
                File.WriteAllText(filePath, createText);
                string readText = File.ReadAllText(filePath);
                Console.WriteLine(readText);
            }
            IniData data = fileParser.ReadFile(filePath);

            masterFileTextBox.Text = data["GeneralConfiguration"]["masterFile"];
            copyToFolderTextBox.Text = data["GeneralConfiguration"]["copyToFolder"];
            filenameToCopyTextBox.Text = data["GeneralConfiguration"]["filenameToCopy"];
            editorMasterPathTextBox.Text = data["GeneralConfiguration"]["masterFile"];

            polulateEditorText();
        }

        private void editorLoadMasterBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "INI Files (*.ini)|*.ini";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    editorMasterPathTextBox.Text = openFileDialog.FileName;
                }
            }

            polulateEditorText();
        }

        private void polulateEditorText()
        {
            StringBuilder builder = new StringBuilder();

            foreach (string line in File.ReadAllLines(editorMasterPathTextBox.Text))
            {
                builder.AppendLine(line);
            }

            editorTextBox.Text = builder.ToString();
        }

        private void editorSaveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(editorMasterPathTextBox.Text))
            {
                File.WriteAllText(editorMasterPathTextBox.Text, editorTextBox.Text);
            }
        }
    }
}
