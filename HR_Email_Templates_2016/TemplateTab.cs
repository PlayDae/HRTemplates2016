using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace HR_Email_Templates_2016
{
    public partial class TemplateTab
    {
        Outlook.Application Application = new Outlook.Application();

        string templatePath = "C:\\OutlookTemplates\\";

        private void TemplateTab_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void ChangeButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "NewHire.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void ChangeButton2_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "PositionChange.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void ChangeButton3_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "Conversion.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void ChangeButton4_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "NameChange.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void ChangeButton5_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "DeptChange.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void ChangeButton6_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "RegularWorkerSeparation.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void ChangeButton7_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "TempWorkerSeparation.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void LeaveButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "LoADeparture.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void LeaveButton2_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "LoAReturn.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void LeaveButton3_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "Intermittent_Leave_Request_CA_NV.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void LeaveButton4_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "BereavementRequest.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void LeaveButton5_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "Pregnancy_Leave_Request_CA.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void LeaveButton6_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "JuryDuty.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void LeaveButton7_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "ReturnToWork.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "FMLA_CFRA_Request_for_Leave_CA.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton2_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "FMLA_Pregnancy_Leave_NV.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton3_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "FMLA_Request_for_Leave_NV.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton4_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "Leave_Designation_NV_FMLA.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton5_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "ADA_Accommodation_Request_CA_NV.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton6_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "ADA_Leave_Request_CA_NV.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton7_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "ADA_Pregnancy_Leave_Request_NV.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton8_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "Leave_Designation_CB_NV_ADA.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton9_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "Leave_Designation_CB_FMLACFRAPDL.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void FMLAButton10_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "UnexcusedAbsences_under_FMLACFRAPDL.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void RequestsButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "InformationRequest_CA_FMLACFRA_Leave.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void RequestsButton2_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "InformationRequest_NV_FMLA_Leave.oft", folder) as Outlook.MailItem;
            mail.Display();
        }

        private void RequestsButton3_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Folder folder = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            Outlook.MailItem mail = Application.CreateItemFromTemplate(@templatePath + "InformationRequest_CA_NV_ADA_Leave_Accommodation.oft", folder) as Outlook.MailItem;
            mail.Display();
        }
    }
}
