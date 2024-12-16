namespace Detranscend
{
    partial class ProjectCreatePanel
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
            dialogTitle = new System.Windows.Forms.Label();
            typeBox = new System.Windows.Forms.ComboBox();
            typeLabel = new System.Windows.Forms.Label();
            uidLabel = new System.Windows.Forms.Label();
            uidBox = new System.Windows.Forms.TextBox();
            nameBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pathBox = new System.Windows.Forms.TextBox();
            browseBtn = new System.Windows.Forms.Button();
            createBtn = new System.Windows.Forms.Button();
            actualPath = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // dialogTitle
            // 
            dialogTitle.AutoSize = true;
            dialogTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            dialogTitle.Location = new System.Drawing.Point(14, 16);
            dialogTitle.Name = "dialogTitle";
            dialogTitle.Size = new System.Drawing.Size(279, 30);
            dialogTitle.TabIndex = 0;
            dialogTitle.Text = "Configure your new project";
            // 
            // typeBox
            // 
            typeBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            typeBox.BackColor = System.Drawing.Color.FromArgb(21, 21, 21);
            typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            typeBox.ForeColor = System.Drawing.Color.White;
            typeBox.FormattingEnabled = true;
            typeBox.Items.AddRange(new object[] { "Extension", "Adventure", "Universe", "Module" });
            typeBox.Location = new System.Drawing.Point(91, 59);
            typeBox.Name = "typeBox";
            typeBox.Size = new System.Drawing.Size(331, 23);
            typeBox.TabIndex = 1;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(18, 62);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(31, 15);
            typeLabel.TabIndex = 2;
            typeLabel.Text = "Type";
            // 
            // uidLabel
            // 
            uidLabel.AutoSize = true;
            uidLabel.Location = new System.Drawing.Point(18, 91);
            uidLabel.Name = "uidLabel";
            uidLabel.Size = new System.Drawing.Size(35, 15);
            uidLabel.TabIndex = 3;
            uidLabel.Text = "UNID";
            // 
            // uidBox
            // 
            uidBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            uidBox.BackColor = System.Drawing.Color.FromArgb(21, 21, 21);
            uidBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            uidBox.ForeColor = System.Drawing.Color.White;
            uidBox.Location = new System.Drawing.Point(91, 88);
            uidBox.Name = "uidBox";
            uidBox.Size = new System.Drawing.Size(331, 23);
            uidBox.TabIndex = 4;
            uidBox.Text = "0x00000000";
            // 
            // nameBox
            // 
            nameBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nameBox.BackColor = System.Drawing.Color.FromArgb(21, 21, 21);
            nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nameBox.ForeColor = System.Drawing.Color.White;
            nameBox.Location = new System.Drawing.Point(91, 117);
            nameBox.Name = "nameBox";
            nameBox.Size = new System.Drawing.Size(331, 23);
            nameBox.TabIndex = 5;
            nameBox.Text = "YourExtension";
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 120);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 15);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 149);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "Path";
            // 
            // pathBox
            // 
            pathBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pathBox.BackColor = System.Drawing.Color.FromArgb(21, 21, 21);
            pathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pathBox.ForeColor = System.Drawing.Color.White;
            pathBox.Location = new System.Drawing.Point(91, 146);
            pathBox.Name = "pathBox";
            pathBox.Size = new System.Drawing.Size(250, 23);
            pathBox.TabIndex = 7;
            pathBox.Text = "C:\\Users\\Documents";
            pathBox.TextChanged += pathBox_TextChanged;
            // 
            // browseBtn
            // 
            browseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            browseBtn.Location = new System.Drawing.Point(347, 146);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new System.Drawing.Size(75, 23);
            browseBtn.TabIndex = 9;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createBtn.Location = new System.Drawing.Point(334, 216);
            createBtn.Name = "createBtn";
            createBtn.Size = new System.Drawing.Size(88, 33);
            createBtn.TabIndex = 10;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // actualPath
            // 
            actualPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            actualPath.Location = new System.Drawing.Point(18, 177);
            actualPath.Name = "actualPath";
            actualPath.Size = new System.Drawing.Size(404, 36);
            actualPath.TabIndex = 11;
            actualPath.Text = "Project will be created in:";
            // 
            // ProjectCreatePanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new System.Drawing.Size(434, 261);
            Controls.Add(actualPath);
            Controls.Add(createBtn);
            Controls.Add(browseBtn);
            Controls.Add(label1);
            Controls.Add(pathBox);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(uidBox);
            Controls.Add(uidLabel);
            Controls.Add(typeLabel);
            Controls.Add(typeBox);
            Controls.Add(dialogTitle);
            ForeColor = System.Drawing.Color.White;
            Name = "ProjectCreatePanel";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label dialogTitle;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.TextBox uidBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label actualPath;
    }
}