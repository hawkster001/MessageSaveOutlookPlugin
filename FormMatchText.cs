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
    public partial class FormMatchText : Form
    {
        public FormMatchText()
        {
            InitializeComponent();
        }

        private void FormMatchText_Load(object sender, EventArgs e)
        {
            txtCurrentMatchText.Text = Properties.Settings.Default.matchText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.matchText = txtCurrentMatchText.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("The new Match Text has been saved!");
        }
    }
}
