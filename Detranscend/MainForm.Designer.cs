using System.Windows.Forms;
using System.Drawing;

namespace Detranscend
{
    partial class MainForm
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
            fullDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            darkTheme = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            mainStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem1 = new ToolStripMenuItem();
            folderToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            goToToolStripMenuItem = new ToolStripMenuItem();
            findAndReplaceToolStripMenuItem = new ToolStripMenuItem();
            quickFindToolStripMenuItem = new ToolStripMenuItem();
            quickReplaceToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            findInFielsToolStripMenuItem = new ToolStripMenuItem();
            replaceInFilesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            saveDialog = new SaveFileDialog();
            openDialog = new OpenFileDialog();
            mainStrip.SuspendLayout();
            SuspendLayout();
            // 
            // fullDockPanel
            // 
            fullDockPanel.Dock = DockStyle.Fill;
            fullDockPanel.DockBackColor = Color.FromArgb(45, 45, 48);
            fullDockPanel.Location = new Point(0, 24);
            fullDockPanel.Name = "fullDockPanel";
            fullDockPanel.Padding = new Padding(6);
            fullDockPanel.ShowAutoHideContentOnHover = false;
            fullDockPanel.Size = new Size(1264, 657);
            fullDockPanel.TabIndex = 0;
            fullDockPanel.Theme = darkTheme;
            // 
            // mainStrip
            // 
            mainStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            mainStrip.Location = new Point(0, 0);
            mainStrip.Name = "mainStrip";
            mainStrip.Size = new Size(1264, 24);
            mainStrip.TabIndex = 1;
            mainStrip.Text = "mainStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectToolStripMenuItem, fileToolStripMenuItem1 });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(111, 22);
            projectToolStripMenuItem.Text = "Project";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(111, 22);
            fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectToolStripMenuItem1, folderToolStripMenuItem, fileToolStripMenuItem2 });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // projectToolStripMenuItem1
            // 
            projectToolStripMenuItem1.Name = "projectToolStripMenuItem1";
            projectToolStripMenuItem1.Size = new Size(180, 22);
            projectToolStripMenuItem1.Text = "Project";
            // 
            // folderToolStripMenuItem
            // 
            folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            folderToolStripMenuItem.Size = new Size(180, 22);
            folderToolStripMenuItem.Text = "Folder";
            // 
            // fileToolStripMenuItem2
            // 
            fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            fileToolStripMenuItem2.Size = new Size(180, 22);
            fileToolStripMenuItem2.Text = "File";
            fileToolStripMenuItem2.Click += fileToolStripMenuItem2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { goToToolStripMenuItem, findAndReplaceToolStripMenuItem, toolStripSeparator3, undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator5, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator6, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.Size = new Size(180, 22);
            goToToolStripMenuItem.Text = "Go To";
            // 
            // findAndReplaceToolStripMenuItem
            // 
            findAndReplaceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quickFindToolStripMenuItem, quickReplaceToolStripMenuItem, toolStripSeparator4, findInFielsToolStripMenuItem, replaceInFilesToolStripMenuItem });
            findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            findAndReplaceToolStripMenuItem.Size = new Size(180, 22);
            findAndReplaceToolStripMenuItem.Text = "Find and Replace";
            // 
            // quickFindToolStripMenuItem
            // 
            quickFindToolStripMenuItem.Name = "quickFindToolStripMenuItem";
            quickFindToolStripMenuItem.Size = new Size(180, 22);
            quickFindToolStripMenuItem.Text = "Quick Find";
            // 
            // quickReplaceToolStripMenuItem
            // 
            quickReplaceToolStripMenuItem.Name = "quickReplaceToolStripMenuItem";
            quickReplaceToolStripMenuItem.Size = new Size(180, 22);
            quickReplaceToolStripMenuItem.Text = "Quick Replace";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // findInFielsToolStripMenuItem
            // 
            findInFielsToolStripMenuItem.Name = "findInFielsToolStripMenuItem";
            findInFielsToolStripMenuItem.Size = new Size(180, 22);
            findInFielsToolStripMenuItem.Text = "Find in Files";
            // 
            // replaceInFilesToolStripMenuItem
            // 
            replaceInFilesToolStripMenuItem.Name = "replaceInFilesToolStripMenuItem";
            replaceInFilesToolStripMenuItem.Size = new Size(180, 22);
            replaceInFilesToolStripMenuItem.Text = "Replace in Files";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(180, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // saveDialog
            // 
            saveDialog.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
            saveDialog.RestoreDirectory = true;
            // 
            // openDialog
            // 
            openDialog.FileName = "Transcendence";
            openDialog.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
            openDialog.RestoreDirectory = true;
            openDialog.FileOk += openDialog_FileOk;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(fullDockPanel);
            Controls.Add(mainStrip);
            MainMenuStrip = mainStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detranscend";
            WindowState = FormWindowState.Maximized;
            mainStrip.ResumeLayout(false);
            mainStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public WeifenLuo.WinFormsUI.Docking.DockPanel fullDockPanel;
        private MenuStrip mainStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem1;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem goToToolStripMenuItem;
        private ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private ToolStripMenuItem quickFindToolStripMenuItem;
        private ToolStripMenuItem quickReplaceToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem findInFielsToolStripMenuItem;
        private ToolStripMenuItem replaceInFilesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme darkTheme;
        private SaveFileDialog saveDialog;
        private OpenFileDialog openDialog;
    }
}
