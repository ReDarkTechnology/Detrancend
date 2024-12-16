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
using Ookii.Dialogs.WinForms;

namespace Detranscend
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
            Icon = MainResources.Detranscend;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var createProjectDialog = new ProjectCreatePanel();
            createProjectDialog.Show();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!VistaFolderBrowserDialog.IsVistaFolderDialogSupported)
                MessageBox.Show(this, "Because you are not using Windows Vista or later, the regular folder browser dialog will be used. Please use Windows Vista to see the new dialog.", "Sample folder browser dialog");

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                MainForm.Instance.OpenProject(folderBrowser.SelectedPath);
                Close();
            }
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
        }

        private void openDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (openDialog.FileName != null)
            {
                if (File.Exists(openDialog.FileName))
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(openDialog.FileName);
                    if (versionInfo.ProductVersion != null)
                    {
                        if (versionInfo.ProductVersion.Contains("1.8.3"))
                        {
                            Settings.SetString("TranscendenceExecutable", openDialog.FileName);
                            Settings.Save();
                            MessageBox.Show("You've configured Transcendence 1.8.3 successfully!");
                            return;
                        }
                    }
                }

                MessageBox.Show("This editor only supports Transcendence version 1.8.3");
            }
        }
    }
}
