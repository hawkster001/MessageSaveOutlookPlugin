using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentMessagesSave
{
    public partial class FormFilePath : Form
    {
        public FormFilePath()
        {
            InitializeComponent();
        }

        private void FormFilePath_Load(object sender, EventArgs e)
        {
            txtCurrentPath.Text = Properties.Settings.Default.filePath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.filePath = txtCurrentPath.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("The new path has been saved!");
        }
    }
}
