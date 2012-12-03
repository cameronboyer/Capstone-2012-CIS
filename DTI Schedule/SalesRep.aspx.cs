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

        }

        protected void addScanJob_Click(object sender, EventArgs e)
        {

            //hide navbuttons
            navButtonsTable.Visible = false;

            addOrStatusMV.Visible = true;
            addOrStatusMV.SetActiveView(add);
            scanJob.SetActiveView(S_clientInfo);
            hideButtons();


        }

        protected void statusButton_Click(object sender, EventArgs e)
        {
            addOrStatusMV.Visible = true;
            addOrStatusMV.SetActiveView(status);
            hideButtons();
        }

        protected void S_addNext_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(naming);
        }

        private void hideButtons()
        {
            addScanButton.Visible = false;
            addCopyButton.Visible = false;
            addDataButton.Visible = false;
            addPrintButton.Visible = false;
            statusButton.Visible = false;
        }

        private void showButtons()
        {
            addScanButton.Visible = true;
            addCopyButton.Visible = true;
            addDataButton.Visible = true;
            addPrintButton.Visible = true;
            statusButton.Visible = true;
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
            if (S_documentLevelCheckBoxList.SelectedValue == "Other")
            {
                S_otherDocumentLevelTextBox.Visible = true;
            }
            else
                S_otherDocumentLevelTextBox.Visible = false;
        }

        protected void S_groupingCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_groupingCheckBoxList.SelectedValue == "Other")
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
                S_pdfPer.Visible = false;
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
            if (S_ebsOtherPrefixTextBox.Text != null || S_ebsOtherPrefixTextBox.Text != "" || S_ebsOtherPrefixTextBox.Text != "Prefix for EBS" )
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
            scanJob.SetActiveView(cdBurning);
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
            scanJob.SetActiveView(printing);
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


    }
}