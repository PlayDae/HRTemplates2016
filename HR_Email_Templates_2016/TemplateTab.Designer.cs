namespace HR_Email_Templates_2016
{
    partial class TemplateTab : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TemplateTab()
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
            this.HRTemplateTab = this.Factory.CreateRibbonTab();
            this.ChangeButtons = this.Factory.CreateRibbonGroup();
            this.ChangeMenu = this.Factory.CreateRibbonMenu();
            this.ChangeButton1 = this.Factory.CreateRibbonButton();
            this.ChangeButton2 = this.Factory.CreateRibbonButton();
            this.ChangeButton3 = this.Factory.CreateRibbonButton();
            this.ChangeButton4 = this.Factory.CreateRibbonButton();
            this.ChangeButton5 = this.Factory.CreateRibbonButton();
            this.ChangeButton6 = this.Factory.CreateRibbonButton();
            this.ChangeButton7 = this.Factory.CreateRibbonButton();
            this.LeaveRequests = this.Factory.CreateRibbonGroup();
            this.LeaveMenu = this.Factory.CreateRibbonMenu();
            this.LeaveButton1 = this.Factory.CreateRibbonButton();
            this.LeaveButton2 = this.Factory.CreateRibbonButton();
            this.LeaveButton3 = this.Factory.CreateRibbonButton();
            this.LeaveButton4 = this.Factory.CreateRibbonButton();
            this.LeaveButton5 = this.Factory.CreateRibbonButton();
            this.LeaveButton6 = this.Factory.CreateRibbonButton();
            this.LeaveButton7 = this.Factory.CreateRibbonButton();
            this.FMLAADA = this.Factory.CreateRibbonGroup();
            this.FMLAMenu = this.Factory.CreateRibbonMenu();
            this.FMLAButton1 = this.Factory.CreateRibbonButton();
            this.FMLAButton2 = this.Factory.CreateRibbonButton();
            this.FMLAButton3 = this.Factory.CreateRibbonButton();
            this.FMLAButton4 = this.Factory.CreateRibbonButton();
            this.FMLAButton5 = this.Factory.CreateRibbonButton();
            this.FMLAButton6 = this.Factory.CreateRibbonButton();
            this.FMLAButton7 = this.Factory.CreateRibbonButton();
            this.FMLAButton8 = this.Factory.CreateRibbonButton();
            this.FMLAButton9 = this.Factory.CreateRibbonButton();
            this.FMLAButton10 = this.Factory.CreateRibbonButton();
            this.InfoRequests = this.Factory.CreateRibbonGroup();
            this.InfoMenu = this.Factory.CreateRibbonMenu();
            this.RequestsButton1 = this.Factory.CreateRibbonButton();
            this.RequestsButton2 = this.Factory.CreateRibbonButton();
            this.RequestsButton3 = this.Factory.CreateRibbonButton();
            this.HRTemplateTab.SuspendLayout();
            this.ChangeButtons.SuspendLayout();
            this.LeaveRequests.SuspendLayout();
            this.FMLAADA.SuspendLayout();
            this.InfoRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // HRTemplateTab
            // 
            this.HRTemplateTab.Groups.Add(this.ChangeButtons);
            this.HRTemplateTab.Groups.Add(this.LeaveRequests);
            this.HRTemplateTab.Groups.Add(this.FMLAADA);
            this.HRTemplateTab.Groups.Add(this.InfoRequests);
            this.HRTemplateTab.Label = "Templates";
            this.HRTemplateTab.Name = "HRTemplateTab";
            // 
            // ChangeButtons
            // 
            this.ChangeButtons.Items.Add(this.ChangeMenu);
            this.ChangeButtons.Label = "Change Requests";
            this.ChangeButtons.Name = "ChangeButtons";
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Items.Add(this.ChangeButton1);
            this.ChangeMenu.Items.Add(this.ChangeButton2);
            this.ChangeMenu.Items.Add(this.ChangeButton3);
            this.ChangeMenu.Items.Add(this.ChangeButton4);
            this.ChangeMenu.Items.Add(this.ChangeButton5);
            this.ChangeMenu.Items.Add(this.ChangeButton6);
            this.ChangeMenu.Items.Add(this.ChangeButton7);
            this.ChangeMenu.Label = "Changes";
            this.ChangeMenu.Name = "ChangeMenu";
            // 
            // ChangeButton1
            // 
            this.ChangeButton1.Label = "New Hire";
            this.ChangeButton1.Name = "ChangeButton1";
            this.ChangeButton1.ShowImage = true;
            this.ChangeButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ChangeButton1_Click);
            // 
            // ChangeButton2
            // 
            this.ChangeButton2.Label = "Position Change";
            this.ChangeButton2.Name = "ChangeButton2";
            this.ChangeButton2.ShowImage = true;
            this.ChangeButton2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ChangeButton2_Click);
            // 
            // ChangeButton3
            // 
            this.ChangeButton3.Label = "Conversion";
            this.ChangeButton3.Name = "ChangeButton3";
            this.ChangeButton3.ShowImage = true;
            this.ChangeButton3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ChangeButton3_Click);
            // 
            // ChangeButton4
            // 
            this.ChangeButton4.Label = "Name Change";
            this.ChangeButton4.Name = "ChangeButton4";
            this.ChangeButton4.ShowImage = true;
            this.ChangeButton4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ChangeButton4_Click);
            // 
            // ChangeButton5
            // 
            this.ChangeButton5.Label = "Department Change";
            this.ChangeButton5.Name = "ChangeButton5";
            this.ChangeButton5.ShowImage = true;
            this.ChangeButton5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ChangeButton5_Click);
            // 
            // ChangeButton6
            // 
            this.ChangeButton6.Label = "Separation";
            this.ChangeButton6.Name = "ChangeButton6";
            this.ChangeButton6.ShowImage = true;
            this.ChangeButton6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ChangeButton6_Click);
            // 
            // ChangeButton7
            // 
            this.ChangeButton7.Label = "Separation - Temp";
            this.ChangeButton7.Name = "ChangeButton7";
            this.ChangeButton7.ShowImage = true;
            this.ChangeButton7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ChangeButton7_Click);
            // 
            // LeaveRequests
            // 
            this.LeaveRequests.Items.Add(this.LeaveMenu);
            this.LeaveRequests.Label = "Leave Requests";
            this.LeaveRequests.Name = "LeaveRequests";
            // 
            // LeaveMenu
            // 
            this.LeaveMenu.Items.Add(this.LeaveButton1);
            this.LeaveMenu.Items.Add(this.LeaveButton2);
            this.LeaveMenu.Items.Add(this.LeaveButton3);
            this.LeaveMenu.Items.Add(this.LeaveButton4);
            this.LeaveMenu.Items.Add(this.LeaveButton5);
            this.LeaveMenu.Items.Add(this.LeaveButton6);
            this.LeaveMenu.Items.Add(this.LeaveButton7);
            this.LeaveMenu.Label = "Leave";
            this.LeaveMenu.Name = "LeaveMenu";
            // 
            // LeaveButton1
            // 
            this.LeaveButton1.Label = "LoA Departure";
            this.LeaveButton1.Name = "LeaveButton1";
            this.LeaveButton1.ShowImage = true;
            this.LeaveButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LeaveButton1_Click);
            // 
            // LeaveButton2
            // 
            this.LeaveButton2.Label = "LoA Return";
            this.LeaveButton2.Name = "LeaveButton2";
            this.LeaveButton2.ShowImage = true;
            this.LeaveButton2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LeaveButton2_Click);
            // 
            // LeaveButton3
            // 
            this.LeaveButton3.Label = "Intermittent Leave";
            this.LeaveButton3.Name = "LeaveButton3";
            this.LeaveButton3.ShowImage = true;
            this.LeaveButton3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LeaveButton3_Click);
            // 
            // LeaveButton4
            // 
            this.LeaveButton4.Label = "Bereavement";
            this.LeaveButton4.Name = "LeaveButton4";
            this.LeaveButton4.ShowImage = true;
            this.LeaveButton4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LeaveButton4_Click);
            // 
            // LeaveButton5
            // 
            this.LeaveButton5.Label = "Pregnancy Leave - CA";
            this.LeaveButton5.Name = "LeaveButton5";
            this.LeaveButton5.ShowImage = true;
            this.LeaveButton5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LeaveButton5_Click);
            // 
            // LeaveButton6
            // 
            this.LeaveButton6.Label = "Jury Duty";
            this.LeaveButton6.Name = "LeaveButton6";
            this.LeaveButton6.ShowImage = true;
            this.LeaveButton6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LeaveButton6_Click);
            // 
            // LeaveButton7
            // 
            this.LeaveButton7.Label = "Return to Work";
            this.LeaveButton7.Name = "LeaveButton7";
            this.LeaveButton7.ShowImage = true;
            this.LeaveButton7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LeaveButton7_Click);
            // 
            // FMLAADA
            // 
            this.FMLAADA.Items.Add(this.FMLAMenu);
            this.FMLAADA.Label = "FMLA and ADA Requests";
            this.FMLAADA.Name = "FMLAADA";
            // 
            // FMLAMenu
            // 
            this.FMLAMenu.Items.Add(this.FMLAButton1);
            this.FMLAMenu.Items.Add(this.FMLAButton2);
            this.FMLAMenu.Items.Add(this.FMLAButton3);
            this.FMLAMenu.Items.Add(this.FMLAButton4);
            this.FMLAMenu.Items.Add(this.FMLAButton5);
            this.FMLAMenu.Items.Add(this.FMLAButton6);
            this.FMLAMenu.Items.Add(this.FMLAButton7);
            this.FMLAMenu.Items.Add(this.FMLAButton8);
            this.FMLAMenu.Items.Add(this.FMLAButton9);
            this.FMLAMenu.Items.Add(this.FMLAButton10);
            this.FMLAMenu.Label = "FMLA and ADA";
            this.FMLAMenu.Name = "FMLAMenu";
            // 
            // FMLAButton1
            // 
            this.FMLAButton1.Label = "FMLA - CFRA Request for Leave - CA";
            this.FMLAButton1.Name = "FMLAButton1";
            this.FMLAButton1.ShowImage = true;
            this.FMLAButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton1_Click);
            // 
            // FMLAButton2
            // 
            this.FMLAButton2.Label = "FMLA - Pregnancy Leave  - NV";
            this.FMLAButton2.Name = "FMLAButton2";
            this.FMLAButton2.ShowImage = true;
            this.FMLAButton2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton2_Click);
            // 
            // FMLAButton3
            // 
            this.FMLAButton3.Label = "FMLA - Request for Leave - NV";
            this.FMLAButton3.Name = "FMLAButton3";
            this.FMLAButton3.ShowImage = true;
            this.FMLAButton3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton3_Click);
            // 
            // FMLAButton4
            // 
            this.FMLAButton4.Label = "FMLA - Leave Designation - NV";
            this.FMLAButton4.Name = "FMLAButton4";
            this.FMLAButton4.ShowImage = true;
            this.FMLAButton4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton4_Click);
            // 
            // FMLAButton5
            // 
            this.FMLAButton5.Label = "ADA - Accommodation Request - CA/NV";
            this.FMLAButton5.Name = "FMLAButton5";
            this.FMLAButton5.ShowImage = true;
            this.FMLAButton5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton5_Click);
            // 
            // FMLAButton6
            // 
            this.FMLAButton6.Label = "ADA - Leave Request - CA/NV";
            this.FMLAButton6.Name = "FMLAButton6";
            this.FMLAButton6.ShowImage = true;
            this.FMLAButton6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton6_Click);
            // 
            // FMLAButton7
            // 
            this.FMLAButton7.Label = "ADA - Pregnancy Leave Request - NV";
            this.FMLAButton7.Name = "FMLAButton7";
            this.FMLAButton7.ShowImage = true;
            this.FMLAButton7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton7_Click);
            // 
            // FMLAButton8
            // 
            this.FMLAButton8.Label = "ADA - Leave Designation - CB/NV";
            this.FMLAButton8.Name = "FMLAButton8";
            this.FMLAButton8.ShowImage = true;
            this.FMLAButton8.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton8_Click);
            // 
            // FMLAButton9
            // 
            this.FMLAButton9.Label = "FMLA/CFRA/PDL - Leave Designation - CB";
            this.FMLAButton9.Name = "FMLAButton9";
            this.FMLAButton9.ShowImage = true;
            this.FMLAButton9.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton9_Click);
            // 
            // FMLAButton10
            // 
            this.FMLAButton10.Label = "FMLA/CFRA/PDL - Unexcused Absences";
            this.FMLAButton10.Name = "FMLAButton10";
            this.FMLAButton10.ShowImage = true;
            this.FMLAButton10.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FMLAButton10_Click);
            // 
            // InfoRequests
            // 
            this.InfoRequests.Items.Add(this.InfoMenu);
            this.InfoRequests.Label = "Requesting Information";
            this.InfoRequests.Name = "InfoRequests";
            // 
            // InfoMenu
            // 
            this.InfoMenu.Items.Add(this.RequestsButton1);
            this.InfoMenu.Items.Add(this.RequestsButton2);
            this.InfoMenu.Items.Add(this.RequestsButton3);
            this.InfoMenu.Label = "Requests";
            this.InfoMenu.Name = "InfoMenu";
            // 
            // RequestsButton1
            // 
            this.RequestsButton1.Label = "FMLA/CFRA - Leave Information Request - CA";
            this.RequestsButton1.Name = "RequestsButton1";
            this.RequestsButton1.ShowImage = true;
            this.RequestsButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RequestsButton1_Click);
            // 
            // RequestsButton2
            // 
            this.RequestsButton2.Label = "FMLA - Leave Information Request - NV";
            this.RequestsButton2.Name = "RequestsButton2";
            this.RequestsButton2.ShowImage = true;
            this.RequestsButton2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RequestsButton2_Click);
            // 
            // RequestsButton3
            // 
            this.RequestsButton3.Label = "ADA - Leave Accommodation Information Request - CA/NV";
            this.RequestsButton3.Name = "RequestsButton3";
            this.RequestsButton3.ShowImage = true;
            this.RequestsButton3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RequestsButton3_Click);
            // 
            // TemplateTab
            // 
            this.Name = "TemplateTab";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.HRTemplateTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.TemplateTab_Load);
            this.HRTemplateTab.ResumeLayout(false);
            this.HRTemplateTab.PerformLayout();
            this.ChangeButtons.ResumeLayout(false);
            this.ChangeButtons.PerformLayout();
            this.LeaveRequests.ResumeLayout(false);
            this.LeaveRequests.PerformLayout();
            this.FMLAADA.ResumeLayout(false);
            this.FMLAADA.PerformLayout();
            this.InfoRequests.ResumeLayout(false);
            this.InfoRequests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab HRTemplateTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ChangeButtons;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu ChangeMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton7;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LeaveRequests;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu LeaveMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton7;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup FMLAADA;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu FMLAMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton9;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup InfoRequests;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu InfoMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RequestsButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RequestsButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RequestsButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FMLAButton10;
    }

    partial class ThisRibbonCollection
    {
        internal TemplateTab TemplateTab
        {
            get { return this.GetRibbon<TemplateTab>(); }
        }
    }
}
