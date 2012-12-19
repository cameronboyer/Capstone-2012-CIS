using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace DTI_Schedule
{
    public partial class JobTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                string level = (string)(Session["level"]);

                if (String.IsNullOrEmpty(level))
                {
                    Response.Redirect("/Account/Login.aspx");
                }

                if (!level.Equals("Employee") && !level.Equals("4"))
                {
                    Response.Redirect("/Account/Login.aspx");
                }

               
                
               
            }
            
        }


      


        protected void addScanJob_Click(object sender, EventArgs e)
        {

            //hide navbuttons
            navButtonsTable.Visible = false;

            scanJob.SetActiveView(S_clientInfo);
        }

        protected void addCopyButton_Click(object sender, EventArgs e)
        {
            //hide navbuttons
            navButtonsTable.Visible = false;

            copyJob.SetActiveView(C_clientInfo);
        }

        protected void S_addNext_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_naming);
        }

        protected void S_toDocumentLevel_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_documentLevel);
        }

        protected void S_goToGrouping_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_grouping);
        }

        protected void S_documentLevelCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < S_documentLevelRadioButtonList.Items.Count; i++)
            {
                if (S_documentLevelRadioButtonList.SelectedIndex == 5)
                {
                    S_otherDocumentLevelTextBox.Visible = true;
                }
                else
                    S_otherDocumentLevelTextBox.Visible = false;
            }
        }

        protected void S_groupingCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_groupingRadioButtonList.SelectedValue == "Other")
            {
                S_otherGroupingTextBox.Visible = true;
            }
            else
                S_otherGroupingTextBox.Visible = false;
        }

        protected void S_goToScanning_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_scanning);
        }

        protected void S_goToMedia_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_mediaView);
        }

        protected void S_postitNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_postitNotes.SelectedValue == "yes")
            {
                S_postItNoteInstruction.Visible = true;
            }
            else
                S_postItNoteInstruction.Visible = false;
        }

        protected void S_reduceToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (S_reduceToCheckBox.Checked)
            {
                S_reduceToRadioButtonList.Visible = true;
                S_reduceToRadioButtonList_SelectedIndexChanged(sender, e);
            }
            else
            {
                S_reduceToRadioButtonList.Visible = false;
                S_reduceToOtherTextBox.Visible = false;
            }
        }

        protected void S_reduceToRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_reduceToRadioButtonList.SelectedValue == "other")
            {
                S_reduceToOtherTextBox.Visible = true;
            }
            else
                S_reduceToOtherTextBox.Visible = false;
        }

        protected void S_duplicateAndTagMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_duplicateAndTagMedia.SelectedValue == "yes")
            {
                S_numberOfDuplicatesTextBox.Visible = true;
            }
            else
                S_numberOfDuplicatesTextBox.Visible = false;
        }

        protected void S_goToDeliverable_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_deliverable);
        }

        protected void S_gotoIndexingInstructions_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_indexingInstructions);
        }

        protected void S_goToEBS_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_ebsInstructions);
        }

        protected void S_deliverables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_deliverables.SelectedValue == "pdf")
            {
                S_pdfPer.Visible = true;
            }
            else
            {
                S_pdfPer.Visible = false;
            }
        }

        protected void S_pdfPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_pdfPer.SelectedValue == "other")
            {
                S_pdfPerTextBox.Visible = true;
            }
            else
                S_pdfPerTextBox.Visible = false;
        }

        protected void S_ebsOptionsRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_ebsOptionsRadioButtonList.SelectedValue == "yes")
            {
                S_ebsNumberingRadioButtonList.Visible = true;
                S_ebsLocationLabel.Visible = true;
                S_ebsLocationsRadioButtonList.Visible = true;
                S_ebsAdditionalLines.Visible = true;
                S_ebsAddtionalLinesRadioButtonList.Visible = true;
                S_ebsSizeOptionLabel.Visible = true;
                S_ebsOptionSizeDropDownBox.Visible = true;
                S_ebsFontOptionLabel.Visible = true;
                S_ebsOptionFontDropDownList.Visible = true;
                S_ebsFontOptionStyleDropDownList.Visible = true;
            }
            else
            {
                S_ebsNumberingRadioButtonList.Visible = false;
                S_ebsLocationLabel.Visible = false;
                S_ebsLocationsRadioButtonList.Visible = false;
                S_ebsAdditionalLines.Visible = false;
                S_ebsAddtionalLinesRadioButtonList.Visible = false;
                S_ebsSizeOptionLabel.Visible = false;
                S_ebsOptionSizeDropDownBox.Visible = false;
                S_ebsFontOptionLabel.Visible = false;
                S_ebsOptionFontDropDownList.Visible = false;
                S_ebsFontOptionStyleDropDownList.Visible = false;
            }
        }

        protected void S_ebsNumberingRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_ebsNumberingRadioButtonList.SelectedValue == "ebsOther")
            {
                S_ebsOtherPrefixTextBox.Visible = true;
                S_ebsOtherStartNumberTextBox.Visible = true;
                S_ebsOtherSuffixTextBox.Visible = true;
                S_ebsOtherNewControlNumberLabel.Visible = true;
                S_ebsOtherControlNumberTextBox.Visible = true;
            }
            else
            {
                S_ebsOtherPrefixTextBox.Visible = false;
                S_ebsOtherStartNumberTextBox.Visible = false;
                S_ebsOtherSuffixTextBox.Visible = false;
                S_ebsOtherNewControlNumberLabel.Visible = false;
                S_ebsOtherControlNumberTextBox.Visible = false;
            }
        }

        protected void S_ebsOtherPrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (S_ebsOtherPrefixTextBox.Text != null || S_ebsOtherPrefixTextBox.Text != "" || S_ebsOtherPrefixTextBox.Text != "Prefix for EBS")
            {
                S_ebsOtherControlNumberTextBox.Text = S_ebsOtherPrefixTextBox.Text;
            }
        }

        protected void S_ebsOtherStartNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (S_ebsOtherPrefixTextBox.Text != null || S_ebsOtherPrefixTextBox.Text != "" || S_ebsOtherPrefixTextBox.Text != "Prefix for EBS" || S_ebsOtherStartNumberTextBox.Text != null || S_ebsOtherStartNumberTextBox.Text != "" || S_ebsOtherStartNumberTextBox.Text != "Starting Number for EBS")
            {
                S_ebsOtherControlNumberTextBox.Text = S_ebsOtherPrefixTextBox.Text + S_ebsOtherStartNumberTextBox.Text;
            }
        }

        protected void S_ebsOtherSuffixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (S_ebsOtherPrefixTextBox.Text != null || S_ebsOtherPrefixTextBox.Text != "" || S_ebsOtherPrefixTextBox.Text != "Prefix for EBS" || S_ebsOtherStartNumberTextBox.Text != null || S_ebsOtherStartNumberTextBox.Text != "" || S_ebsOtherStartNumberTextBox.Text != "Starting Number for EBS" || S_ebsOtherSuffixTextBox.Text != null || S_ebsOtherSuffixTextBox.Text != "" || S_ebsOtherSuffixTextBox.Text != "Suffix for EBS")
            {
                S_ebsOtherControlNumberTextBox.Text = S_ebsOtherPrefixTextBox.Text + S_ebsOtherStartNumberTextBox.Text + S_ebsOtherSuffixTextBox.Text;
            }
        }

        protected void S_goToCdBurningButton_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_cdBurning);
        }

        protected void S_cdBurnCopiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_cdBurnCopiesFirmOneDropDown.SelectedIndex > 0 || S_cdBurnCopiesFirmTwoDropDown.SelectedIndex > 0 || S_cdBurnCopiesFirmThreeDropDown.SelectedIndex > 0)
            {
                cdLabel.Visible = true;
                S_goToPrinting.Visible = false;
                S_goToPrinting2.Visible = true;
                S_backToEBS.Visible = false;
                S_backToEBS2.Visible = true;
            }
            else
            {
                cdLabel.Visible = false;
                S_goToPrinting.Visible = true;
                S_goToPrinting2.Visible = false;
                S_backToEBS.Visible = true;
                S_backToEBS2.Visible = false;
            }
        }

        protected void S_goToPrinting_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_printing);
        }

        protected void S_printAccoRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_printAccoRadioButtonList.SelectedValue == "yes")
            {
                S_printAccoSideRadioButtonList.Visible = true;
                S_printDrillingRadioButtonList.SelectedValue = "yes";
                S_printDrillingOptionRadioButton.SelectedValue = "2Hole";
            }
            else
            {
                S_printAccoSideRadioButtonList.Visible = false;
                S_printDrillingRadioButtonList.SelectedValue = "no";
                S_printDrillingOptionRadioButton.SelectedValue = "3Hole";
            }
        }

        protected void S_printBindersOptionRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_printBindersOptionRadioButtonList.SelectedValue == "yes")
            {
                S_printBindersSizeRadioButtonList.Visible = true;
                S_printBinderOptionViewRadioBttonList.Visible = true;
            }
            else
            {
                S_printBindersSizeRadioButtonList.Visible = false;
                S_printBinderOptionViewRadioBttonList.Visible = false;
            }
        }

        protected void S_ebsAddtionalLinesRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_ebsAddtionalLinesRadioButtonList.SelectedValue == "yes")
            {
                S_ebsOptionAdditionalLinesSizeLimitLabel.Visible = true;
                S_ebsOptionAdditionalLinesLineOneLabel.Visible = true;
                S_ebsOptionAdditionalLinesLineOneTextBox.Visible = true;
                S_ebsOptionAdditionalLinesLineTwoLabel.Visible = true;
                S_ebsOptionAdditionalLinesLineTwoTextBox.Visible = true;
            }
            else
            {
                S_ebsOptionAdditionalLinesSizeLimitLabel.Visible = false;
                S_ebsOptionAdditionalLinesLineOneLabel.Visible = false;
                S_ebsOptionAdditionalLinesLineOneTextBox.Visible = false;
                S_ebsOptionAdditionalLinesLineTwoLabel.Visible = false;
                S_ebsOptionAdditionalLinesLineTwoTextBox.Visible = false;
            }
        }

        protected void S_specialInstrctionsPrintRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_specialInstrctionsPrintRadioButtonList.SelectedValue == "yes")
            {
                S_specialInstrctionsPrintTextBox.Visible = true;
            }
            else
            {
                S_specialInstrctionsPrintTextBox.Visible = false;
            }
        }

        protected void S_pickAndChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (S_pickAndChoose.Checked)
            {
                S_specialInstructionsPickAndChooseLabel.Visible = true;
                S_specialInstructionsPickAndChooseTextBox.Visible = true;
            }
            else
            {
                S_specialInstructionsPickAndChooseLabel.Visible = false;
                S_specialInstructionsPickAndChooseTextBox.Visible = false;
            }
        }

        protected void S_reincrementingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (S_reincrementingCheckBox.Checked)
            {
                S_reincrementingRadioList.Visible = true;
            }
            else
            {
                S_reincrementingRadioList.Visible = false;
            }
        }

        protected void S_spaceInControlNumberRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_spaceInControlNumberRadioButtonList.SelectedValue == "yes")
            {
                S_spaceInControlNumberInfoLabel.Visible = true;
            }
            else
            {
                S_spaceInControlNumberInfoLabel.Visible = false;
            }
        }

        protected void C_toCopying_Click(object sender, EventArgs e)
        {
            copyJob.SetActiveView(C_copyingInstrcutions);
        }

        protected void C_goToSpecialInstructions_Click(object sender, EventArgs e)
        {
            copyJob.SetActiveView(C_specialInstructions);
        }

        protected void D_toNamingPage_Click(object sender, EventArgs e)
        {
            dataJob.SetActiveView(D_naming);
        }

        protected void D_toDeliverables_Click(object sender, EventArgs e)
        {
            dataJob.SetActiveView(D_deliverable);
        }

        protected void D_gotoEBSInstructions_Click(object sender, EventArgs e)
        {
            dataJob.SetActiveView(D_ebsInstructions);
        }

        protected void D_goToCdBurningButton_Click(object sender, EventArgs e)
        {
            dataJob.SetActiveView(D_cdBurning);
        }

        protected void D_goToPrinting_Click(object sender, EventArgs e)
        {
            dataJob.SetActiveView(D_printing);
        }

        protected void D_goToSpecialInstructions_Click(object sender, EventArgs e)
        {
            dataJob.SetActiveView(D_specialInstructions);
        }

        protected void C_pickAndChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (C_pickAndChoose.Checked)
            {
                C_specialInstructionsPickAndChooseLabel.Visible = true;
                C_specialInstructionsPickAndChooseTextBox.Visible = true;
            }
            else
            {
                C_specialInstructionsPickAndChooseLabel.Visible = false;
                C_specialInstructionsPickAndChooseTextBox.Visible = false;
            }
        }

        protected void C_postitNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_postitNotes.SelectedValue == "yes")
            {
                C_postItNoteInstruction.Visible = true;
            }
            else
            {
                C_postItNoteInstruction.Visible = false;
            }
        }

        protected void C_reduceToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (C_reduceToCheckBox.Checked)
            {
                C_reduceToRadioButtonList.Visible = true;
                C_oversizeDocLabel.Visible = true;
                C_oversizeDocRadioButtonList.Visible = true;
            }
            else if (C_enlargeToCheckBox.Checked)
            {
            }
            else
            {
                C_reduceToRadioButtonList.Visible = false;
                C_reduceToOtherTextBox.Visible = false;
                C_oversizeDocLabel.Visible = false;
                C_oversizeDocRadioButtonList.Visible = false;
            }
        }

        protected void C_reduceToRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_reduceToRadioButtonList.SelectedValue == "other")
            {
                C_reduceToOtherTextBox.Visible = true;
            }
            else
            {
                C_reduceToOtherTextBox.Visible = false;
            }
        }

        protected void D_spaceInControlNumberRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_spaceInControlNumberRadioButtonList.SelectedValue == "yes")
            {
                D_spaceInControlNumberInfoLabel.Visible = true;
            }
            else
            {
                D_spaceInControlNumberInfoLabel.Visible = false;
            }
        }

        protected void D_reincrementingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (D_reincrementingCheckBox.Checked)
            {
                D_reincrementingRadioList.Visible = true;
            }
            else
            {
                D_reincrementingRadioList.Visible = false;
            }
        }

        protected void D_pdfPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_pdfPer.SelectedValue == "other")
            {
                D_pdfPerTextBox.Visible = true;
            }
            else
            {
                D_pdfPerTextBox.Visible = false;
            }
        }

        protected void D_deliverables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_deliverables.SelectedValue == "pdf")
            {
                D_pdfPer.Visible = true;
            }
            else
            {
                D_pdfPer.Visible = false;
            }
            if (D_deliverables.SelectedValue == "other")
            {
                D_deliverablesOtherTextBox.Visible = true;
            }
            else
            {
                D_deliverablesOtherTextBox.Visible = false;
            }
        }

        protected void D_ebsOptionsRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_ebsOptionsRadioButtonList.SelectedValue == "yes")
            {
                D_ebsNumberingRadioButtonList.Visible = true;
                D_ebsLocationLabel.Visible = true;
                D_ebsLocationsRadioButtonList.Visible = true;
                D_ebsAdditionalLines.Visible = true;
                D_ebsAddtionalLinesRadioButtonList.Visible = true;
                D_ebsSizeOptionLabel.Visible = true;
                D_ebsOptionSizeDropDownBox.Visible = true;
                D_ebsFontOptionLabel.Visible = true;
                D_ebsOptionFontDropDownList.Visible = true;
                D_ebsFontOptionStyleDropDownList.Visible = true;
            }
            else
            {
                D_ebsNumberingRadioButtonList.Visible = false;
                D_ebsLocationLabel.Visible = false;
                D_ebsLocationsRadioButtonList.Visible = false;
                D_ebsAdditionalLines.Visible = false;
                D_ebsAddtionalLinesRadioButtonList.Visible = false;
                D_ebsSizeOptionLabel.Visible = false;
                D_ebsOptionSizeDropDownBox.Visible = false;
                D_ebsFontOptionLabel.Visible = false;
                D_ebsOptionFontDropDownList.Visible = false;
                D_ebsFontOptionStyleDropDownList.Visible = false;
            }
        }

        protected void D_ebsNumberingRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_ebsNumberingRadioButtonList.SelectedValue == "ebsOther")
            {
                D_ebsOtherPrefixTextBox.Visible = true;
                D_ebsOtherStartNumberTextBox.Visible = true;
                D_ebsOtherSuffixTextBox.Visible = true;
                D_ebsOtherNewControlNumberLabel.Visible = true;
                D_ebsOtherControlNumberTextBox.Visible = true;
            }
            else
            {
                D_ebsOtherPrefixTextBox.Visible = false;
                D_ebsOtherStartNumberTextBox.Visible = false;
                D_ebsOtherSuffixTextBox.Visible = false;
                D_ebsOtherNewControlNumberLabel.Visible = false;
                D_ebsOtherControlNumberTextBox.Visible = false;
            }
        }

        protected void D_ebsOtherPrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (D_ebsOtherPrefixTextBox.Text != null || D_ebsOtherPrefixTextBox.Text != "" || D_ebsOtherPrefixTextBox.Text != "Prefix for EBS")
            {
                D_ebsOtherControlNumberTextBox.Text = D_ebsOtherPrefixTextBox.Text;
            }
        }

        protected void D_ebsOtherStartNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (D_ebsOtherPrefixTextBox.Text != null || D_ebsOtherPrefixTextBox.Text != "" || D_ebsOtherPrefixTextBox.Text != "Prefix for EBS" || D_ebsOtherStartNumberTextBox.Text != null || D_ebsOtherStartNumberTextBox.Text != "" || D_ebsOtherStartNumberTextBox.Text != "Starting Number for EBS")
            {
                D_ebsOtherControlNumberTextBox.Text = D_ebsOtherPrefixTextBox.Text + D_ebsOtherStartNumberTextBox.Text;
            }
        }

        protected void D_ebsOtherSuffixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (D_ebsOtherPrefixTextBox.Text != null || D_ebsOtherPrefixTextBox.Text != "" || D_ebsOtherPrefixTextBox.Text != "Prefix for EBS" || D_ebsOtherStartNumberTextBox.Text != null || D_ebsOtherStartNumberTextBox.Text != "" || D_ebsOtherStartNumberTextBox.Text != "Starting Number for EBS" || D_ebsOtherSuffixTextBox.Text != null || D_ebsOtherSuffixTextBox.Text != "" || D_ebsOtherSuffixTextBox.Text != "Suffix for EBS")
            {
                D_ebsOtherControlNumberTextBox.Text = D_ebsOtherPrefixTextBox.Text + D_ebsOtherStartNumberTextBox.Text + D_ebsOtherSuffixTextBox.Text;
            }
        }

        protected void D_ebsAddtionalLinesRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_ebsAddtionalLinesRadioButtonList.SelectedValue == "yes")
            {
                D_ebsOptionAdditionalLinesSizeLimitLabel.Visible = true;
                D_ebsOptionAdditionalLinesLineOneLabel.Visible = true;
                D_ebsOptionAdditionalLinesLineOneTextBox.Visible = true;
                D_ebsOptionAdditionalLinesLineTwoLabel.Visible = true;
                D_ebsOptionAdditionalLinesLineTwoTextBox.Visible = true;
            }
            else
            {
                D_ebsOptionAdditionalLinesSizeLimitLabel.Visible = false;
                D_ebsOptionAdditionalLinesLineOneLabel.Visible = false;
                D_ebsOptionAdditionalLinesLineOneTextBox.Visible = false;
                D_ebsOptionAdditionalLinesLineTwoLabel.Visible = false;
                D_ebsOptionAdditionalLinesLineTwoTextBox.Visible = false;
            }
        }

        protected void D_cdBurnCopiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_cdBurnCopiesFirmOneDropDown.SelectedIndex > 0 || D_cdBurnCopiesFirmTwoDropDown.SelectedIndex > 0 || D_cdBurnCopiesFirmThreeDropDown.SelectedIndex > 0)
            {
                cdLabel.Visible = true;
                D_goToPrinting.Visible = false;
                D_goToPrinting2.Visible = true;
            }
            else
            {
                cdLabel.Visible = false;
                D_goToPrinting.Visible = true;
                D_goToPrinting2.Visible = false;
            }
        }

        protected void D_printAccoRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_printAccoRadioButtonList.SelectedValue == "yes")
            {
                D_printAccoSideRadioButtonList.Visible = true;
                D_printDrillingRadioButtonList.SelectedValue = "yes";
                D_printDrillingOptionRadioButton.SelectedValue = "2Hole";
            }
            else
            {
                D_printAccoSideRadioButtonList.Visible = false;
                D_printDrillingRadioButtonList.SelectedValue = "no";
                D_printDrillingOptionRadioButton.SelectedValue = "3Hole";
            }
        }

        protected void D_printBindersOptionRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_printBindersOptionRadioButtonList.SelectedValue == "yes")
            {
                D_printBindersSizeRadioButtonList.Visible = true;
                D_printBinderOptionViewRadioBttonList.Visible = true;
            }
            else
            {
                D_printBindersSizeRadioButtonList.Visible = false;
                D_printBinderOptionViewRadioBttonList.Visible = false;
            }
        }

        protected void D_specialInstrctionsPrintRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D_specialInstrctionsPrintRadioButtonList.SelectedValue == "yes")
            {
                D_specialInstrctionsPrintTextBox.Visible = true;
            }
            else
            {
                D_specialInstrctionsPrintTextBox.Visible = false;
            }
        }

        protected void P_printAccoRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P_printAccoRadioButtonList.SelectedValue == "yes")
            {
                P_printAccoSideRadioButtonList.Visible = true;
                P_printDrillingRadioButtonList.SelectedValue = "yes";
                P_printDrillingOptionRadioButton.SelectedValue = "2Hole";
            }
            else
            {
                P_printAccoSideRadioButtonList.Visible = false;
                P_printDrillingRadioButtonList.SelectedValue = "no";
                P_printDrillingOptionRadioButton.SelectedValue = "3Hole";
            }
        }

        protected void P_printBindersOptionRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P_printBindersOptionRadioButtonList.SelectedValue == "yes")
            {
                P_printBindersSizeRadioButtonList.Visible = true;
                P_printBinderOptionViewRadioBttonList.Visible = true;
            }
            else
            {
                P_printBindersSizeRadioButtonList.Visible = false;
                P_printBinderOptionViewRadioBttonList.Visible = false;
            }
        }

        protected void P_specialInstrctionsPrintRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P_specialInstrctionsPrintRadioButtonList.SelectedValue == "yes")
            {
                P_specialInstrctionsPrintTextBox.Visible = true;
            }
            else
            {
                P_specialInstrctionsPrintTextBox.Visible = false;
            }
        }

        protected void addDataButton_Click(object sender, EventArgs e)
        {
            dataJob.SetActiveView(D_clientInfo);
            navButtonsTable.Visible = false;
        }

        protected void addPrintButton_Click(object sender, EventArgs e)
        {
            printJob.SetActiveView(P_clientInfo);
            navButtonsTable.Visible = false;
        }

        protected void P_toPrinting_Click(object sender, EventArgs e)
        {
            printJob.SetActiveView(P_printing);
        }

        protected void P_goToSpecialInstructions_Click(object sender, EventArgs e)
        {
            printJob.SetActiveView(P_specialInstructions);
        }

        protected void C_enlargeToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (C_enlargeToCheckBox.Checked)
            {
                C_enlargeToRadioButtonList.Visible = true;
                C_oversizeDocLabel.Visible = true;
                C_oversizeDocRadioButtonList.Visible = true;
            }
            else if (C_reduceToCheckBox.Checked)
            {
            }
            else
            {
                C_enlargeToRadioButtonList.Visible = false;
                C_enlargeToOtherTextBox.Visible = false;
                C_oversizeDocLabel.Visible = false;
                C_oversizeDocRadioButtonList.Visible = false;
            }
        }

        protected void C_enlargeToRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_enlargeToRadioButtonList.SelectedValue == "other")
            {
                C_enlargeToOtherTextBox.Visible = true;
            }
            else
            {
                C_enlargeToOtherTextBox.Visible=false;
            }
        }

        protected void S_goToSpecialInstructions_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_specialInstructions);
        }
        
        protected void S_backToClient_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_clientInfo);
	    }
	
	    protected void S_backToNaming_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_naming);
	    }
	
	    protected void S_backToDocLevel_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_documentLevel);
	    }
	
	    protected void S_backToGrouping_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_grouping);
	    }
	
	    protected void S_backToScanning_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_scanning);
	    }
	
	    protected void S_backToMedia_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_mediaView);
	    }
	
	    protected void S_backToDeliverables_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_deliverable);
	    }
	
	    protected void S_backToIndexing_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_indexingInstructions);
	    }
	
	    protected void S_backToEBS_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_ebsInstructions);
	    }
	
	    protected void S_backToCD_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_cdBurning);
	    }
	
	    protected void S_backToPrinting_Click(object sender, EventArgs e)
	    {
	        scanJob.SetActiveView(S_printing);
	    }
	
	    protected void C_backToClientInfo_Click(object sender, EventArgs e)
	    {
	        copyJob.SetActiveView(C_clientInfo);
	    }
	
	    protected void C_backToCopying_Click(object sender, EventArgs e)
	    {
	        copyJob.SetActiveView(C_copyingInstrcutions);
	    }
	
	    protected void D_backToClient_Click(object sender, EventArgs e)
	    {
	        dataJob.SetActiveView(D_clientInfo);
	    }
	
	    protected void D_backToNaming_Click(object sender, EventArgs e)
	    {
	        dataJob.SetActiveView(D_naming);
	    }
	
	    protected void D_backToDeliverables_Click(object sender, EventArgs e)
	    {
	        dataJob.SetActiveView(D_deliverable);
	    }
	
	    protected void D_backToEBS_Click(object sender, EventArgs e)
	    {
	        dataJob.SetActiveView(D_ebsInstructions);
	    }
	
	    protected void D_backToCD_Click(object sender, EventArgs e)
	    {
	        dataJob.SetActiveView(D_cdBurning);
	    }
	
	    protected void D_backToPrinting_Click(object sender, EventArgs e)
	    {
	        dataJob.SetActiveView(D_printing);
	    }
	
	    protected void P_backToPrinting_Click(object sender, EventArgs e)
	    {
	        printJob.SetActiveView(P_printing);
	    }

        protected void S_contactNameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void S_clientNameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            S_cdBurnInfoFirmOneTextBox.Text = S_clientNameDropDown.SelectedItem.ToString();

            string connString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "SELECT address, phoneNumber FROM Clients WHERE clientID = @clientID";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                cmd.Parameters.Add("@clientID", System.Data.SqlDbType.VarChar, (50));
                cmd.Parameters["@clientID"].Value = S_clientNameDropDown.SelectedValue;

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    S_addressTextBox.Text = rdr[0].ToString();
                    S_phoneNumberTextBox.Text = rdr[1].ToString();
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conn.Close();
            }

        }

        protected void S_clientNameDropDown_DataBound(object sender, EventArgs e)
        {
            S_clientNameDropDown_SelectedIndexChanged(sender, e);
        }

        protected void S_clientNameDropDown_Load(object sender, EventArgs e)
        {
            S_clientNameDropDown_SelectedIndexChanged(sender, e);
        }

        protected void S_clientNameDropDown_DataBinding(object sender, EventArgs e)
        {
            S_clientNameDropDown_SelectedIndexChanged(sender, e);
        }

        protected void S_addToDataBase_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                cmd.Parameters.Add("@contactName", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@clientMatter", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingPrefix", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingBox", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingIncrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingReincrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingSpace", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@volumeName", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@documentLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@groupingLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@pickAndChoose", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@scanAllPortrait", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@covers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldCovers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dividerTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@postItNotes", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@coloredSheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@binderSpines", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@envelopes", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@standardLang", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@carbon", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@reduceTo", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@anyAllColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@highlights", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosFront", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosBack", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorCopies", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@handwrittenColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printingPressColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@chartsGraphs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorHandStamp", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@oversized", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@scanAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dupeAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@bateLabelAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@deliverable", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@viewer", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTextOne", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextOneDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextOnePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextTwo", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextTwoDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextTwoPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextThree", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextThreeDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextThreePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFour", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFourDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFourPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFive", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFiveDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFiveDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFivePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSix", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSixDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSixDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSixPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSeven", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSevenDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSevenDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSevenPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextEight", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextEightDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextEightDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextEightPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTagOne", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOneDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagTwo", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagTwoDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagThree", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagThreeDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagFour", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagFourDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagColor", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagColorDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagColorDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagOversized", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOversizedDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOversizedDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagMedia", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagMediaDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagMediaDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebs", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@ebsControlNumberPrefix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberStarting", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberSuffix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsLocation", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@ebsSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@ebsFont", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsFontStyle", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsAdditionalLinesOne", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@ebsAdditionalLinesTwo", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@dvd", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@duplicateClientLabel", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOne", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmOneNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmOneTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwo", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmTwoNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmTwoTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThree", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmThreeNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmThreeTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdCase", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@batesRange", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdClientMatter", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@notes", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@printCleanSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printEBSEDSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printBarCodeSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@binder", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@binderView", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoHole", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@gpcBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@veloBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@sprialBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@matchOriginals", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@drilling", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoSided", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorForColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@slipsheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@staplePerDoc", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printSpecialInstructions", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsProduction", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsData", System.Data.SqlDbType.VarChar);

                cmd.Parameters.Add("@ebsSelectionNumbering", System.Data.SqlDbType.VarChar, 3);

                cmd.Parameters.Add("@deliverableMainRadio", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@deliverablePDFRadio", System.Data.SqlDbType.VarChar, 25);
                


                cmd.Parameters["@contactName"].Value = S_clientNameDropDown.SelectedValue;
                if (S_clientMatterTextBox.Text != "" || S_clientMatterTextBox.Text != null)
                {
                    cmd.Parameters["@clientMatter"].Value = S_clientMatterTextBox.Text;
                }
                else
                {
                    cmd.Parameters["@clientMatter"].Value = null;
                }
                if (S_controlNumberPrefixTxt.Text != "" || S_controlNumberPrefixTxt.Text != null)
                {
                    cmd.Parameters["@namingPrefix"].Value = S_controlNumberPrefixTxt.Text;
                }
                else
                {
                    cmd.Parameters["@namingPrefix"].Value = "";
                }
                if (S_controlNumberBoxTxt.Text != "" || S_controlNumberBoxTxt.Text != null)
                {
                    cmd.Parameters["@namingBox"].Value = S_controlNumberBoxTxt.Text;
                }
                else
                {
                    cmd.Parameters["@namingBox"].Value = "";
                }
                if (S_conrolNumberIncrementingNumberTxt.Text != "" || S_conrolNumberIncrementingNumberTxt.Text != null)
                {
                    cmd.Parameters["@namingIncrementing"].Value = S_conrolNumberIncrementingNumberTxt.Text;
                }
                else
                {
                    cmd.Parameters["@namingIncrementing"].Value = "";
                }
                if (S_reincrementingCheckBox.Checked)
                {
                    cmd.Parameters["@namingReincrementing"].Value = S_reincrementingRadioList.SelectedValue;
                }
                else
                {
                    cmd.Parameters["@namingReincrementing"].Value = null;
                }
                if (S_spaceInControlNumberRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@namingSpace"].Value = "yes";
                }
                else
                {
                    cmd.Parameters["@namingSpace"].Value = null;
                }
                if (S_volumeTextBox.Text != "" || S_volumeTextBox.Text != null)
                {
                    cmd.Parameters["@volumeName"].Value = S_volumeTextBox.Text;
                }
                else
                {
                    cmd.Parameters["@volumeName"].Value = null;
                }
                cmd.Parameters["@documentLevel"].Value = S_documentLevelRadioButtonList.SelectedValue;
                cmd.Parameters["@groupingLevel"].Value = S_groupingRadioButtonList.SelectedValue;
                if (S_pickAndChoose.Checked)
                {
                    cmd.Parameters["@pickAndChoose"].Value = S_specialInstructionsPickAndChooseTextBox.Text;
                }
                if (S_scanAllPortrait.Checked)
                {
                    cmd.Parameters["@scanAllPortrait"].Value = "yes";
                }
                if (S_coversRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@covers"].Value = "yes";
                }
                if (S_redweldFolderCovers.SelectedValue == "yes")
                {
                    cmd.Parameters["@redweldCovers"].Value = "yes";
                }
                if (S_redweldFolderTabs.SelectedValue == "yes")
                {
                    cmd.Parameters["@redweldTabs"].Value = "yes";
                }
                if (S_dividerTabs.SelectedValue == "yes")
                {
                    cmd.Parameters["@dividerTabs"].Value = "yes";
                }
                if (S_postitNotes.SelectedValue == "yes")
                {
                    cmd.Parameters["@postItNotes"].Value = S_postItNoteInstruction.SelectedValue;
                }
                if (S_coloredSheets.SelectedValue == "yes")
                {
                    cmd.Parameters["@coloredSheets"].Value = "yes";
                }
                if (S_binderSpines.SelectedValue == "yes")
                {
                    cmd.Parameters["@binderSpines"].Value = "yes";
                }
                if (S_envelopes.SelectedValue == "yes")
                {
                    cmd.Parameters["@envelopes"].Value = "yes";
                }
                if (S_standardLang.SelectedValue == "yes")
                {
                    cmd.Parameters["@standardLang"].Value = "yes";
                }
                if (S_carbon.SelectedValue == "yes")
                {
                    cmd.Parameters["@carbon"].Value = "yes";
                }
                if (S_reduceToCheckBox.Checked)
                {
                    if (S_reduceToRadioButtonList.SelectedValue == "other")
                    {
                        if (S_reduceToOtherTextBox.Text == "" || S_reduceToOtherTextBox.Text == null)
                        {
                            cmd.Parameters["@reduceTo"].Value = null;
                        }
                        else
                        {
                            cmd.Parameters["@reduceTo"].Value = S_reduceToOtherTextBox.Text;
                        }
                    }
                    else
                    {
                        cmd.Parameters["@reduceTo"].Value = S_reduceToRadioButtonList.SelectedValue;
                    }
                }
                if (S_sizeForSizeCheckBox.Checked)
                {
                    cmd.Parameters["@sizeForSize"].Value = "yes";
                }
                if (S_any_allColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@anyAllColor"].Value = "yes";
                }
                if (S_highlights.SelectedValue == "yes")
                {
                    cmd.Parameters["@highlights"].Value = "yes";
                }
                if (S_photosFront.SelectedValue == "yes")
                {
                    cmd.Parameters["@photosFront"].Value = "yes";
                }
                if (S_photosBack.SelectedValue == "yes")
                {
                    cmd.Parameters["@photosBack"].Value = "yes";
                }
                if (S_colorCopies.SelectedValue == "yes")
                {
                    cmd.Parameters["@colorCopies"].Value = "yes";
                }
                if (S_handwrittenColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@handwrittenColor"].Value = "yes";
                }
                if (S_printingPressColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@printingPressColor"].Value = "yes";
                }
                if (S_chartsGraphsColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@chartsGraphs"].Value = "yes";
                }
                if (S_colorHandStamps.SelectedValue == "yes")
                {
                    cmd.Parameters["@colorHandStamp"].Value = "yes";
                }
                if (S_oversize.SelectedValue == "yes")
                {
                    cmd.Parameters["@oversized"].Value = "yes";
                }
                if (S_scanAndTagMedia.SelectedValue == "yes")
                {
                    cmd.Parameters["@scanAndTag"].Value = "yes";
                }
                if (S_colorCopies.SelectedValue == "yes")
                {
                    if (S_numberOfDuplicatesTextBox.Text != "" || S_numberOfDuplicatesTextBox.Text != "Enter Number of Duplicates" || S_numberOfDuplicatesTextBox.Text != null)
                    {
                        cmd.Parameters["@dupeAndTag"].Value = S_numberOfDuplicatesTextBox.Text;
                    }

                }
                if (S_bateLabelAndTagMedia.SelectedValue == "yes")
                {
                    cmd.Parameters["@bateLabelAndTag"].Value = "yes";
                }

                cmd.Parameters["@deliverableMainRadioButton"].Value = S_deliverables.SelectedValue;

                if (S_deliverables.SelectedValue == "pdf")
                {
                    cmd.Parameters["@deliverablePDFRadio"].Value = S_pdfPer.SelectedValue;

                    if (S_pdfPer.SelectedValue == "other")
                    {
                        cmd.Parameters["@deliverable"].Value = S_pdfPerTextBox.Text;
                    }
                }
                else if (S_deliverables.SelectedValue == "other")
                {
                    cmd.Parameters["@deliverable"].Value = S_deliverablesOtherTextBox.Text;
                }



                //if (S_deliverables.SelectedValue == "pdf")
                //{
                //    if (S_pdfPer.SelectedValue == "other")
                //    {
                //        cmd.Parameters["@deliverable"].Value = S_pdfPerTextBox.Text;
                //    }
                //    else
                //    {
                //        cmd.Parameters["@deliverable"].Value = S_pdfPer.SelectedValue;
                //    }
                //}
                //else if (S_deliverables.SelectedValue == "other")
                //{
                //    cmd.Parameters["@deliverable"].Value = S_deliverablesOtherTextBox.Text;
                //}
                //else
                //{
                //    cmd.Parameters["@deliverable"].Value = S_deliverables.SelectedValue;
                //}






                cmd.Parameters["@viewer"].Value = S_viewer.SelectedValue;
                if (S_textOneFieldTextBox.Text != "" || S_textOneFieldTextBox.Text != " " || S_textOneFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextOne"].Value = S_textOneFieldTextBox.Text;
                    cmd.Parameters["@indexingTextOneDegault"].Value = S_textOneTextBox.Text;
                    if (S_indexingTextOneDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextOneDoNotExport"].Value = "yes";
                    }
                    if (S_textOnePromoptedTextBox.Text != "" || S_textOnePromoptedTextBox.Text != " " || S_textOnePromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextOnePrompted"].Value = S_textOnePromoptedTextBox.Text;
                    }
                }
                if (S_textTwoFieldTextBox.Text != "" || S_textTwoFieldTextBox.Text != " " || S_textTwoFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextTwo"].Value = S_textTwoFieldTextBox.Text;
                    cmd.Parameters["@indexingTextTwoDegault"].Value = S_textTwoTextBox.Text;
                    if (S_indexingTextTwoDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextTwoDoNotExport"].Value = "yes";
                    }
                    if (S_textTwoPromoptedTextBox.Text != "" || S_textTwoPromoptedTextBox.Text != " " || S_textTwoPromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextTwoPrompted"].Value = S_textTwoPromoptedTextBox.Text;
                    }
                }
                if (S_textThreeFieldTextBox.Text != "" || S_textThreeFieldTextBox.Text != " " || S_textThreeFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextThree"].Value = S_textThreeFieldTextBox.Text;
                    cmd.Parameters["@indexingTextThreeDegault"].Value = S_textThreeTextBox.Text;
                    if (S_indexingTextThreeDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextThreeDoNotExport"].Value = "yes";
                    }
                    if (S_textThreePromoptedTextBox.Text != "" || S_textThreePromoptedTextBox.Text != " " || S_textThreePromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextThreePrompted"].Value = S_textThreePromoptedTextBox.Text;
                    }
                }
                if (S_textFourFieldTextBox.Text != "" || S_textFourFieldTextBox.Text != " " || S_textFourFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextFour"].Value = S_textFourFieldTextBox.Text;
                    cmd.Parameters["@indexingTextFourDegault"].Value = S_textFourTextBox.Text;
                    if (S_indexingTextFourDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextFourDoNotExport"].Value = "yes";
                    }
                    if (S_textFourPromoptedTextBox.Text != "" || S_textFourPromoptedTextBox.Text != " " || S_textFourPromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextFourPrompted"].Value = S_textFourPromoptedTextBox.Text;
                    }
                }
                if (S_textFiveFieldTextBox.Text != "" || S_textFiveFieldTextBox.Text != " " || S_textFiveFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextFive"].Value = S_textFiveFieldTextBox.Text;
                    cmd.Parameters["@indexingTextFiveDegault"].Value = S_textFiveTextBox.Text;
                    if (S_indexingTextFiveDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextFiveDoNotExport"].Value = "yes";
                    }
                    if (S_textFivePromoptedTextBox.Text != "" || S_textFivePromoptedTextBox.Text != " " || S_textFivePromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextFivePrompted"].Value = S_textFivePromoptedTextBox.Text;
                    }
                }
                if (S_textSixFieldTextBox.Text != "" || S_textSixFieldTextBox.Text != " " || S_textSixFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextSix"].Value = S_textSixFieldTextBox.Text;
                    cmd.Parameters["@indexingTextSixDegault"].Value = S_textSixTextBox.Text;
                    if (S_indexingTextSixDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextSixDoNotExport"].Value = "yes";
                    }
                    if (S_textSixPromoptedTextBox.Text != "" || S_textSixPromoptedTextBox.Text != " " || S_textSixPromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextSixPrompted"].Value = S_textSixPromoptedTextBox.Text;
                    }
                }
                if (S_textSevenFieldTextBox.Text != "" || S_textSevenFieldTextBox.Text != " " || S_textSevenFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextSeven"].Value = S_textSevenFieldTextBox.Text;
                    cmd.Parameters["@indexingTextSevenDegault"].Value = S_textSevenTextBox.Text;
                    if (S_indexingTextSevenDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextSevenDoNotExport"].Value = "yes";
                    }
                    if (S_textSevenPromoptedTextBox.Text != "" || S_textSevenPromoptedTextBox.Text != " " || S_textSevenPromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextSevenPrompted"].Value = S_textSevenPromoptedTextBox.Text;
                    }
                }
                if (S_textEightFieldTextBox.Text != "" || S_textEightFieldTextBox.Text != " " || S_textEightFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTextEight"].Value = S_textEightFieldTextBox.Text;
                    cmd.Parameters["@indexingTextEightDegault"].Value = S_textEightTextBox.Text;
                    if (S_indexingTextEightDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTextEightDoNotExport"].Value = "yes";
                    }
                    if (S_textEightPromoptedTextBox.Text != "" || S_textEightPromoptedTextBox.Text != " " || S_textEightPromoptedTextBox.Text != null)
                    {
                        cmd.Parameters["@indexingTextEightPrompted"].Value = S_textEightPromoptedTextBox.Text;
                    }
                }
                if (S_tagOneFieldTextBox.Text != "" || S_tagOneFieldTextBox.Text != " " || S_tagOneFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTagOneDefautl"].Value = S_tagOneRadioButtonList.SelectedValue;
                    if (S_indexingTagOneDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTagOneDoNotExport"].Value = "yes";
                    }
                }
                if (S_tagTwoFieldTextBox.Text != "" || S_tagTwoFieldTextBox.Text != " " || S_tagTwoFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTagTwoDefautl"].Value = S_tagTwoRadioButtonList.SelectedValue;
                    if (S_indexingTagTwoDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTagTwoDoNotExport"].Value = "yes";
                    }
                }
                if (S_tagThreeFieldTextBox.Text != "" || S_tagThreeFieldTextBox.Text != " " || S_tagThreeFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTagThreeDefautl"].Value = S_tagThreeRadioButtonList.SelectedValue;
                    if (S_indexingTagThreeDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTagThreeDoNotExport"].Value = "yes";
                    }
                }
                if (S_tagFourFieldTextBox.Text != "" || S_tagFourFieldTextBox.Text != " " || S_tagFourFieldTextBox.Text != null)
                {
                    cmd.Parameters["@indexingTagFourDefautl"].Value = S_tagFourRadioButtonList.SelectedValue;
                    if (S_indexingTagFourDonNotExpotCheckBox.Checked)
                    {
                        cmd.Parameters["@indexingTagFourDoNotExport"].Value = "yes";
                    }
                }
                cmd.Parameters["@indexingTagColorDefautl"].Value = S_tagColorRadioButtonList.SelectedValue;
                if (S_indexingTagColorDonNotExpotCheckBox.Checked)
                {
                    cmd.Parameters["@indexingTagColorDoNotExport"].Value = "yes";
                }
                cmd.Parameters["@indexingTagOversizedDefautl"].Value = S_tagOversizedRadioButtonList.SelectedValue;
                if (S_indexingTagOversizedDonNotExpotCheckBox.Checked)
                {
                    cmd.Parameters["@indexingTagOversizedDoNotExport"].Value = "yes";
                }
                cmd.Parameters["@indexingTagMediaDefautl"].Value = S_tagMediaRadioButtonList.SelectedValue;
                if (S_indexingTagMediaDonNotExpotCheckBox.Checked)
                {
                    cmd.Parameters["@indexingTagMediaDoNotExport"].Value = "yes";
                }

                cmd.Parameters["@ebs"].Value = S_ebsOptionsRadioButtonList.SelectedValue;
                cmd.Parameters["@ebsSelectionNumbering"].Value = S_ebsNumberingRadioButtonList.SelectedValue;
                if (S_ebsOptionsRadioButtonList.SelectedValue == "yes")
                {
                    if (S_ebsNumberingRadioButtonList.SelectedValue == "ebsOther")
                    {
                        if (S_ebsOtherControlNumberTextBox.Text != "" || S_ebsOtherControlNumberTextBox.Text != null)
                        {
                            if (S_ebsOtherPrefixTextBox.Text != "" || S_ebsOtherPrefixTextBox.Text != "Prefix for EBS")
                            {
                                cmd.Parameters["@ebsControlNumberPrefix"].Value = S_ebsOtherPrefixTextBox.Text;
                            }
                            if (S_ebsOtherStartNumberTextBox.Text != "" || S_ebsOtherStartNumberTextBox.Text != "Starting Number for EBS")
                            {
                                cmd.Parameters["@ebsControlNumberStarting"].Value = S_ebsOtherStartNumberTextBox.Text;
                            }
                            if (S_ebsOtherSuffixTextBox.Text != "" || S_ebsOtherSuffixTextBox.Text != "Suffix for EBS")
                            {
                                cmd.Parameters["@ebsControlNumberSuffix"].Value = S_ebsOtherSuffixTextBox.Text;
                            }
                        }
                    }
                }
                cmd.Parameters["@ebsLocation"].Value = S_ebsLocationsRadioButtonList.SelectedValue;
                cmd.Parameters["@ebsSize"].Value = S_ebsOptionSizeDropDownBox.SelectedValue;
                cmd.Parameters["@ebsFont"].Value = S_ebsOptionFontDropDownList.SelectedValue;
                cmd.Parameters["@ebsFontStyle"].Value = S_ebsFontOptionStyleDropDownList.SelectedValue;
                if (S_ebsAddtionalLinesRadioButtonList.SelectedValue == "yes")
                {
                    if (S_ebsOptionAdditionalLinesLineOneTextBox.Text != "" || S_ebsOptionAdditionalLinesLineOneTextBox.Text != null)
                    {
                        cmd.Parameters["@ebsAdditionalLinesOne"].Value = S_ebsOptionAdditionalLinesLineOneTextBox.Text;
                    }
                    else if (S_ebsOptionAdditionalLinesLineTwoTextBox.Text != "" || S_ebsOptionAdditionalLinesLineTwoTextBox.Text != null)
                    {
                        cmd.Parameters["@ebsAdditionalLinesTwo"].Value = S_ebsOptionAdditionalLinesLineTwoTextBox.Text;
                    }
                    else
                    {
                        cmd.Parameters["@ebsAdditionalLinesOne"].Value = null;
                        cmd.Parameters["@ebsAdditionalLinesTwo"].Value = null;
                    }
                }
                if (S_dvdOptionRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@dvd"].Value = "yes";
                }
                if (S_duplicateExhisitingClientLabelRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@duplicateClientLabel"].Value = "yes";
                }
                if (Convert.ToInt32(S_cdBurnCopiesFirmOneDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@firmOne"].Value = S_cdBurnInfoFirmOneTextBox.Text;
                    cmd.Parameters["@firmOneNumberOfCopies"].Value = Convert.ToInt32(S_cdBurnCopiesFirmOneDropDown.SelectedValue);
                    if (S_cdBurnTiffFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneTiff"].Value = "yes";
                    }
                    if (S_cdBurnMTiffFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneMTiff"].Value = "yes";
                    }
                    if (S_cdBurnOCRFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneOCR"].Value = "yes";
                    }
                    if (S_cdBurnPDFFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOnePDF"].Value = "yes";
                    }
                    if (S_cdBurnSeachablePDFFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneSearchablePDF"].Value = "yes";
                    }
                    if (S_cdBurnPDF_w_BookmarksFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOnePDFwBookmarks"].Value = "yes";
                    }
                }
                if (Convert.ToInt32(S_cdBurnCopiesFirmTwoDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@firmTwo"].Value = S_cdBurnInfoFirmTwoTextBox.Text;
                    cmd.Parameters["@firmTwoNumberOfCopies"].Value = Convert.ToInt32(S_cdBurnCopiesFirmTwoDropDown.SelectedValue);
                    if (S_cdBurnTiffFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoTiff"].Value = "yes";
                    }
                    if (S_cdBurnMTiffFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoMTiff"].Value = "yes";
                    }
                    if (S_cdBurnOCRFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoOCR"].Value = "yes";
                    }
                    if (S_cdBurnPDFFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoPDF"].Value = "yes";
                    }
                    if (S_cdBurnSeachablePDFFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoSearchablePDF"].Value = "yes";
                    }
                    if (S_cdBurnPDF_w_BookmarksFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoPDFwBookmarks"].Value = "yes";
                    }
                }
                if (Convert.ToInt32(S_cdBurnCopiesFirmThreeDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@firmThree"].Value = S_cdBurnInfoFirmThreeTextBox.Text;
                    cmd.Parameters["@firmThreeNumberOfCopies"].Value = Convert.ToInt32(S_cdBurnCopiesFirmThreeDropDown.SelectedValue);
                    if (S_cdBurnTiffFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeTiff"].Value = "yes";
                    }
                    if (S_cdBurnMTiffFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeMTiff"].Value = "yes";
                    }
                    if (S_cdBurnOCRFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeOCR"].Value = "yes";
                    }
                    if (S_cdBurnPDFFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreePDF"].Value = "yes";
                    }
                    if (S_cdBurnSeachablePDFFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeSearchablePDF"].Value = "yes";
                    }
                    if (S_cdBurnPDF_w_BookmarksFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreePDFwBookmarks"].Value = "yes";
                    }
                }
                if (S_cdLabelCaseNameTextBox.Text != "" || S_cdLabelCaseNameTextBox.Text != null)
                {
                    cmd.Parameters["@cdCase"].Value = S_cdLabelCaseNameTextBox.Text;
                }
                if (S_cdLabelBatesRangeRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@batesRange"].Value = "yes";
                }
                if (S_cdLabelClientMatterTextBox.Text != "" || S_cdLabelClientMatterTextBox.Text != null)
                {
                    cmd.Parameters["@cdClientMatter"].Value = S_cdLabelClientMatterTextBox.Text;
                }
                if (S_cdLabelNotesTextBox.Text != "" || S_cdLabelNotesTextBox.Text != null)
                {
                    cmd.Parameters["@notes"].Value = S_cdLabelNotesTextBox.Text;
                }
                if (Convert.ToInt32(S_printQuantityCleanDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printCleanSet"].Value = Convert.ToInt32(S_printQuantityCleanDropDown.SelectedValue);
                }
                if (Convert.ToInt32(S_printQuantityEBSedDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printEBSEDSet"].Value = Convert.ToInt32(S_printQuantityEBSedDropDown.SelectedValue);
                }
                if (Convert.ToInt32(S_printQuantityBarCodedDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printBarCodeSet"].Value = Convert.ToInt32(S_printQuantityBarCodedDropDown.SelectedValue);
                }

                if (Convert.ToInt32(S_printQuantityCleanDropDown.SelectedValue) > 0 || Convert.ToInt32(S_printQuantityEBSedDropDown.SelectedValue) > 0 || Convert.ToInt32(S_printQuantityBarCodedDropDown.SelectedValue) > 0)
                {
                    if (S_printBindersOptionRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@binder"].Value = S_printBindersSizeRadioButtonList.SelectedValue;
                        cmd.Parameters["@binderView"].Value = S_printBinderOptionViewRadioBttonList.SelectedValue;
                    }
                    if (S_printAccoRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@twoHole"].Value = S_printAccoSideRadioButtonList.SelectedValue;
                    }
                    if (S_printCombRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@gpcBind"].Value = S_printCombOptionsRadioBttonList.SelectedValue;
                    }
                    if (S_printVeloRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@veloBind"].Value = S_printVeloOptionRadioButtonList.SelectedValue;
                    }
                    if (S_printSpiralRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@spiralBind"].Value = S_printSpiralOptionsRadioButtonList.SelectedValue;
                    }
                    if (S_printMatchOriginalsRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@matchOriginals"].Value = "yes";
                    }
                    if (S_printDrillingRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@drilling"].Value = S_printDrillingOptionRadioButton.SelectedValue;
                    }
                    if (S_printingTwoSidedRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@twoSided"].Value = "yes";
                    }
                    if (S_printColor4ColorRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@colorForColor"].Value = "yes";
                    }
                    if (S_printSize4SizeRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@sizeForSize"].Value = "yes";
                    }
                    cmd.Parameters["@slipsheets"].Value = S_printSlipSheetsRadioButtonList.SelectedValue;
                    if (S_printStapleRadioButton.SelectedValue == "yes")
                    {
                        cmd.Parameters["@staplePerDoc"].Value = "yes";
                    }
                    if (S_specialInstrctionsPrintRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@printSpecialInstructions"].Value = S_specialInstrctionsPrintTextBox.Text;
                    }
                    if (S_sepcialInstrctionsProductionTextBox.Text != "" || S_sepcialInstrctionsProductionTextBox.Text != null)
                    {
                        cmd.Parameters["@spcialInstructionsProduction"].Value = S_sepcialInstrctionsProductionTextBox.Text;
                    }
                    if (S_specialInstrctionsDataTextBox.Text != "" || S_specialInstrctionsDataTextBox.Text != null)
                    {
                        cmd.Parameters["@spcialInstructionsData"].Value = S_specialInstrctionsDataTextBox.Text;
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void C_addToDataBase_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                cmd.Parameters.Add("@contactName", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@clientMatter", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingPrefix", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingBox", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingIncrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingReincrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingSpace", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@volumeName", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@documentLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@groupingLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@pickAndChoose", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@scanAllPortrait", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@covers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldCovers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dividerTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@postItNotes", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@coloredSheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@binderSpines", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@envelopes", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@standardLang", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@carbon", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@reduceTo", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@anyAllColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@highlights", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosFront", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosBack", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorCopies", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@handwrittenColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printingPressColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@chartsGraphs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorHandStamp", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@oversized", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@scanAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dupeAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@bateLabelAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@deliverable", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@viewer", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTextOne", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextOneDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextOnePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextTwo", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextTwoDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextTwoPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextThree", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextThreeDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextThreePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFour", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFourDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFourPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFive", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFiveDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFiveDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFivePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSix", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSixDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSixDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSixPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSeven", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSevenDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSevenDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSevenPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextEight", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextEightDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextEightDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextEightPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTagOne", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOneDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagTwo", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagTwoDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagThree", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagThreeDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagFour", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagFourDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagColor", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagColorDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagColorDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagOversized", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOversizedDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOversizedDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagMedia", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagMediaDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagMediaDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebs", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@ebsControlNumberPrefix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberStarting", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberSuffix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsLocation", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@ebsSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@ebsFont", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsFontStyle", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsAdditionalLinesOne", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@ebsAdditionalLinesTwo", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@dvd", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@duplicateClientLabel", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOne", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmOneNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmOneTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwo", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmTwoNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmTwoTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThree", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmThreeNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmThreeTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdCase", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@batesRange", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdClientMatter", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@notes", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@printCleanSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printEBSEDSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printBarCodeSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@binder", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@binderView", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoHole", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@gpcBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@veloBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@sprialBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@matchOriginals", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@drilling", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoSided", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorForColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@slipsheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@staplePerDoc", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printSpecialInstructions", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsProduction", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsData", System.Data.SqlDbType.VarChar);
                
                
                //Added Parameters
                
                cmd.Parameters.Add("@copySize",System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@copyPrintMethod",System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@copyEnlargeTo",System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@copyOversizeDocuments",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copyVideoTapesCopy",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copyVideoTapesDup",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copyAudioTapesCopy",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copyAudioTapesDup",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copyCompactDiskCopy",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copyCompactDiskDup",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copy35DisketteCopy",System.Data.SqlDbType.VarChar,15);
                cmd.Parameters.Add("@copy35DisketteDup",System.Data.SqlDbType.VarChar,15);
                

                cmd.Parameters["@contactName"].Value = C_clientNameDropDown.SelectedValue;
                if (C_clientMatterTextBox.Text != "" || C_clientMatterTextBox.Text != null)
                {
                    cmd.Parameters["@clientMatter"].Value = C_clientMatterTextBox.Text;
                }
                else
                {
                    cmd.Parameters["@clientMatter"].Value = null;
                }
                //THESE 2 WERE ADDED
                cmd.Parameters["@copySize"].Value = C_sizeRadioButtonList.SelectedValue;
                cmd.Parameters["@copyPrintMethod"].Value = C_printMethodRadioButtonList.SelectedValue;
                
                if (C_pickAndChoose.Checked)
                {
                    cmd.Parameters["@pickAndChoose"].Value = C_specialInstructionsPickAndChooseTextBox.Text;
                }
                if (C_coversRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@covers"].Value = "yes";
                }
                if (C_redweldFolderCovers.SelectedValue == "yes")
                {
                    cmd.Parameters["@redweldCovers"].Value = "yes";
                }
                if (C_redweldFolderTabs.SelectedValue == "yes")
                {
                    cmd.Parameters["@redweldTabs"].Value = "yes";
                }
                if (C_dividerTabs.SelectedValue == "yes")
                {
                    cmd.Parameters["@dividerTabs"].Value = "yes";
                }
                if (C_postitNotes.SelectedValue == "yes")
                {
                    cmd.Parameters["@postItNotes"].Value = C_postItNoteInstruction.SelectedValue;
                }
                if (C_coloredSheets.SelectedValue == "yes")
                {
                    cmd.Parameters["@coloredSheets"].Value = "yes";
                }
                if (C_binderSpines.SelectedValue == "yes")
                {
                    cmd.Parameters["@binderSpines"].Value = "yes";
                }
                if (C_envelopes.SelectedValue == "yes")
                {
                    cmd.Parameters["@envelopes"].Value = "yes";
                }
                if (C_standardLang.SelectedValue == "yes")
                {
                    cmd.Parameters["@standardLang"].Value = "yes";
                }
                if (C_carbon.SelectedValue == "yes")
                {
                    cmd.Parameters["@carbon"].Value = "yes";
                }
                if (C_reduceToCheckBox.Checked)
                {
                    if (C_reduceToRadioButtonList.SelectedValue == "other")
                    {
                        if (C_reduceToOtherTextBox.Text == "" || C_reduceToOtherTextBox.Text == null)
                        {
                            cmd.Parameters["@reduceTo"].Value = null;
                        }
                        else
                        {
                            cmd.Parameters["@reduceTo"].Value = C_reduceToOtherTextBox.Text;
                        }
                    }
                    else
                    {
                        cmd.Parameters["@reduceTo"].Value = C_reduceToRadioButtonList.SelectedValue;
                    }
                }
                if (C_sizeForSizeCheckBox.Checked)
                {
                    cmd.Parameters["@sizeForSize"].Value = "yes";
                }


                //THIS BLOCK
                if (C_enlargeToCheckBox.Checked)
		        {
		            if (C_enlargeToRadioButtonList.SelectedValue == "other")
		            {
			            if (C_enlargeToOtherTextBox.Text != "" || C_enlargeToOtherTextBox.Text != null)
			            {
			                cmd.Parameters["@copyEnlargeTo"].Value = null;
			            }
			            else
			            {
			              cmd.Parameters["@copyEnlargeTo"].Value = C_enlargeToOtherTextBox.Text;
			            }
		            }
		            else
		            {
			            cmd.Parameters["@copyEnlargeTo"].Value = C_enlargeToRadioButtonList.SelectedValue;
		            }

		            cmd.Parameters["@copyOversizeDocuments"].Value = C_oversizeDocRadioButtonList.SelectedValue;


                }
               //END BLOCK HERE


                if (C_any_allColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@anyAllColor"].Value = "yes";
                }
                if (C_highlights.SelectedValue == "yes")
                {
                    cmd.Parameters["@highlights"].Value = "yes";
                }
                if (C_photosFront.SelectedValue == "yes")
                {
                    cmd.Parameters["@photosFront"].Value = "yes";
                }
                if (C_photosBack.SelectedValue == "yes")
                {
                    cmd.Parameters["@photosBack"].Value = "yes";
                }
                if (C_colorCopies.SelectedValue == "yes")
                {
                    cmd.Parameters["@colorCopies"].Value = "yes";
                }
                if (C_handwrittenColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@handwrittenColor"].Value = "yes";
                }
                if (C_printingPressColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@printingPressColor"].Value = "yes";
                }
                if (C_chartsGraphsColor.SelectedValue == "yes")
                {
                    cmd.Parameters["@chartsGraphs"].Value = "yes";
                }
                if (C_colorHandStamps.SelectedValue == "yes")
                {
                    cmd.Parameters["@colorHandStamp"].Value = "yes";
                }
                if (C_oversize.SelectedValue == "yes")
                {
                    cmd.Parameters["@oversized"].Value = "yes";
                }

                //THIS ---Change these values to copy an dup
                /* 
                 * if(C_videoTapesCheckBoxList.SelectedValue == "copy")
                 * {
                        cmd.Parameters["@copyVideoTapesCopy"].Value = "copy";
                   }
                   if(C_videoTapesCheckBoxList.SelectedValue == "dup")
                   {
                        cmd.Parameters["@copyVideoTapesDup"].Value = "dup";
                   }
                 */


                if (C_videoTapesCheckBoxList.SelectedValue == "copy")
                {
                    cmd.Parameters["@copyVideoTapesCopy"].Value = "copy";
                }
                if(C_videoTapesCheckBoxList.SelectedValue == "dup")
                {
                    cmd.Parameters["@copyVideoTapesDup"].Value = "dup";
                }
                if(C_audioTapesCheckBoxList.SelectedValue == "copy")
                {
                    cmd.Parameters["@copyAudioTapesCopy"].Value = "copy";
                }                
                if(C_audioTapesCheckBoxList.SelectedValue == "dup")
                {
                    cmd.Parameters["@copyAudioTapesDup"].Value = "dup";
                }                
                if(C_compactDiskCheckBoxList.SelectedValue == "copy")
                {
                    cmd.Parameters["@copyCompactDiskCopy"].Value = "copy";
                }                
                if(C_compactDiskCheckBoxList.SelectedValue == "dup")
                {
                    cmd.Parameters["@copyCompactDiskDup"].Value = "dup";
                }
                if(C_floppieDisks.SelectedValue == "copy")
                {
                    cmd.Parameters["@copy35DisketteCopy"].Value = "copy";
                }
                if(C_floppieDisks.SelectedValue == "dup")
                {
                    cmd.Parameters["@copy35DisketteDup"].Value = "dup";
                }
                //END HERE

	 	        if (C_sepcialInstrctionsProductionTextBox.Text != "" || C_sepcialInstrctionsProductionTextBox.Text != null)
	 	        {
	 	            cmd.Parameters["@spcialInstructionsProduction"].Value = C_sepcialInstrctionsProductionTextBox.Text;
	 	        }

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void D_addToDataBase_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                cmd.Parameters.Add("@contactName", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@clientMatter", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingPrefix", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingBox", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingIncrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingReincrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingSpace", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@volumeName", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@documentLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@groupingLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@pickAndChoose", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@scanAllPortrait", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@covers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldCovers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dividerTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@postItNotes", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@coloredSheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@binderSpines", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@envelopes", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@standardLang", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@carbon", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@reduceTo", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@anyAllColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@highlights", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosFront", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosBack", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorCopies", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@handwrittenColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printingPressColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@chartsGraphs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorHandStamp", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@oversized", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@scanAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dupeAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@bateLabelAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@deliverable", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@viewer", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTextOne", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextOneDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextOnePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextTwo", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextTwoDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextTwoPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextThree", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextThreeDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextThreePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFour", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFourDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFourPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFive", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFiveDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFiveDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFivePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSix", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSixDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSixDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSixPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSeven", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSevenDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSevenDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSevenPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextEight", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextEightDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextEightDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextEightPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTagOne", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOneDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagTwo", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagTwoDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagThree", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagThreeDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagFour", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagFourDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagColor", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagColorDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagColorDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagOversized", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOversizedDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOversizedDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagMedia", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagMediaDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagMediaDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebs", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@ebsControlNumberPrefix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberStarting", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberSuffix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsLocation", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@ebsSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@ebsFont", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsFontStyle", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsAdditionalLinesOne", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@ebsAdditionalLinesTwo", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@dvd", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@duplicateClientLabel", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOne", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmOneNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmOneTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwo", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmTwoNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmTwoTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThree", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmThreeNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmThreeTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdCase", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@batesRange", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdClientMatter", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@notes", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@printCleanSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printEBSEDSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printBarCodeSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@binder", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@binderView", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoHole", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@gpcBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@veloBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@sprialBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@matchOriginals", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@drilling", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoSided", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorForColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@slipsheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@staplePerDoc", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printSpecialInstructions", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsProduction", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsData", System.Data.SqlDbType.VarChar);

                cmd.Parameters["@contactName"].Value = D_clientNameDropDown.SelectedValue;


                if (D_clientMatterTextBox.Text != "" || D_clientMatterTextBox.Text != null)
                {
                    cmd.Parameters["@clientMatter"].Value = D_clientMatterTextBox.Text;
                }
                else
                {
                    cmd.Parameters["@clientMatter"].Value = null;
                }
                if (D_controlNumberPrefixTxt.Text != "" || D_controlNumberPrefixTxt.Text != null)
                {
                    cmd.Parameters["@namingPrefix"].Value = D_controlNumberPrefixTxt.Text;
                }
                else
                {
                    cmd.Parameters["@namingPrefix"].Value = "";
                }
                if (D_controlNumberBoxTxt.Text != "" || D_controlNumberBoxTxt.Text != null)
                {
                    cmd.Parameters["@namingBox"].Value = D_controlNumberBoxTxt.Text;
                }
                else
                {
                    cmd.Parameters["@namingBox"].Value = "";
                }
                if (D_conrolNumberIncrementingNumberTxt.Text != "" || D_conrolNumberIncrementingNumberTxt.Text != null)
                {
                    cmd.Parameters["@namingIncrementing"].Value = D_conrolNumberIncrementingNumberTxt.Text;
                }
                else
                {
                    cmd.Parameters["@namingIncrementing"].Value = "";
                }
                if (D_reincrementingCheckBox.Checked)
                {
                    cmd.Parameters["@namingReincrementing"].Value = D_reincrementingRadioList.SelectedValue;
                }
                else
                {
                    cmd.Parameters["@namingReincrementing"].Value = null;
                }
                if (D_spaceInControlNumberRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@namingSpace"].Value = "yes";
                }
                else
                {
                    cmd.Parameters["@namingSpace"].Value = null;
                }
                if (D_volumeTextBox.Text != "" || D_volumeTextBox.Text != null)
                {
                    cmd.Parameters["@volumeName"].Value = D_volumeTextBox.Text;
                }
                else
                {
                    cmd.Parameters["@volumeName"].Value = null;
                }

                if (D_deliverables.SelectedValue == "pdf")
                {
                    if (D_pdfPer.SelectedValue == "other")
                    {
                        cmd.Parameters["@deliverable"].Value = D_pdfPerTextBox.Text;
                    }
                    else
                    {
                        cmd.Parameters["@deliverable"].Value = D_pdfPer.SelectedValue;
                    }
                }
                else if (D_deliverables.SelectedValue == "other")
                {
                    cmd.Parameters["@deliverable"].Value = D_deliverablesOtherTextBox.Text;
                }
                else
                {
                    cmd.Parameters["@deliverable"].Value = D_deliverables.SelectedValue;
                }
                if (D_viewer.SelectedValue == "no")
                {
                    cmd.Parameters["@viewer"].Value = null;
                }
                else
                {
                    cmd.Parameters["@viewer"].Value = D_viewer.SelectedValue;
                }

                if (D_ebsOptionsRadioButtonList.SelectedValue == "yes")
                {
                    if (D_ebsNumberingRadioButtonList.SelectedValue == "ebsOther")
                    {
                        if (D_ebsOtherControlNumberTextBox.Text != "" || D_ebsOtherControlNumberTextBox.Text != null)
                        {
                            if (D_ebsOtherPrefixTextBox.Text != "" || D_ebsOtherPrefixTextBox.Text != "Prefix for EBS")
                            {
                                cmd.Parameters["@ebsControlNumberPrefix"].Value = D_ebsOtherPrefixTextBox.Text;
                            }
                            if (D_ebsOtherStartNumberTextBox.Text != "" || D_ebsOtherStartNumberTextBox.Text != "Starting Number for EBS")
                            {
                                cmd.Parameters["@ebsControlNumberStarting"].Value = D_ebsOtherStartNumberTextBox.Text;
                            }
                            if (D_ebsOtherSuffixTextBox.Text != "" || D_ebsOtherSuffixTextBox.Text != "Suffix for EBS")
                            {
                                cmd.Parameters["@ebsControlNumberSuffix"].Value = D_ebsOtherSuffixTextBox.Text;
                            }
                        }
                    }
                }
                cmd.Parameters["@ebsLocation"].Value = D_ebsLocationsRadioButtonList.SelectedValue;
                cmd.Parameters["@ebsSize"].Value = D_ebsOptionSizeDropDownBox.SelectedValue;
                cmd.Parameters["@ebsFont"].Value = D_ebsOptionFontDropDownList.SelectedValue;
                cmd.Parameters["@ebsFontStyle"].Value = D_ebsFontOptionStyleDropDownList.SelectedValue;
                if (D_ebsAddtionalLinesRadioButtonList.SelectedValue == "yes")
                {
                    if (D_ebsOptionAdditionalLinesLineOneTextBox.Text != "" || D_ebsOptionAdditionalLinesLineOneTextBox.Text != null)
                    {
                        cmd.Parameters["@ebsAdditionalLinesOne"].Value = D_ebsOptionAdditionalLinesLineOneTextBox.Text;
                    }
                    else if (D_ebsOptionAdditionalLinesLineTwoTextBox.Text != "" || D_ebsOptionAdditionalLinesLineTwoTextBox.Text != null)
                    {
                        cmd.Parameters["@ebsAdditionalLinesTwo"].Value = D_ebsOptionAdditionalLinesLineTwoTextBox.Text;
                    }
                    else
                    {
                        cmd.Parameters["@ebsAdditionalLinesOne"].Value = null;
                        cmd.Parameters["@ebsAdditionalLinesTwo"].Value = null;
                    }
                }
                if (D_dvdOptionRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@dvd"].Value = "yes";
                }
                if (D_duplicateExhisitingClientLabelRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@duplicateClientLabel"].Value = "yes";
                }
                if (Convert.ToInt32(D_cdBurnCopiesFirmOneDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@firmOne"].Value = D_cdBurnInfoFirmOneTextBox.Text;
                    cmd.Parameters["@firmOneNumberOfCopies"].Value = Convert.ToInt32(D_cdBurnCopiesFirmOneDropDown.SelectedValue);
                    if (D_cdBurnTiffFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneTiff"].Value = "yes";
                    }
                    if (D_cdBurnMTiffFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneMTiff"].Value = "yes";
                    }
                    if (D_cdBurnOCRFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneOCR"].Value = "yes";
                    }
                    if (D_cdBurnPDFFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOnePDF"].Value = "yes";
                    }
                    if (D_cdBurnSeachablePDFFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOneSearchablePDF"].Value = "yes";
                    }
                    if (D_cdBurnPDF_w_BookmarksFirmOneCheckBox.Checked)
                    {
                        cmd.Parameters["@firmOnePDFwBookmarks"].Value = "yes";
                    }
                }
                if (Convert.ToInt32(D_cdBurnCopiesFirmTwoDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@firmTwo"].Value = D_cdBurnInfoFirmTwoTextBox.Text;
                    cmd.Parameters["@firmTwoNumberOfCopies"].Value = Convert.ToInt32(D_cdBurnCopiesFirmTwoDropDown.SelectedValue);
                    if (D_cdBurnTiffFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoTiff"].Value = "yes";
                    }
                    if (D_cdBurnMTiffFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoMTiff"].Value = "yes";
                    }
                    if (D_cdBurnOCRFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoOCR"].Value = "yes";
                    }
                    if (D_cdBurnPDFFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoPDF"].Value = "yes";
                    }
                    if (D_cdBurnSeachablePDFFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoSearchablePDF"].Value = "yes";
                    }
                    if (D_cdBurnPDF_w_BookmarksFirmTwoCheckBox.Checked)
                    {
                        cmd.Parameters["@firmTwoPDFwBookmarks"].Value = "yes";
                    }
                }
                if (Convert.ToInt32(D_cdBurnCopiesFirmThreeDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@firmThree"].Value = D_cdBurnInfoFirmThreeTextBox.Text;
                    cmd.Parameters["@firmThreeNumberOfCopies"].Value = Convert.ToInt32(D_cdBurnCopiesFirmThreeDropDown.SelectedValue);
                    if (D_cdBurnTiffFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeTiff"].Value = "yes";
                    }
                    if (D_cdBurnMTiffFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeMTiff"].Value = "yes";
                    }
                    if (D_cdBurnOCRFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeOCR"].Value = "yes";
                    }
                    if (D_cdBurnPDFFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreePDF"].Value = "yes";
                    }
                    if (D_cdBurnSeachablePDFFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreeSearchablePDF"].Value = "yes";
                    }
                    if (D_cdBurnPDF_w_BookmarksFirmThreeCheckBox.Checked)
                    {
                        cmd.Parameters["@firmThreePDFwBookmarks"].Value = "yes";
                    }
                }
                if (D_cdLabelCaseNameTextBox.Text != "" || D_cdLabelCaseNameTextBox.Text != null)
                {
                    cmd.Parameters["@cdCase"].Value = D_cdLabelCaseNameTextBox.Text;
                }
                if (D_cdLabelBatesRangeRadioButtonList.SelectedValue == "yes")
                {
                    cmd.Parameters["@batesRange"].Value = "yes";
                }
                if (D_cdLabelClientMatterTextBox.Text != "" || D_cdLabelClientMatterTextBox.Text != null)
                {
                    cmd.Parameters["@cdClientMatter"].Value = D_cdLabelClientMatterTextBox.Text;
                }
                if (D_cdLabelNotesTextBox.Text != "" || D_cdLabelNotesTextBox.Text != null)
                {
                    cmd.Parameters["@notes"].Value = D_cdLabelNotesTextBox.Text;
                }
                if (Convert.ToInt32(D_printQuantityCleanDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printCleanSet"].Value = Convert.ToInt32(D_printQuantityCleanDropDown.SelectedValue);
                }
                if (Convert.ToInt32(D_printQuantityEBSedDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printEBSEDSet"].Value = Convert.ToInt32(D_printQuantityEBSedDropDown.SelectedValue);
                }
                if (Convert.ToInt32(D_printQuantityBarCodedDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printBarCodeSet"].Value = Convert.ToInt32(D_printQuantityBarCodedDropDown.SelectedValue);
                }

                if (Convert.ToInt32(D_printQuantityCleanDropDown.SelectedValue) > 0 || Convert.ToInt32(D_printQuantityEBSedDropDown.SelectedValue) > 0 || Convert.ToInt32(D_printQuantityBarCodedDropDown.SelectedValue) > 0)
                {
                    if (D_printBindersOptionRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@binder"].Value = D_printBindersSizeRadioButtonList.SelectedValue;
                        cmd.Parameters["@binderView"].Value = D_printBinderOptionViewRadioBttonList.SelectedValue;
                    }
                    if (D_printAccoRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@twoHole"].Value = D_printAccoSideRadioButtonList.SelectedValue;
                    }
                    if (D_printCombRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@gpcBind"].Value = D_printCombOptionsRadioBttonList.SelectedValue;
                    }
                    if (D_printVeloRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@veloBind"].Value = D_printVeloOptionRadioButtonList.SelectedValue;
                    }
                    if (D_printSpiralRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@spiralBind"].Value = D_printSpiralOptionsRadioButtonList.SelectedValue;
                    }
                    if (D_printMatchOriginalsRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@matchOriginals"].Value = "yes";
                    }
                    if (D_printDrillingRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@drilling"].Value = D_printDrillingOptionRadioButton.SelectedValue;
                    }
                    if (D_printingTwoSidedRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@twoSided"].Value = "yes";
                    }
                    if (D_printColor4ColorRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@colorForColor"].Value = "yes";
                    }
                    if (D_printSize4SizeRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@sizeForSize"].Value = "yes";
                    }
                    cmd.Parameters["@slipsheets"].Value = D_printSlipSheetsRadioButtonList.SelectedValue;
                    if (D_printStapleRadioButton.SelectedValue == "yes")
                    {
                        cmd.Parameters["@staplePerDoc"].Value = "yes";
                    }
                    if (D_specialInstrctionsPrintRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@printSpecialInstructions"].Value = D_specialInstrctionsPrintTextBox.Text;
                    }
                    if (D_specialInstrctionsDataTextBox.Text != "" || D_specialInstrctionsDataTextBox.Text != null)
                    {
                        cmd.Parameters["@spcialInstructionsData"].Value = D_specialInstrctionsDataTextBox.Text;
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void P_addToDataBase_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                cmd.Parameters.Add("@contactName", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@clientMatter", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingPrefix", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingBox", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingIncrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingReincrementing", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@namingSpace", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@volumeName", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@documentLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@groupingLevel", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@pickAndChoose", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@scanAllPortrait", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@covers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldCovers", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@redweldTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dividerTabs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@postItNotes", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@coloredSheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@binderSpines", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@envelopes", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@standardLang", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@carbon", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@reduceTo", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@anyAllColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@highlights", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosFront", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@photosBack", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorCopies", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@handwrittenColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printingPressColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@chartsGraphs", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorHandStamp", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@oversized", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@scanAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@dupeAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@bateLabelAndTag", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@deliverable", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@viewer", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTextOne", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextOneDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextOnePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextTwo", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextTwoDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextTwoPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextThree", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextThreeDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextThreePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFour", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFourDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFourPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextFive", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextFiveDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextFiveDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextFivePrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSix", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSixDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSixDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSixPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextSeven", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextSevenDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextSevenDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextSevenPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTextEight", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@indexingTextEightDefault", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@indexingTextEightDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTextEightPrompted", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@indexingTagOne", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOneDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOneDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagTwo", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagTwoDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagTwoDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagThree", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagThreeDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagThreeDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagFour", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagFourDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagFourDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagColor", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagColorDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagColorDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagOversized", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagOversizedDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagOversizedDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@indexingTagMedia", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@indexingTagMediaDoNotExport", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@indexingTagMediaDefault", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebs", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@ebsControlNumberPrefix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberStarting", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsControlNumberSuffix", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsLocation", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@ebsSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@ebsFont", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsFontStyle", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@ebsAdditionalLinesOne", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@ebsAdditionalLinesTwo", System.Data.SqlDbType.VarChar, 60);
                cmd.Parameters.Add("@dvd", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@duplicateClientLabel", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOne", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmOneNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmOneTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOneSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmOnePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwo", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmTwoNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmTwoTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmTwoPDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThree", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@firmThreeNumberOfCopies", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@firmThreeTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeMTiff", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeOCR", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreeSearchablePDF", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@firmThreePDFwBookmarks", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdCase", System.Data.SqlDbType.VarChar, 75);
                cmd.Parameters.Add("@batesRange", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@cdClientMatter", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@notes", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@printCleanSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printEBSEDSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@printBarCodeSet", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@binder", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@binderView", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoHole", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@gpcBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@veloBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@sprialBind", System.Data.SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@matchOriginals", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@drilling", System.Data.SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@twoSided", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@colorForColor", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@sizeForSize", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@slipsheets", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@staplePerDoc", System.Data.SqlDbType.VarChar, 3);
                cmd.Parameters.Add("@printSpecialInstructions", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsProduction", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@specialInstrucitonsData", System.Data.SqlDbType.VarChar);

                cmd.Parameters["@contactName"].Value = P_clientNameDropDown.SelectedValue;
                if (P_clientMatterTextBox.Text != "" || P_clientMatterTextBox.Text != null)
                {
                    cmd.Parameters["@clientMatter"].Value = P_clientMatterTextBox.Text;
                }
                else
                {
                    cmd.Parameters["@clientMatter"].Value = null;
                }
                if (Convert.ToInt32(P_printQuantityCleanDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printCleanSet"].Value = Convert.ToInt32(P_printQuantityCleanDropDown.SelectedValue);
                }
                if (Convert.ToInt32(P_printQuantityEBSedDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printEBSEDSet"].Value = Convert.ToInt32(P_printQuantityEBSedDropDown.SelectedValue);
                }
                if (Convert.ToInt32(P_printQuantityBarCodedDropDown.SelectedValue) > 0)
                {
                    cmd.Parameters["@printBarCodeSet"].Value = Convert.ToInt32(P_printQuantityBarCodedDropDown.SelectedValue);
                }

                if (Convert.ToInt32(P_printQuantityCleanDropDown.SelectedValue) > 0 || Convert.ToInt32(P_printQuantityEBSedDropDown.SelectedValue) > 0 || Convert.ToInt32(P_printQuantityBarCodedDropDown.SelectedValue) > 0)
                {
                    if (P_printBindersOptionRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@binder"].Value = P_printBindersSizeRadioButtonList.SelectedValue;
                        cmd.Parameters["@binderView"].Value = P_printBinderOptionViewRadioBttonList.SelectedValue;
                    }
                    if (P_printAccoRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@twoHole"].Value = P_printAccoSideRadioButtonList.SelectedValue;
                    }
                    if (P_printCombRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@gpcBind"].Value = P_printCombOptionsRadioBttonList.SelectedValue;
                    }
                    if (P_printVeloRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@veloBind"].Value = P_printVeloOptionRadioButtonList.SelectedValue;
                    }
                    if (P_printSpiralRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@spiralBind"].Value = P_printSpiralOptionsRadioButtonList.SelectedValue;
                    }
                    if (P_printMatchOriginalsRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@matchOriginals"].Value = "yes";
                    }
                    if (P_printDrillingRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@drilling"].Value = P_printDrillingOptionRadioButton.SelectedValue;
                    }
                    if (P_printingTwoSidedRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@twoSided"].Value = "yes";
                    }
                    if (P_printColor4ColorRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@colorForColor"].Value = "yes";
                    }
                    if (P_printSize4SizeRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@sizeForSize"].Value = "yes";
                    }
                    cmd.Parameters["@slipsheets"].Value = P_printSlipSheetsRadioButtonList.SelectedValue;
                    if (P_printStapleRadioButton.SelectedValue == "yes")
                    {
                        cmd.Parameters["@staplePerDoc"].Value = "yes";
                    }
                    if (P_specialInstrctionsPrintRadioButtonList.SelectedValue == "yes")
                    {
                        cmd.Parameters["@printSpecialInstructions"].Value = P_specialInstrctionsPrintTextBox.Text;
                    }
                    if (P_specialInstrctionsDataTextBox.Text != "" || P_specialInstrctionsDataTextBox.Text != null)
                    {
                        cmd.Parameters["@spcialInstructionsData"].Value = P_specialInstrctionsDataTextBox.Text;
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}