<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SalesRep.aspx.cs" Inherits="DTI_Schedule.SalesRep" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server" >
    <style type="text/css"> 
        .style1
        {
            width: 36px;
        }
        .style3
        {
            width: 554px;
        }
        .style4
        {
            width: 161px;
        }
        .style5
        {
            text-align: right;
        }
        .style6
        {
            width: 547px;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <table id="navButtonsTable" runat="server" style="width: 100%;">
        <tr>
            <td>
                <asp:Button ID="addScanButton" runat="server" Text="Add Scan Job" 
        onclick="addButton_Click"/>
            </td>
            <td>
                <asp:Button ID="statusButton" runat="server" Text="Status of Job" onclick="statusButton_Click" />
            </td>
        </tr>
        <tr>
            <td>
               <asp:Button ID="addCopyButton" runat="server" Text="Add Copy Job"/>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="addDataButton" runat="server" Text="Add Data Job"/>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
                <tr>
            <td>
               <asp:Button ID="addPrintButton" runat="server" Text="Add Print Job"/> 
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>

    <asp:MultiView ID="addOrStatusMV" runat="server" Visible="False" >
        <asp:View ID="add" runat="server">
            <asp:MultiView ID="scanJob" runat="server">
                <asp:View ID="clientInfo" runat="server">
                    <h1>Client Information</h1>
                    <table id="clientInfoTable" style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="clientNameLbl" runat="server" Text="Client Name:"/>
                            </td>
                            <td>
                               <asp:DropDownList ID="clientNameDropDown" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="contactNameLbl" runat="server" Text="Contact Name:"/>
                            </td>
                            <td>
                                 <asp:DropDownList ID="contactNameDropDown" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="addressLbl" runat="server" Text="Address:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="addressTextBox" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="phoneNumberLbl" runat="server" Text="Phone Number:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="phoneNumberTextBox" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="clientMatterLbl" runat="server" Text="Client Matter:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="clientMatterTextBox" runat="server"/>
                            </td>
                            <td>
                                <asp:Button ID="toNamingPage" runat="server" Text="Go to Control Number Naming" onclick="addNext_Click"/>
                            </td>
                        </tr>
                    </table>       
                </asp:View>
                <asp:View ID="naming" runat="server">
                    <h1>Naming</h1>
                    <table id="namingTable" style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="controlNumberPrefixLbl" runat="server" Text="Prefix:"/>
                                
                            </td>
                            <td>
                                <asp:TextBox ID="controlNumberPrefixTxt" runat="server"/>
                                
                            </td>
                            <td>
                               <asp:Label ID="reincrementingLbl" runat="server" Text="Re-increment:"/>  
                            </td>
                            <td rowspan="4">
                             <asp:CheckBox ID="reincrementingCheckBox" runat="server" Text='Yes at "0001"'/>
                                
                        <asp:RadioButtonList ID="reincrementingRadioList" runat="server">
                            <asp:ListItem Text="Per Document" Value="document" />
                            <asp:ListItem Text="Per Exhibit" Value="exhibit" />
                            <asp:ListItem Text="Per Folder" Value="folder" />
                        </asp:RadioButtonList>
                            </td>
                            
                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="controlNumberBoxLbl" runat="server" Text="Box#/Exhibit/Other:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="controlNumberBoxTxt" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="conrolNumberIncrementingNumberLbl" runat="server" Text="Incrementing Number:"/>
                            </td>
                            <td>
                               <asp:TextBox ID="conrolNumberIncrementingNumberTxt" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="controlNumberLbl0" runat="server" Text="Control Number:" />
                            </td>
                            <td>
                                <asp:TextBox ID="controlNumberTxt" runat="server" />
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                            <!-- needs input -->
                            <asp:Label ID="spaceInControlNumberLbl" runat="server" Text="Space In Control Number:"/>
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label ID="volumeLbl" runat="server" Text="First Volume Name:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="volumeTextBox" runat="server"/>
                            </td>
                            <td>
                                 <asp:Button ID="toDocumentLevel" runat="server" Text="Go to Document Level" onclick="toDocumentLevel_Click" />
                            </td>
                        </tr>
                    </table>    
                </asp:View>
                <asp:View ID="documentLevel" runat="server">
                    <h1>Document Level</h1>
                    <table id="documentLevelTable" style="width: 100%;">
                        <tr>
                            <td rowspan="5">
                      <asp:CheckBoxList ID="documentLevelCheckBoxList" runat="server" AutoPostBack="True" onselectedindexchanged="documentLevelCheckBoxList_SelectedIndexChanged">
                            <asp:ListItem Value="Smallest Physical Bindings/Lowest" Text="Smallest Physical Bindings/Lowest" />
                            <asp:ListItem Value="Per Slip Sheets - Target Sheets" Text="Per Slip Sheets - Target Sheets" />
                            <asp:ListItem Value="Folder Tabs Determine Doc Break/per Folder" Text="Folder Tabs Determine Doc Break/per Folder" />
                            <asp:ListItem Value="Binder Tabs Determine Doc Break" Text="Binder Tabs Determine Doc Break" />
                            <asp:ListItem Value="LDD" Text="LDD" />
                            <asp:ListItem Value="Other" Text="Other:" />
                        </asp:CheckBoxList>
                                &nbsp; &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                                </td>
                            <td>
                                &nbsp;
                                </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="otherDocumentLevelTextBox" runat="server" Visible="false" />
                                </td>
                            <td>
                               <asp:Button ID="goToGrouping" runat="server" Text="Go To Grouping" onclick="goToGrouping_Click" />
                               </td>
                        </tr>
                    </table>      
                </asp:View>
                <asp:View ID="grouping" runat="server">
                    <h1>Grouping</h1>
                    <table id="groupingTable" style="width: 100%;">
                        <tr>
                            <td rowspan="6">
                   <asp:CheckBoxList ID="groupingCheckBoxList" runat="server" AutoPostBack="True" onselectedindexchanged="groupingCheckBoxList_SelectedIndexChanged">
                            <asp:ListItem Value="Box" Text="Box" />
                            <asp:ListItem Value="Folder" Text="Folder" />
                            <asp:ListItem Value="Document" Text="Document" />
                            <asp:ListItem Value="Child" Text="Child" />
                            <asp:ListItem Value="Other" Text="Other:" />
                        </asp:CheckBoxList>
                                                        &nbsp; &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="otherGroupingTextBox" runat="server" Visible="false" />
                            </td>
                            <td>
                               <asp:Button ID="goToScanning" runat="server" Text="Go To Scanning" onclick="goToScanning_Click" />
                            </td>
                        </tr>
                    </table>   
                </asp:View>
                <asp:View ID="scanning" runat="server">
                    <h1>Scanning</h1>
                    <table style="width: 100%;">
                        <tr>
                            <td>
                               <asp:CheckBox ID="pickAndChoose" Text="Pick and Choose(See Special Instructions)" runat="server"/></td>
                            <td>
                                 <asp:CheckBox ID="scanAllPortrait" Text="Scan All Paper Portrait" runat="server"/></td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="yesColOne" runat="server" Text="Yes" />
                        <asp:Label ID="noColOne" runat="server" Text="No"/></td>
                            <td>
                               <asp:Label ID="yesColTwo" runat="server" Text="Yes"/>
                        <asp:Label ID="noColTwo" runat="server" Text="No"/></td>
                        </tr>
                        <tr>
                            <td>
                        <asp:RadioButtonList ID="coversRadioButtonList" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Covers" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="redweldFolderCovers" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Redweld/Folder Covers" />
                        </asp:RadioButtonList>
    
                        <asp:RadioButtonList ID="redweldFolderTabs" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Redweld/Folder Tabs" />
                        </asp:RadioButtonList>
    
                        <asp:RadioButtonList ID="dividerTabs" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Divider Tabs" />
                        </asp:RadioButtonList>
                    
                        <asp:RadioButtonList ID="postitNotes" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" onselectedindexchanged="postitNotes_SelectedIndexChanged">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Post It Notes" />
                        </asp:RadioButtonList>&nbsp; 
                                <asp:RadioButtonList ID="postItNoteInstruction" runat="server" RepeatDirection="Horizontal" Visible="False">
                                    <asp:ListItem Text="On" Value="on" />
                                    <asp:ListItem Text="One On/One Off" Value="oneOnOneOff" />
                                    <asp:ListItem Text="Separtely" Value="separtely" />
                                </asp:RadioButtonList>
                                &nbsp;
                            </td>
                            <td>
                                <asp:RadioButtonList ID="coloredSheets" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Colored Sheets" />
                        </asp:RadioButtonList>
                        <asp:RadioButtonList ID="binderSpines" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Binder Spines" />
                        </asp:RadioButtonList>
                    
                        <asp:RadioButtonList ID="envelopes" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Envelopes" />
                        </asp:RadioButtonList>
                    
                        <asp:RadioButtonList ID="standardLang" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Standard Lang." /> 
                        </asp:RadioButtonList>
                    
                        <asp:RadioButtonList ID="carbon" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Carbon" />
                        </asp:RadioButtonList>&nbsp; &nbsp; &nbsp; </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="reduceToCheckBox" runat="server" Text="Reduce To:" AutoPostBack="True" oncheckedchanged="reduceToCheckBox_CheckedChanged" />
                                <asp:RadioButtonList ID="reduceToRadioButtonList" runat="server" 
                                    AutoPostBack="True" 
                                    onselectedindexchanged="reduceToRadioButtonList_SelectedIndexChanged" 
                                    RepeatDirection="Horizontal" Visible="False">
                                    <asp:ListItem Text="11 X 17" Value="11 X 17" />
                                    <asp:ListItem Text="Other" Value="other" />
                                </asp:RadioButtonList>
                                <asp:TextBox ID="reduceToOtherTextBox" runat="server" Visible="False" />
                                <asp:CheckBox ID="sizeForSizeCheckBox" runat="server" Text="Size for Size" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                                <asp:Label ID="colorLbl" runat="server" Text="Color:" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td >
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="colorColOne" runat="server" Text="Color" />
                                <asp:Label ID="B_WColOne" runat="server" Text="B&amp;W" />
                            </td>
                            <td>
                               <asp:Label ID="colorColTwo" runat="server" Text="Color"/>
                        <asp:Label ID="B_WColTwo" runat="server" Text="B&W"/></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButtonList ID="any_allColor" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Any/All Color" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="highlights" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Highlights" />
                        </asp:RadioButtonList>
    
                        <asp:RadioButtonList ID="photosFront" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Photos Front" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="photosBack" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Photos Back" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="colorCopies" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Color Copies" />
                        </asp:RadioButtonList></td>
                            <td>
                                <asp:RadioButtonList ID="handwrittenColor" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Handwritten Color" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="printingPressColor" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Printing Press Color" />
                        </asp:RadioButtonList>
    
                        <asp:RadioButtonList ID="chartsGraphsColor" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Charts/Graphs Color" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="colorHandStamps" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Color Hand Stamps" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="oversize" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Oversized(Create Tag)" />
                        </asp:RadioButtonList></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="goToMedia0" runat="server" onclick="goToMedia_Click" 
                                    Text="Go to Media" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="mediaView" runat="server">
                    <h1>Media</h1>
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="yesCol" runat="server" Text="Yes" />
                                <asp:Label ID="noCol" runat="server" Text="No" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButtonList ID="scanAndTagMedia" runat="server" 
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Text="" Value="yes" />
                                    <asp:ListItem Text="Scan and Tag as MEDIA" Value="no" />
                                </asp:RadioButtonList>
                                <asp:RadioButtonList ID="duplicateAndTagMedia" runat="server" 
                                    AutoPostBack="True" 
                                    onselectedindexchanged="duplicateAndTagMedia_SelectedIndexChanged" 
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Text="" Value="yes" />
                                    <asp:ListItem Text="Duplicate and tag as MEDIA" Value="no" />
                                </asp:RadioButtonList>
                                <asp:TextBox ID="numberOfDuplicatesTextBox" runat="server" 
                                    Text="Enter Number of Duplicates" Visible="false" />
                                <asp:RadioButtonList ID="bateLabelAndTagMedia" runat="server" 
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Text="" Value="yes" />
                                    <asp:ListItem Text="Bate Label and tag as MEDIA" Value="no" />
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp; </td>
                            <td>
                                <asp:Button ID="goToDeliverable" runat="server" onclick="goToDeliverable_Click" 
                                    Text="Go to Deliverable" />
                            </td>
                        </tr>
                    </table>   
                </asp:View>
                <asp:View ID="deliverable" runat="server">
                <h1>Deliverable</h1><table style="width: 100%;">
        <tr>
            <td class="style4" rowspan="7">
                <asp:CheckBoxList ID="deliverables" runat="server" AutoPostBack="True" 
                    Height="185px" onselectedindexchanged="deliverables_SelectedIndexChanged">
                    <asp:ListItem Text="DTI Standard" Value="dtiStandard" />
                    <asp:ListItem Text="Concordance" Value="concordance" />
                    <asp:ListItem Text="Summation" Value="summation" />
                    <asp:ListItem Text="IPRO" Value="ipro" />
                    <asp:ListItem Text="Sanction/Trial Director" Value="sanction_TrialDirector" />
                    <asp:ListItem Text="PDF" Value="pdf" />
                    <asp:ListItem Text="Other" Value="other" />
                </asp:CheckBoxList>
                &nbsp; &nbsp;
            </td>
            <td class="style13">
                &nbsp;</td>
            <td class="style14">
                &nbsp;</td>
        </tr>
                    <tr>
                        <td class="style13">
                            &nbsp;</td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style13">
                            &nbsp;</td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style13">
                            &nbsp;</td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style13">
                            &nbsp;
                        </td>
                        <td class="style14">
                            &nbsp;
                        </td>
                    </tr>
        <tr>
            <td class="style10">
                <asp:RadioButtonList ID="pdfPer" runat="server" RepeatDirection="Horizontal" 
                    AutoPostBack="True" onselectedindexchanged="pdfPer_SelectedIndexChanged" 
                    Visible="false">
                        <asp:ListItem Value="document" Text="PDF per Document" Enabled="true" />
                        <asp:ListItem Value="folder" Text="PDF per Folder" />
                        <asp:ListItem Text="PDF per Other" Value="other" />
                    </asp:RadioButtonList>
            </td>
            <td>
                <asp:TextBox ID="pdfPerTextBox" runat="server" Visible="false" Width="158px" />
            </td>
        </tr>
        <tr>
            <td class="style15">
                <asp:TextBox ID="deliverablesOtherTextBox" runat="server" Visible="false" 
                    Width="202px" />
            </td>
            <td class="style16">
                &nbsp;
            </td>
        </tr>
                    <tr>
                        <td colspan="3">
                            Viewer:
                            <asp:RadioButtonList ID="viewer" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Selected="True" Text="None" Value="no" />
                                <asp:ListItem Text="Eddie" Value="eddie" />
                                <asp:ListItem Text="Eddie w/Fielded Info" Value="eddieFielded" />
                                <asp:ListItem Text="Ipublish" Value="ipublish" />
                                <asp:ListItem Text="Searchable Ipublish" Value="searchableIpublish" />
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="gotoIndexingInstructions" runat="server" 
                                onclick="gotoIndexingInstructions_Click" Text="Go to Indexing Instructions" />
                        </td>
                    </tr>
    </table>
                    

    
                    

                    
                </asp:View> 
                <asp:View ID="indexingInstructions" runat="server">
                <h1>Indexing Instructions</h1>
                            <table id="indexingInsructions" style="width: 100%;">
                                <tr>
                                    <td class="style17">
                                        Do Not Export
                                    </td>
                                    <td>
                                        Field Description
                                    </td>
                                    <td colspan="3">
                                        Default Information
                                    </td>
                                    <td>
                                        Prompted
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Text 1
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textOneTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Text 2
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textTwoTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Text 3
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textThreeTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Text 4
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textFourTextBox" runat="server" Width="440px"  />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Text 5
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textFiveTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Text 6
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textSixTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Text 7
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textSevenTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                       Text 8
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="textEightTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                       Tag 1
                                    </td>
                                    <td colspan="3">
                                        <asp:RadioButtonList ID="tagOneRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="enter" Text="Enter" />
                                            <asp:ListItem Value="yn" Text="Y/N" />
                                            <asp:ListItem Value="yesno" Text="Yes/No" />
                                            <asp:ListItem Value="fieldDescripton" Text="Field Descripton" />
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Tag 2
                                    </td>
                                    <td colspan="3">
                                        <asp:RadioButtonList ID="tag2RadioButtonList" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="enter" Text="Enter" />
                                            <asp:ListItem Value="yn" Text="Y/N" />
                                            <asp:ListItem Value="yesno" Text="Yes/No" />
                                            <asp:ListItem Value="fieldDescripton" Text="Field Descripton" />
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Tag 3
                                    </td>
                                    <td colspan="3">
                                        <asp:RadioButtonList ID="tagThreeRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="enter" Text="Enter" />
                                            <asp:ListItem Value="yn" Text="Y/N" />
                                            <asp:ListItem Value="yesno" Text="Yes/No" />
                                            <asp:ListItem Value="fieldDescripton" Text="Field Descripton" />
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Tag 4
                                    </td>
                                    <td colspan="3">
                                        <asp:RadioButtonList ID="tagFourRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="enter" Text="Enter" />
                                            <asp:ListItem Value="yn" Text="Y/N" />
                                            <asp:ListItem Value="yesno" Text="Yes/No" />
                                            <asp:ListItem Value="fieldDescripton" Text="Field Descripton" />
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Tag Color
                                    </td>
                                    <td colspan="3">
                                        <asp:RadioButtonList ID="tagColorRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="enter" Text="Enter" />
                                            <asp:ListItem Value="yn" Text="Y/N" />
                                            <asp:ListItem Value="yesno" Text="Yes/No" />
                                            <asp:ListItem Value="fieldDescripton" Text="Field Descripton" />
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Tag Oversize
                                    </td>
                                    <td colspan="3">
                                        <asp:RadioButtonList ID="tagOversizeRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="enter" Text="Enter" />
                                            <asp:ListItem Value="yn" Text="Y/N" />
                                            <asp:ListItem Value="yesno" Text="Yes/No" />
                                            <asp:ListItem Value="fieldDescripton" Text="Field Descripton" />
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td>
                                        Tag Media
                                    </td>
                                    <td colspan="3">
                                        <asp:RadioButtonList ID="tagMediaRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="enter" Text="Enter" />
                                            <asp:ListItem Value="yn" Text="Y/N" />
                                            <asp:ListItem Value="yesno" Text="Yes/No" />
                                            <asp:ListItem Value="fieldDescripton" Text="Field Descripton" />
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:Button ID="goToEBS" runat="server" onclick="goToEBS_Click" 
                                            Text="Go To EBS Instructions" />
                                    </td>
                                    <td colspan="2">
                                        &nbsp;</td>
                                </tr>
                            </table>
                </asp:View>
                <asp:View ID="ebsInstructions" runat="server">
                <h1>EBS Instructions</h1>

                    <table style="width: 100%;">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td rowspan="5">
                                <asp:RadioButtonList ID="S_ebsNumberingRadioButtonList" runat="server" 
                                    AutoPostBack="True" 
                                    onselectedindexchanged="S_ebsNumberingRadioButtonList_SelectedIndexChanged" 
                                    Visible="false">
                                    <asp:ListItem Selected="True" Text="EBS Control Number" 
                                        Value="ebsControlNumber" />
                                    <asp:ListItem Text="EBS Other" Value="ebsOther" />
                                </asp:RadioButtonList>
                                <br />
                                <asp:TextBox ID="S_ebsOtherPrefixTextBox" runat="server" AutoPostBack="True" 
                                    ontextchanged="S_ebsOtherPrefixTextBox_TextChanged" Text="Prefix for EBS" 
                                    Visible="false" Width="165px" />
                                <br />
                                <asp:TextBox ID="S_ebsOtherStartNumberTextBox" runat="server" 
                                    AutoPostBack="True" ontextchanged="S_ebsOtherStartNumberTextBox_TextChanged" 
                                    Text="Starting Number for EBS" Visible="false" Width="165px" />
                                <br />
                                <asp:TextBox ID="S_ebsOtherSuffixTextBox" runat="server" AutoPostBack="True" 
                                    ontextchanged="S_ebsOtherSuffixTextBox_TextChanged" Text="Suffix for EBS" 
                                    Visible="false" Width="165px" />
                                <br />
                                <asp:Label ID="S_ebsOtherNewControlNumberLabel" runat="server" 
                                    Text="New Control Number for EBS:" Visible="false" />
                                <br />
                                <asp:TextBox ID="S_ebsOtherControlNumberTextBox" runat="server" ReadOnly="true" 
                                    Visible="false" />
                            </td>
                            <td rowspan="3">
                                <asp:Label ID="S_ebsLocationLabel" runat="server" Text="EBS Location" 
                                    Visible="false" />
                                <asp:RadioButtonList ID="S_ebsLocationsRadioButtonList" runat="server" 
                                    RepeatColumns="3" RepeatDirection="Horizontal" RepeatLayout="Table" 
                                    Visible="false">
                                    <asp:ListItem Selected="True" Text="Lower Right(Default)" Value="lowerRight" />
                                    <asp:ListItem Text="Lower Left" Value="lowerLeft" />
                                    <asp:ListItem Text="Lower Center" Value="lowerCenter" />
                                    <asp:ListItem Text="Upper Right" Value="upperRight" />
                                    <asp:ListItem Text="Upper Left" Value="upperLeft" />
                                    <asp:ListItem Text="Upper Center" Value="upperCenter" />
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButtonList ID="S_ebsOptionsRadioButtonList" runat="server" 
                                    AutoPostBack="True" 
                                    onselectedindexchanged="S_ebsOptionsRadioButtonList_SelectedIndexChanged" 
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Selected="True" Text="No" Value="no" />
                                    <asp:ListItem Text="Yes" Value="yes" />
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td rowspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="S_ebsAdditionalLines" runat="server" Text="Addtional Lines" 
                                    Visible="false" />
                                <asp:RadioButtonList ID="S_ebsAddtionalLinesRadioButtonList" runat="server" 
                                    Visible="false">
                                    <asp:ListItem Selected="True" Text="No" Value="no" />
                                    <asp:ListItem Text="Yes" Value="yes" />
                                </asp:RadioButtonList>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                                <asp:Button ID="S_goToCdBurningButton" runat="server" 
                                    onclick="S_goToCdBurningButton_Click" Text="Go To CD Burining" />
                            </td>
                        </tr>
                    </table>

                </asp:View>
                <asp:View ID="cdBurning" runat="server">
                    <h1>CD Burn</h1>
                        <table style="width: 100%;">
                            <tr>
                                <td class="style24">
                                    DVD Disc<br />
                                    <asp:RadioButtonList ID="S_dvdOptionRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="yes" Text="Yes" Selected="True" />
                                        <asp:ListItem Value="no" Text="No" />
                                    </asp:RadioButtonList>
                                </td>
                                <td class="style18" colspan="6">
                                    <asp:Label ID="S_duplicateExhisitingLabel" runat="server" Text="Duplicate Existing Client Label" Visible="false" />
                                    <asp:RadioButtonList ID="S_duplicateExhisitingClientLabelRadioButtonList" runat="server" Visible="false" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="yes" Text="Yes" Selected="True" />
                                        <asp:ListItem Value="no" Text="No" />
                                    </asp:RadioButtonList>
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="style38">
                                    Firm
                                </td>
                                <td class="style27">
                                    # of Copies<br />
                                    
                                </td>
                                <td class="style30">
                                    Tiff
                                </td>
                                <td class="style21">
                                    Multipage Tiff
                                </td>
                                <td class="style30">
                                    OCR
                                </td>
                                <td class="style32">
                                    PDF
                                </td>
                                <td class="style37">
                                    Seachable PDF
                                </td>
                                <td class="style36">
                                    PDF w/Bookmarks
                                </td>
                            </tr>
                            <tr>
                                <td class="style38">
                                    <asp:TextBox ID="S_cdBurnInfoFirmOneTextBox" runat="server" ReadOnly="true" 
                                        Width="238px" />
                                </td>
                                <td class="style27">
                                    <asp:DropDownList ID="S_cdBurnCopiesFirmOneDropDown" runat="server" 
                                        AutoPostBack="True" 
                                        onselectedindexchanged="S_cdBurnCopiesDropDown_SelectedIndexChanged">
                                        <asp:ListItem Value="0" Text="0" Selected="True" />
                                        <asp:ListItem Value="1" Text="1" />
                                        <asp:ListItem Value="2" Text="2" />
                                        <asp:ListItem Value="3" Text="3" />
                                        <asp:ListItem Value="4" Text="4" />
                                        <asp:ListItem Value="5" Text="5" />
                                        <asp:ListItem Value="6" Text="6" />
                                        <asp:ListItem Value="7" Text="7" />
                                        <asp:ListItem Value="8" Text="8" />
                                        <asp:ListItem Value="9" Text="9" />
                                        <asp:ListItem Value="10" Text="10" />
                                    </asp:DropDownList>
                                </td>
                                <td class="style30">
                                    <asp:CheckBox ID="S_cdBurnTiffFirmOneCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style21">
                                    <asp:CheckBox ID="S_cdBurnMTiffFirmOneCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style30">
                                    <asp:CheckBox ID="S_cdBurnOCRFirmOneCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style32">
                                    <asp:CheckBox ID="S_cdBurnPDFFirmOneCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style37">
                                    <asp:CheckBox ID="S_cdBurnSeachablePDFFirmOneCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style36">
                                    <asp:CheckBox ID="S_cdBurnPDF_w_BookmarksFirmOneCheckBox" runat="server" Text=" " />
                                </td>
                            </tr>
                            <tr>
                                <td class="style38">
                                    <asp:TextBox ID="S_cdBurnInfoFirmTwoTextBox" runat="server" ReadOnly="true" 
                                        Width="238px" />
                                </td>
                                <td class="style27">
                                    <asp:DropDownList ID="S_cdBurnCopiesFirmTwoDropDown" runat="server" 
                                        AutoPostBack="True" 
                                        onselectedindexchanged="S_cdBurnCopiesDropDown_SelectedIndexChanged">
                                        <asp:ListItem Value="0" Text="0" Selected="True" />
                                        <asp:ListItem Value="1" Text="1" />
                                        <asp:ListItem Value="2" Text="2" />
                                        <asp:ListItem Value="3" Text="3" />
                                        <asp:ListItem Value="4" Text="4" />
                                        <asp:ListItem Value="5" Text="5" />
                                        <asp:ListItem Value="6" Text="6" />
                                        <asp:ListItem Value="7" Text="7" />
                                        <asp:ListItem Value="8" Text="8" />
                                        <asp:ListItem Value="9" Text="9" />
                                        <asp:ListItem Value="10" Text="10" />
                                    </asp:DropDownList>
                                </td>
                                <td class="style30">
                                    <asp:CheckBox ID="S_cdBurnTiffFirmTwoCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style21">
                                    <asp:CheckBox ID="S_cdBurnMTiffFirmTwoCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style30">
                                    <asp:CheckBox ID="S_cdBurnOCRFirmTwoCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style32">
                                    <asp:CheckBox ID="S_cdBurnPDFFirmTwoCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style37">
                                    <asp:CheckBox ID="S_cdBurnSeachablePDFFirmTwoCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style36">
                                    <asp:CheckBox ID="S_cdBurnPDF_w_BookmarksFirmTwoCheckBox" runat="server" Text=" " />
                                </td>
                            </tr>
                            <tr>
                                <td class="style38">
                                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="true" 
                                        Width="238px" />
                                </td>
                                <td class="style27">
                                    <asp:DropDownList ID="S_cdBurnCopiesFirmThreeDropDown" runat="server" 
                                        AutoPostBack="True" 
                                        onselectedindexchanged="S_cdBurnCopiesDropDown_SelectedIndexChanged">
                                        <asp:ListItem Value="0" Text="0" Selected="True" />
                                        <asp:ListItem Value="1" Text="1" />
                                        <asp:ListItem Value="2" Text="2" />
                                        <asp:ListItem Value="3" Text="3" />
                                        <asp:ListItem Value="4" Text="4" />
                                        <asp:ListItem Value="5" Text="5" />
                                        <asp:ListItem Value="6" Text="6" />
                                        <asp:ListItem Value="7" Text="7" />
                                        <asp:ListItem Value="8" Text="8" />
                                        <asp:ListItem Value="9" Text="9" />
                                        <asp:ListItem Value="10" Text="10" />
                                    </asp:DropDownList>
                                </td>
                                <td class="style30">
                                    <asp:CheckBox ID="S_cdBurnTiffFirmThreeCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style21">
                                    <asp:CheckBox ID="S_cdBurnMTiffFirmThreeCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style30">
                                    <asp:CheckBox ID="S_cdBurnOCRFirmThreeCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style32">
                                    <asp:CheckBox ID="S_cdBurnPDFFirmThreeCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style37">
                                    <asp:CheckBox ID="S_cdBurnSeachablePDFFirmThreeCheckBox" runat="server" Text=" " />
                                </td>
                                <td class="style36">
                                    <asp:CheckBox ID="S_cdBurnPDF_w_BookmarksFirmThreeCheckBox" runat="server" Text=" " />
                                </td>
                            </tr>
                        </table>
                        <br /><br />
                        <table style="width: 100%;">
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td class="style3">
                                    &nbsp;
                                </td>
                                <td>
                                   <asp:Button ID="S_goToPrinting" runat="server" Text="Go To Printing" 
                                        onclick="S_goToPrinting_Click" />
                                </td>
                            </tr>
                        </table>                    
                    <table id="cdLabel" style="width: 100%;" runat="server" visible="false">
                        <tr>
                            <td>
                                <h1>CD Label</h1>
                            </td>
                            <td>
                                (will appear in this order on disk)
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Firm Name
                            </td>
                            <td>
                                (Always Included)
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Case
                            </td>
                            <td>
                                <asp:TextBox ID="S_cdLabelCaseNameTextBox" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Volume
                            </td>
                            <td>
                                (Always Included)
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Bates Range
                            </td>
                            <td>
                                <asp:RadioButtonList ID="S_cdLabelBatesRangeRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" Selected="True" />
                                    <asp:ListItem Value="no" Text="No" />
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Number Of Images
                            </td>
                            <td>
                                (Always Included)
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Client Matter
                            </td>
                            <td>
                                <asp:TextBox ID="S_cdLabelClientMatterTextBox" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Notes
                            </td>
                            <td>
                                <asp:TextBox ID="S_cdLabelNotesTextBox" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                Date Burned
                            </td>
                            <td>
                                (Always Included)
                            </td>
                        </tr>
                    </table>
                    <table style="width: 100%;">
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td class="style6">
                                    &nbsp;
                                </td>
                                <td>
                                   <asp:Button ID="S_goToPrinting2" runat="server" Text="Go To Printing" 
                                        Visible="false" onclick="S_goToPrinting2_Click" />
                                </td>
                            </tr>
                        </table>
                    
                </asp:View>
            </asp:MultiView>
        </asp:View>
        <asp:View ID="status" runat="server">
        </asp:View>
    </asp:MultiView>
</asp:Content>

<asp:Content ContentPlaceHolderID="HeaderContent" runat="server">
    <span class="style1">Sales Rep</span>
    
</asp:Content>

