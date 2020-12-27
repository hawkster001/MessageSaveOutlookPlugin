
namespace SentMessagesSave
{
    partial class settingsRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public settingsRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageSaveSettingsTab = this.Factory.CreateRibbonTab();
            this.settingsGroup = this.Factory.CreateRibbonGroup();
            this.btnFilePath = this.Factory.CreateRibbonButton();
            this.btnMatchText = this.Factory.CreateRibbonButton();
            this.messageSaveSettingsTab.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageSaveSettingsTab
            // 
            this.messageSaveSettingsTab.Groups.Add(this.settingsGroup);
            this.messageSaveSettingsTab.Label = "Message Save Settings";
            this.messageSaveSettingsTab.Name = "messageSaveSettingsTab";
            // 
            // settingsGroup
            // 
            this.settingsGroup.Items.Add(this.btnFilePath);
            this.settingsGroup.Items.Add(this.btnMatchText);
            this.settingsGroup.Label = "Settings";
            this.settingsGroup.Name = "settingsGroup";
            // 
            // btnFilePath
            // 
            this.btnFilePath.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnFilePath.Image = global::SentMessagesSave.Properties.Resources.FolderIcon;
            this.btnFilePath.Label = "File Path";
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.ShowImage = true;
            this.btnFilePath.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnFilePath_Click);
            // 
            // btnMatchText
            // 
            this.btnMatchText.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnMatchText.Image = global::SentMessagesSave.Properties.Resources.SearchIcon;
            this.btnMatchText.Label = "Match Text";
            this.btnMatchText.Name = "btnMatchText";
            this.btnMatchText.ShowImage = true;
            this.btnMatchText.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMatchText_Click);
            // 
            // settingsRibbon
            // 
            this.Name = "settingsRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.messageSaveSettingsTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.messageSaveSettingsTab.ResumeLayout(false);
            this.messageSaveSettingsTab.PerformLayout();
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab messageSaveSettingsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup settingsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnFilePath;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMatchText;
    }

    partial class ThisRibbonCollection
    {
        internal settingsRibbon Ribbon1
        {
            get { return this.GetRibbon<settingsRibbon>(); }
        }
    }
}
