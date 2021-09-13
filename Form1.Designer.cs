
namespace INIEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.applyEditsBtn = new System.Windows.Forms.Button();
            this.masterFileTextBox = new System.Windows.Forms.TextBox();
            this.copyToFolderTextBox = new System.Windows.Forms.TextBox();
            this.masterFileBrowseBtn = new System.Windows.Forms.Button();
            this.browseCopyToFolderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filesToEditListBox = new System.Windows.Forms.ListBox();
            this.findFilesToEditBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filenameToCopyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mergerTab = new System.Windows.Forms.TabPage();
            this.editorTab = new System.Windows.Forms.TabPage();
            this.editorLoadMasterBtn = new System.Windows.Forms.Button();
            this.editorSaveBtn = new System.Windows.Forms.Button();
            this.editorMasterPathTextBox = new System.Windows.Forms.TextBox();
            this.editorTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.mergerTab.SuspendLayout();
            this.editorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyEditsBtn
            // 
            this.applyEditsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyEditsBtn.Location = new System.Drawing.Point(572, 613);
            this.applyEditsBtn.Name = "applyEditsBtn";
            this.applyEditsBtn.Size = new System.Drawing.Size(104, 23);
            this.applyEditsBtn.TabIndex = 0;
            this.applyEditsBtn.Text = "Apply Edits";
            this.applyEditsBtn.UseVisualStyleBackColor = true;
            this.applyEditsBtn.Click += new System.EventHandler(this.applyEditsBtn_Click);
            // 
            // masterFileTextBox
            // 
            this.masterFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterFileTextBox.Location = new System.Drawing.Point(127, 6);
            this.masterFileTextBox.Name = "masterFileTextBox";
            this.masterFileTextBox.Size = new System.Drawing.Size(439, 23);
            this.masterFileTextBox.TabIndex = 1;
            // 
            // copyToFolderTextBox
            // 
            this.copyToFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyToFolderTextBox.Location = new System.Drawing.Point(127, 35);
            this.copyToFolderTextBox.Name = "copyToFolderTextBox";
            this.copyToFolderTextBox.Size = new System.Drawing.Size(439, 23);
            this.copyToFolderTextBox.TabIndex = 2;
            // 
            // masterFileBrowseBtn
            // 
            this.masterFileBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.masterFileBrowseBtn.Location = new System.Drawing.Point(572, 6);
            this.masterFileBrowseBtn.Name = "masterFileBrowseBtn";
            this.masterFileBrowseBtn.Size = new System.Drawing.Size(104, 23);
            this.masterFileBrowseBtn.TabIndex = 3;
            this.masterFileBrowseBtn.Text = "Browse";
            this.masterFileBrowseBtn.UseVisualStyleBackColor = true;
            this.masterFileBrowseBtn.Click += new System.EventHandler(this.masterFileBrowseBtn_Click);
            // 
            // browseCopyToFolderBtn
            // 
            this.browseCopyToFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseCopyToFolderBtn.Location = new System.Drawing.Point(572, 35);
            this.browseCopyToFolderBtn.Name = "browseCopyToFolderBtn";
            this.browseCopyToFolderBtn.Size = new System.Drawing.Size(104, 23);
            this.browseCopyToFolderBtn.TabIndex = 4;
            this.browseCopyToFolderBtn.Text = "Browse";
            this.browseCopyToFolderBtn.UseVisualStyleBackColor = true;
            this.browseCopyToFolderBtn.Click += new System.EventHandler(this.browseCopyToFolderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Master File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Folder to Copy To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filesToEditListBox
            // 
            this.filesToEditListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesToEditListBox.FormattingEnabled = true;
            this.filesToEditListBox.ItemHeight = 15;
            this.filesToEditListBox.Location = new System.Drawing.Point(127, 94);
            this.filesToEditListBox.Name = "filesToEditListBox";
            this.filesToEditListBox.Size = new System.Drawing.Size(549, 514);
            this.filesToEditListBox.TabIndex = 7;
            // 
            // findFilesToEditBtn
            // 
            this.findFilesToEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findFilesToEditBtn.Location = new System.Drawing.Point(461, 613);
            this.findFilesToEditBtn.Name = "findFilesToEditBtn";
            this.findFilesToEditBtn.Size = new System.Drawing.Size(105, 23);
            this.findFilesToEditBtn.TabIndex = 8;
            this.findFilesToEditBtn.Text = "Find Files To Edit";
            this.findFilesToEditBtn.UseVisualStyleBackColor = true;
            this.findFilesToEditBtn.Click += new System.EventHandler(this.findFilesToEditBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Files To Edit";
            // 
            // filenameToCopyTextBox
            // 
            this.filenameToCopyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameToCopyTextBox.Location = new System.Drawing.Point(127, 65);
            this.filenameToCopyTextBox.Name = "filenameToCopyTextBox";
            this.filenameToCopyTextBox.Size = new System.Drawing.Size(439, 23);
            this.filenameToCopyTextBox.TabIndex = 10;
            this.filenameToCopyTextBox.Text = "GameUserSettings.ini";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filename To Copy To";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(127, 617);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 15);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status : ";
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsBtn.Location = new System.Drawing.Point(572, 66);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(104, 23);
            this.saveSettingsBtn.TabIndex = 13;
            this.saveSettingsBtn.Text = "Save Settings";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.mergerTab);
            this.tabControl1.Controls.Add(this.editorTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 673);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 14;
            // 
            // mergerTab
            // 
            this.mergerTab.Controls.Add(this.applyEditsBtn);
            this.mergerTab.Controls.Add(this.saveSettingsBtn);
            this.mergerTab.Controls.Add(this.masterFileTextBox);
            this.mergerTab.Controls.Add(this.statusLabel);
            this.mergerTab.Controls.Add(this.copyToFolderTextBox);
            this.mergerTab.Controls.Add(this.label4);
            this.mergerTab.Controls.Add(this.masterFileBrowseBtn);
            this.mergerTab.Controls.Add(this.filenameToCopyTextBox);
            this.mergerTab.Controls.Add(this.browseCopyToFolderBtn);
            this.mergerTab.Controls.Add(this.label3);
            this.mergerTab.Controls.Add(this.label1);
            this.mergerTab.Controls.Add(this.findFilesToEditBtn);
            this.mergerTab.Controls.Add(this.label2);
            this.mergerTab.Controls.Add(this.filesToEditListBox);
            this.mergerTab.Location = new System.Drawing.Point(4, 24);
            this.mergerTab.Name = "mergerTab";
            this.mergerTab.Padding = new System.Windows.Forms.Padding(3);
            this.mergerTab.Size = new System.Drawing.Size(682, 645);
            this.mergerTab.TabIndex = 0;
            this.mergerTab.Text = "Merger";
            this.mergerTab.UseVisualStyleBackColor = true;
            // 
            // editorTab
            // 
            this.editorTab.Controls.Add(this.editorLoadMasterBtn);
            this.editorTab.Controls.Add(this.editorSaveBtn);
            this.editorTab.Controls.Add(this.editorMasterPathTextBox);
            this.editorTab.Controls.Add(this.editorTextBox);
            this.editorTab.Location = new System.Drawing.Point(4, 24);
            this.editorTab.Name = "editorTab";
            this.editorTab.Padding = new System.Windows.Forms.Padding(3);
            this.editorTab.Size = new System.Drawing.Size(682, 645);
            this.editorTab.TabIndex = 1;
            this.editorTab.Text = "Editor";
            this.editorTab.UseVisualStyleBackColor = true;
            // 
            // editorLoadMasterBtn
            // 
            this.editorLoadMasterBtn.Location = new System.Drawing.Point(486, 615);
            this.editorLoadMasterBtn.Name = "editorLoadMasterBtn";
            this.editorLoadMasterBtn.Size = new System.Drawing.Size(92, 24);
            this.editorLoadMasterBtn.TabIndex = 3;
            this.editorLoadMasterBtn.Text = "Load Master";
            this.editorLoadMasterBtn.UseVisualStyleBackColor = true;
            this.editorLoadMasterBtn.Click += new System.EventHandler(this.editorLoadMasterBtn_Click);
            // 
            // editorSaveBtn
            // 
            this.editorSaveBtn.Location = new System.Drawing.Point(584, 616);
            this.editorSaveBtn.Name = "editorSaveBtn";
            this.editorSaveBtn.Size = new System.Drawing.Size(92, 23);
            this.editorSaveBtn.TabIndex = 2;
            this.editorSaveBtn.Text = "Save File";
            this.editorSaveBtn.UseVisualStyleBackColor = true;
            this.editorSaveBtn.Click += new System.EventHandler(this.editorSaveBtn_Click);
            // 
            // editorMasterPathTextBox
            // 
            this.editorMasterPathTextBox.Location = new System.Drawing.Point(7, 616);
            this.editorMasterPathTextBox.Name = "editorMasterPathTextBox";
            this.editorMasterPathTextBox.Size = new System.Drawing.Size(473, 23);
            this.editorMasterPathTextBox.TabIndex = 1;
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(7, 7);
            this.editorTextBox.Multiline = true;
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editorTextBox.Size = new System.Drawing.Size(669, 602);
            this.editorTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(714, 697);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(730, 736);
            this.Name = "Form1";
            this.Text = "INI File Merger";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.mergerTab.ResumeLayout(false);
            this.mergerTab.PerformLayout();
            this.editorTab.ResumeLayout(false);
            this.editorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applyEditsBtn;
        private System.Windows.Forms.TextBox masterFileTextBox;
        private System.Windows.Forms.TextBox copyToFolderTextBox;
        private System.Windows.Forms.Button masterFileBrowseBtn;
        private System.Windows.Forms.Button browseCopyToFolderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox filesToEditListBox;
        private System.Windows.Forms.Button findFilesToEditBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filenameToCopyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mergerTab;
        private System.Windows.Forms.TabPage editorTab;
        private System.Windows.Forms.Button editorLoadMasterBtn;
        private System.Windows.Forms.Button editorSaveBtn;
        private System.Windows.Forms.TextBox editorMasterPathTextBox;
        private System.Windows.Forms.TextBox editorTextBox;
    }
}

