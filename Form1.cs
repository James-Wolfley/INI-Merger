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
            string[] files = Directory.GetFiles(copyToFolderTextBox.Text, filenameToCopyTextBox.Text, SearchOption.AllDirectories);
            //serverConfigFiles = Array.Empty<string>();
            filesToEditListBox.Items.Clear();
            foreach (string file in files)
            {
                filesToEditListBox.Items.Add(file);
            }
        }

        private void applyEditsBtn_Click(object sender, EventArgs e)
        {
            var parser = new IniParser.Parser.IniDataParser();
            parser.Configuration.AllowDuplicateKeys = true;
            var fileParser = new FileIniDataParser();
            IniData user_config = parser.Parse(File.ReadAllText(masterFileTextBox.Text));
            foreach (string file in filesToEditListBox.Items)
            {
                IniData config = parser.Parse(File.ReadAllText(file));
                config.Merge(user_config);
                fileParser.WriteFile(file, config);
                Debug.WriteLine("Applying File");
            }
            Debug.WriteLine("Finished Applying");
        }


        private bool cleanFiles (string[] files)
        {



            return true;
        }
    }
}
