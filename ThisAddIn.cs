﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

//Required for Regex Replace function
using System.Text.RegularExpressions;
//Required to produce MessageBox object
using System.Windows.Forms;

namespace SentMessagesSave
{
    public partial class ThisAddIn
    {
        Outlook.NameSpace outlookNameSpace;
        Outlook.MAPIFolder sent;
        Outlook.Items items;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
            //When Application Starts, This Code Will Run
        {
            outlookNameSpace = this.Application.GetNamespace("MAPI");
            //Sets Watch Folder
            sent = outlookNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderSentMail);

            items = sent.Items;
            //Event Handler for Added Mail Items
            items.ItemAdd += new Outlook.ItemsEvents_ItemAddEventHandler(items_ItemAdd);
        }

        void items_ItemAdd(object Item)
        {
            //Loads Mail Item
            Outlook.MailItem mail = (Outlook.MailItem)Item;

            //Set Custom Path Here
            String path = @"C:\temp\";

            if (mail.Subject != null)
            {
                //Formats String, Removes Special Characters
                String subject = Regex.Replace(mail.Subject, @"[^0-9a-zA-Z]+", "");

                //Saves Mail to Specified Path
                mail.SaveAs((path + subject + ".msg"));
            }
            else
            {
                //Handling of Mail With No Subject
                mail.SaveAs(path + "NoSubject" + ".msg");
            }
        }
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
        }
        
        #endregion
    }
}
