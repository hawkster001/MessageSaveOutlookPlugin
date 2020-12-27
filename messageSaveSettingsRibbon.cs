using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SentMessagesSave
{
    public partial class settingsRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnFilePath_Click(object sender, RibbonControlEventArgs e)
        {
            FormFilePath frmFilePath = new FormFilePath();
            frmFilePath.ShowDialog();
        }

        private void btnMatchText_Click(object sender, RibbonControlEventArgs e)
        {
            FormMatchText frmMatchText = new FormMatchText();
            frmMatchText.ShowDialog();
        }
    }
}
