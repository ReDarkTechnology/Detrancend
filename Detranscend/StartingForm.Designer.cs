namespace Detranscend
{
    partial class StartingForm
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
            createBtn = new System.Windows.Forms.Button();
            openBtn = new System.Windows.Forms.Button();
            dialogLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            recentLabel = new System.Windows.Forms.Label();
            recentProjectsLayout = new System.Windows.Forms.FlowLayoutPanel();
            configBtn = new System.Windows.Forms.Button();
            openDialog = new System.Windows.Forms.OpenFileDialog();
            folderBrowser = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            SuspendLayout();
            // 
            // createBtn
            // 
            createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            createBtn.Location = new System.Drawing.Point(30, 96);
            createBtn.Name = "createBtn";
            createBtn.Size = new System.Drawing.Size(247, 49);
            createBtn.TabIndex = 0;
            createBtn.Text = "Create Project";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // openBtn
            // 
            openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            openBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            openBtn.Location = new System.Drawing.Point(30, 151);
            openBtn.Name = "openBtn";
            openBtn.Size = new System.Drawing.Size(247, 49);
            openBtn.TabIndex = 1;
            openBtn.Text = "Open Project";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // dialogLabel
            // 
            dialogLabel.AutoSize = true;
            dialogLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            dialogLabel.Location = new System.Drawing.Point(28, 24);
            dialogLabel.Name = "dialogLabel";
            dialogLabel.Size = new System.Drawing.Size(148, 32);
            dialogLabel.TabIndex = 2;
            dialogLabel.Text = "Detranscend";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            descriptionLabel.Location = new System.Drawing.Point(29, 58);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(248, 21);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "A tool for Transcendence modding";
            // 
            // recentLabel
            // 
            recentLabel.AutoSize = true;
            recentLabel.Location = new System.Drawing.Point(298, 29);
            recentLabel.Name = "recentLabel";
            recentLabel.Size = new System.Drawing.Size(88, 15);
            recentLabel.TabIndex = 4;
            recentLabel.Text = "Recent Projects";
            // 
            // recentProjectsLayout
            // 
            recentProjectsLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            recentProjectsLayout.AutoScroll = true;
            recentProjectsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            recentProjectsLayout.Location = new System.Drawing.Point(298, 51);
            recentProjectsLayout.Name = "recentProjectsLayout";
            recentProjectsLayout.Size = new System.Drawing.Size(464, 365);
            recentProjectsLayout.TabIndex = 5;
            // 
            // configBtn
            // 
            configBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            configBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            configBtn.Location = new System.Drawing.Point(30, 206);
            configBtn.Name = "configBtn";
            configBtn.Size = new System.Drawing.Size(247, 49);
            configBtn.TabIndex = 6;
            configBtn.Text = "Configure Transcendence";
            configBtn.UseVisualStyleBackColor = true;
            configBtn.Click += configBtn_Click;
            // 
            // openDialog
            // 
            openDialog.FileName = "Transcendence";
            openDialog.Filter = "Executable file (*.exe)|*.exe|All files (*.*)|*.*";
            openDialog.Title = "Choose the Transcendence executable file...";
            openDialog.FileOk += openDialog_FileOk;
            // 
            // folderBrowser
            // 
            folderBrowser.Description = "Select the project you want to open...";
            folderBrowser.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            folderBrowser.UseDescriptionForTitle = true;
            // 
            // StartingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(configBtn);
            Controls.Add(recentProjectsLayout);
            Controls.Add(recentLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(dialogLabel);
            Controls.Add(openBtn);
            Controls.Add(createBtn);
            ForeColor = System.Drawing.Color.White;
            Name = "StartingForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Detranscend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label dialogLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label recentLabel;
        private System.Windows.Forms.FlowLayoutPanel recentProjectsLayout;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private Ookii.Dialogs.WinForms.VistaFolderBrowserDialog folderBrowser;
    }
}