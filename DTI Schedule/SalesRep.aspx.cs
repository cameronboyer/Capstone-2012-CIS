using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTI_Schedule
{
    public partial class SalesRep : System.Web.UI.Page
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

                if (!level.Equals("SalesRep") && !level.Equals("4"))
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
            hideButtons();


        }

        protected void addCopyButton_Click(object sender, EventArgs e)
        {
            //hide navbuttons
            navButtonsTable.Visible = false;

            copyJob.SetActiveView(C_clientInfo);
            hideButtons();
        }

        protected void S_addNext_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(S_naming);
        }

        private void hideButtons()
        {
            addScanButton.Visible = false;
            addCopyButton.Visible = false;
            addDataButton.Visible = false;
            addPrintButton.Visible = false;
        }

        private void showButtons()
        {
            addScanButton.Visible = true;
            addCopyButton.Visible = true;
            addDataButton.Visible = true;
            addPrintButton.Visible = true;
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

            //if (S_documentLevelCheckBoxList.SelectedValue == "Smallest Physical Bindings/Lowest" || S_documentLevelCheckBoxList.SelectedValue == "Per Slip Sheets - Target Sheets" || S_documentLevelCheckBoxList.SelectedValue == "Folder Tabs Determine Doc Break/per Folder" || S_documentLevelCheckBoxList.SelectedValue == "Binder Tabs Determine Doc Break" || S_documentLevelCheckBoxList.SelectedValue == "LDD")
            //{
            //    if (S_otherDocumentLevelTextBox.Visible == true)
            //    {
            //        S_otherDocumentLevelTextBox.Visible = true;
            //    }
            //    else
            //    {
            //        S_otherDocumentLevelTextBox.Visible = false;
            //    }
            //}
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
            }
            else
            {
                cdLabel.Visible = false;
                S_goToPrinting.Visible = true;
                S_goToPrinting2.Visible = false;
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
            }
            else
            {
                S_printAccoSideRadioButtonList.Visible = false;
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
            }
            else
            {
                D_printAccoSideRadioButtonList.Visible = false;
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
            }
            else
            {
                P_printAccoSideRadioButtonList.Visible = false;
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

        protected void S_contactNameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void S_clientNameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //used to query the db to get the address
            string contactName = S_contactNameDropDown.SelectedValue;

        }
    }
}