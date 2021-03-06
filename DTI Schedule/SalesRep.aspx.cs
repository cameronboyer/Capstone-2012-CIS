﻿using System;
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

        protected void addButton_Click(object sender, EventArgs e)
        {

            //hide navbuttons
            navButtonsTable.Visible = false;


            addOrStatusMV.Visible = true;
            addOrStatusMV.SetActiveView(add);
            scanJob.SetActiveView(clientInfo);
            hideButtons();


        }

        protected void statusButton_Click(object sender, EventArgs e)
        {
            addOrStatusMV.Visible = true;
            addOrStatusMV.SetActiveView(status);
            hideButtons();
        }

        protected void addNext_Click(object sender, EventArgs e)
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

        protected void toDocumentLevel_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(documentLevel);
        }


        protected void goToGrouping_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(grouping);
        }

        protected void documentLevelCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (documentLevelCheckBoxList.SelectedValue == "Other")
            {
                otherDocumentLevelTextBox.Visible = true;
            }
            else
                otherDocumentLevelTextBox.Visible = false;
        }

        protected void groupingCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupingCheckBoxList.SelectedValue == "Other")
            {
                otherGroupingTextBox.Visible = true;
            }
            else
                otherGroupingTextBox.Visible = false;
        }

        protected void goToScanning_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(scanning);
        }

        protected void goToMedia_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(mediaView);
        }

        protected void postitNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (postitNotes.SelectedValue == "yes")
            {
                postItNoteInstruction.Visible = true;
            }
            else
                postItNoteInstruction.Visible = false;
        }

        protected void reduceToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reduceToCheckBox.Checked)
            {
                reduceToRadioButtonList.Visible = true;
            }
            else
                reduceToRadioButtonList.Visible = false;
        }

        protected void reduceToRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reduceToRadioButtonList.SelectedValue == "other")
            {
                reduceToOtherTextBox.Visible = true;
            }
            else
                reduceToOtherTextBox.Visible = false;
        }

        protected void duplicateAndTagMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (duplicateAndTagMedia.SelectedValue == "yes")
            {
                numberOfDuplicatesTextBox.Visible = true;
            }
            else
                numberOfDuplicatesTextBox.Visible = false;
        }

        protected void goToDeliverable_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(deliverable);
        }

        protected void deliverables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (ListItem item in deliverables.Items)
            //{
            //    if (item.Selected == true)
            //    {
            //        if (item.Value == "pdf")
            //        {
            //            pdfPer.Visible = true;
            //        }
            //        else
            //            pdfPer.Visible = false;
                    
            //        if(item.Value == "other")
            //        {
            //            deliverablesOtherTextBox.Visible = true;
            //        }
            //        else
            //            deliverablesOtherTextBox.Visible = false;
            
            //}

            if (deliverables.SelectedValue == "pdf")
            {
                pdfPer.Visible = true;
            }
            else
            {
                pdfPer.Visible = false;
                pdfPerTextBox.Visible = false;
            }

            if (deliverables.SelectedValue == "other")
            {

                deliverablesOtherTextBox.Visible = true;
            }
            else
                deliverablesOtherTextBox.Visible = false;
        }

        protected void pdfPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pdfPer.SelectedValue == "other" && deliverables.SelectedValue == "pdf")
            {
                pdfPerTextBox.Visible = true;
            }
            else
                pdfPerTextBox.Visible = false;
        }

        protected void gotoIndexingInstructions_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(indexingInstructions);
        }

        protected void goToEBS_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(ebsInstructions);
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

        protected void S_ebsOptionsRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S_ebsOptionsRadioButtonList.SelectedValue == "yes")
            {
                S_ebsNumberingRadioButtonList.Visible = true;
                S_ebsLocationLabel.Visible = true;
                S_ebsLocationsRadioButtonList.Visible = true;
                S_ebsAdditionalLines.Visible = true;
                S_ebsAddtionalLinesRadioButtonList.Visible = true;
            }
            else
            {
                S_ebsNumberingRadioButtonList.Visible = false;
                S_ebsLocationLabel.Visible = false;
                S_ebsLocationsRadioButtonList.Visible = false;
                S_ebsAdditionalLines.Visible = false;
                S_ebsAddtionalLinesRadioButtonList.Visible = false;
            }
        }

        protected void S_goToCdBurningButton_Click(object sender, EventArgs e)
        {
            scanJob.SetActiveView(cdBurning);
        }

        protected void S_goToPrinting2_Click(object sender, EventArgs e)
        {

        }

        protected void S_goToPrinting_Click(object sender, EventArgs e)
        {

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

    }
}