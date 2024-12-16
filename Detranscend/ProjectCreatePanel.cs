using System;
using System.IO;
using System.Windows.Forms;

namespace Detranscend
{
    public partial class ProjectCreatePanel : Form
    {
        public ProjectCreatePanel()
        {
            InitializeComponent();
            Icon = MainResources.Detranscend;

            typeBox.SelectedIndex = 0;
            pathBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Transcendence");

            UpdateActualPath();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            switch (typeBox.SelectedIndex)
            {
                case 0:
                    break;
                default:
                    MessageBox.Show("This type of project is not supported yet!");
                    break;
            }
        }

        public void UpdateActualPath() => actualPath.Text = $"The project will be created at: {Path.Combine(pathBox.Text, nameBox.Text)}";
        private void nameBox_TextChanged(object sender, EventArgs e) => UpdateActualPath();
        private void pathBox_TextChanged(object sender, EventArgs e) => UpdateActualPath();
    }
}
