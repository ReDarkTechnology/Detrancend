using Detranscend.Transcendence;
using System;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace Detranscend
{
    public partial class MainForm : Form
    {
        public static MainForm Instance = new();
        public static string? WorkingDirectory;

        public MainForm()
        {
            InitializeComponent();
            Icon = MainResources.Detranscend;

            fullDockPanel.ActiveContentChanged += FullDockPanel_ActiveContentChanged;
            darkTheme.ApplyTo(mainStrip);

            Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object? sender, System.EventArgs e)
        {
            var starterForm = new StartingForm();
            starterForm.Show();
        }

        private void FullDockPanel_ActiveContentChanged(object? sender, System.EventArgs e)
        {
        }

        private void openDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var xmlFile = new TExtension(openDialog.FileName);
        }

        private void fileToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            openDialog.ShowDialog();
        }

        public void OpenProject(string directory)
        {
            if (!Directory.Exists(directory)) return;

            WorkingDirectory = directory;
            var files = Directory.GetFiles(directory, "*.xml", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var xmlFile = new TRoot(file);
            }

            foreach (var unid in UnidManager.Entities)
            {
                if (unid.Source != null && unid.Source is TBase source)
                    Console.WriteLine($"{unid.ToString()} 0x{unid.Id.ToString("X8")} ({source.TagName})");
                else
                    Console.WriteLine($"{unid.ToString()} 0x{unid.Id.ToString("X8")}");
            }

            Console.WriteLine("Done");
        }

        public void CreateProject(string directory, string name, Unid unid)
        {

        }
    }
}
