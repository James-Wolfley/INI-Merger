
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
            this.SuspendLayout();
            // 
            // applyEditsBtn
            // 
            this.applyEditsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyEditsBtn.Location = new System.Drawing.Point(597, 665);
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
            this.masterFileTextBox.Location = new System.Drawing.Point(133, 12);
            this.masterFileTextBox.Name = "masterFileTextBox";
            this.masterFileTextBox.Size = new System.Drawing.Size(458, 23);
            this.masterFileTextBox.TabIndex = 1;
            // 
            // copyToFolderTextBox
            // 
            this.copyToFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyToFolderTextBox.Location = new System.Drawing.Point(133, 41);
            this.copyToFolderTextBox.Name = "copyToFolderTextBox";
            this.copyToFolderTextBox.Size = new System.Drawing.Size(458, 23);
            this.copyToFolderTextBox.TabIndex = 2;
            // 
            // masterFileBrowseBtn
            // 
            this.masterFileBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.masterFileBrowseBtn.Location = new System.Drawing.Point(597, 11);
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
            this.browseCopyToFolderBtn.Location = new System.Drawing.Point(597, 40);
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
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Master File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
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
            this.filesToEditListBox.Location = new System.Drawing.Point(133, 100);
            this.filesToEditListBox.Name = "filesToEditListBox";
            this.filesToEditListBox.Size = new System.Drawing.Size(568, 559);
            this.filesToEditListBox.TabIndex = 7;
            // 
            // findFilesToEditBtn
            // 
            this.findFilesToEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findFilesToEditBtn.Location = new System.Drawing.Point(486, 665);
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
            this.label3.Location = new System.Drawing.Point(59, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Files To Edit";
            // 
            // filenameToCopyTextBox
            // 
            this.filenameToCopyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameToCopyTextBox.Location = new System.Drawing.Point(133, 71);
            this.filenameToCopyTextBox.Name = "filenameToCopyTextBox";
            this.filenameToCopyTextBox.Size = new System.Drawing.Size(458, 23);
            this.filenameToCopyTextBox.TabIndex = 10;
            this.filenameToCopyTextBox.Text = "GameUserSettings.ini";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filename To Copy To";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(133, 669);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 15);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status : ";
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Location = new System.Drawing.Point(597, 71);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(104, 23);
            this.saveSettingsBtn.TabIndex = 13;
            this.saveSettingsBtn.Text = "Save Settings";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(714, 697);
            this.Controls.Add(this.saveSettingsBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filenameToCopyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findFilesToEditBtn);
            this.Controls.Add(this.filesToEditListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseCopyToFolderBtn);
            this.Controls.Add(this.masterFileBrowseBtn);
            this.Controls.Add(this.copyToFolderTextBox);
            this.Controls.Add(this.masterFileTextBox);
            this.Controls.Add(this.applyEditsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(730, 736);
            this.Name = "Form1";
            this.Text = "INI File Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

