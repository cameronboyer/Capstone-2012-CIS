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
            addOrStatusMV.Visible = true;
            addOrStatusMV.SetActiveView(add);
            scanJob.SetActiveView(clientInfo);
            hideButtons();
            //hello

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
    }
}