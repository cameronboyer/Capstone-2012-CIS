<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SalesRep.aspx.cs" Inherits="DTI_Schedule.SalesRep" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server" >
    <style type="text/css"> 
        .style1
        {
            width: 618px;
        }
        .style2
        {
            width: 158px;
        }
        .style10
        {
            width: 360px;
        }
        .style13
        {
            width: 360px;
            height: 98px;
        }
        .style14
        {
            height: 98px;
        }
        .style15
        {
            width: 360px;
            height: 4px;
        }
        .style16
        {
            height: 4px;
        }
        .style17
        {
            width: 48px;
        }
        .style18
        {
            height: 14px;
        }
        .style21
        {
            text-align: center;
            width: 60px;
        }
        .style24
        {
            height: 14px;
            width: 120px;
        }
        .style27
        {
            width: 28px;
            text-align: center;
        }
        .style30
        {
            text-align: center;
            width: 30px;
        }
        .style32
        {
            text-align: center;
            width: 24px;
        }
        .style36
        {
            width: 73px;
            text-align: center;
        }
        .style37
        {
            text-align: center;
            width: 42px;
        }
        .style38
        {
            width: 120px;
        }
        .style39
        {
            text-align: right;
            width: 116px;
        }
        .style40
        {
            width: 571px;
        }
        .style41
        {
            width: 600px;
        }
        .style44
        {
            width: 352px;
        }
        .style45
        {
            width: 352px;
            height: 108px;
        }
        .style46
        {
            width: 54px;
        }
        .style47
        {
            width: 250px;
        }
        .style48
        {
            height: 21px;
        }
        .style49
        {
        }
        .style50
        {
            width: 251px;
        }
        .style53
        {
            width: 111px;
        }
        .style54
        {
            width: 165px;
        }
        .style56
        {
            text-align: left;
            width: 116px;
        }
        .style57
        {
            text-align: left;
            width: 144px;
        }
        .style58
        {
            width: 247px;
        }
        .style59
        {
            width: 89px;
        }
        .style61
        {
            width: 288px;
        }
        .style62
        {
            width: 352px;
            height: 4px;
        }
        .style65
        {
            width: 36px;
        }
        .style66
        {
            width: 88px;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <table id="navButtonsTable" runat="server" style="width: 100%;">
        <tr>
            <td class="style59">
                &nbsp;</td>
            <td class="style58">
                <asp:Button ID="addScanButton" runat="server" Text="Add Scan Job" onclick="addScanJob_Click"/>
            </td>
            <td>
                <asp:Button ID="statusButton" runat="server" Text="Status of Job" onclick="statusButton_Click" />
            </td>
        </tr>
        <tr>
            <td class="style59">
                &nbsp;</td>
            <td class="style58">
               <asp:Button ID="addCopyButton" runat="server" Text="Add Copy Job"/>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style59">
                &nbsp;</td>
            <td class="style58">
                <asp:Button ID="addDataButton" runat="server" Text="Add Data Job"/>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
                <tr>
            <td class="style59">
                &nbsp;</td>
            <td class="style58">
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
                <asp:View ID="S_clientInfo" runat="server">
                    <h1>Client Information</h1>
                    <table id="S_clientInfoTable" style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="S_clientNameLbl" runat="server" Text="Client Name:"/>
                            </td>
                            <td>
                               <asp:DropDownList ID="S_clientNameDropDown" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="S_contactNameLbl" runat="server" Text="Contact Name:"/>
                            </td>
                            <td>
                                 <asp:DropDownList ID="S_contactNameDropDown" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="S_addressLbl" runat="server" Text="Address:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="S_addressTextBox" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="S_phoneNumberLbl" runat="server" Text="Phone Number:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="S_phoneNumberTextBox" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="S_clientMatterLbl" runat="server" Text="Client Matter:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="S_clientMatterTextBox" runat="server"/>
                            </td>
                            <td>
                                <asp:Button ID="S_toNamingPage" runat="server" Text="Go to Control Number Naming" onclick="S_addNext_Click"/>
                            </td>
                        </tr>
                    </table>       
                </asp:View>
                <asp:View ID="naming" runat="server">
                    <h1>Naming</h1>
                    <table id="S_namingTable" style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="S_controlNumberPrefixLbl" runat="server" Text="Prefix:"/>
                                
                            </td>
                            <td>
                                <asp:TextBox ID="S_controlNumberPrefixTxt" runat="server"/>
                                
                            </td>
                            <td>
                               <asp:Label ID="S_reincrementingLbl" runat="server" Text="Re-increment:"/>  
                            </td>
                            <td rowspan="4">
                             <asp:CheckBox ID="S_reincrementingCheckBox" runat="server" Text='Yes at "0001"'/>
                                
                        <asp:RadioButtonList ID="S_reincrementingRadioList" runat="server">
                            <asp:ListItem Text="Per Document" Value="document" />
                            <asp:ListItem Text="Per Exhibit" Value="exhibit" />
                            <asp:ListItem Text="Per Folder" Value="folder" />
                        </asp:RadioButtonList>
                            </td>
                            
                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="S_controlNumberBoxLbl" runat="server" Text="Box#/Exhibit/Other:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="S_controlNumberBoxTxt" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="S_conrolNumberIncrementingNumberLbl" runat="server" Text="Incrementing Number:"/>
                            </td>
                            <td>
                               <asp:TextBox ID="S_conrolNumberIncrementingNumberTxt" runat="server"/>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="S_controlNumberLbl0" runat="server" Text="Control Number:" />
                            </td>
                            <td>
                                <asp:TextBox ID="S_controlNumberTxt" runat="server" />
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                            <!-- needs input -->
                            <asp:Label ID="S_spaceInControlNumberLbl" runat="server" Text="Space In Control Number:"/>
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label ID="S_volumeLbl" runat="server" Text="First Volume Name:"/>
                            </td>
                            <td>
                                <asp:TextBox ID="S_volumeTextBox" runat="server"/>
                            </td>
                            <td>
                                 <asp:Button ID="S_toDocumentLevel" runat="server" Text="Go to Document Level" onclick="S_toDocumentLevel_Click" />
                            </td>
                        </tr>
                    </table>    
                </asp:View>
                <asp:View ID="S_documentLevel" runat="server">
                    <h1>Document Level</h1>
                    <table id="S_documentLevelTable" style="width: 100%;">
                        <tr>
                            <td rowspan="5" class="style61">
                      <asp:CheckBoxList ID="S_documentLevelCheckBoxList" runat="server" AutoPostBack="True" onselectedindexchanged="S_documentLevelCheckBoxList_SelectedIndexChanged">
                            <asp:ListItem Value="Smallest Physical Bindings/Lowest" Text="Smallest Physical Bindings/Lowest" />
                            <asp:ListItem Value="Per Slip Sheets - Target Sheets" Text="Per Slip Sheets - Target Sheets" />
                            <asp:ListItem Value="Folder Tabs Determine Doc Break/per Folder" Text="Folder Tabs Determine Doc Break/per Folder" />
                            <asp:ListItem Value="Binder Tabs Determine Doc Break" Text="Binder Tabs Determine Doc Break" />
                            <asp:ListItem Value="LDD" Text="LDD" />
                            <asp:ListItem Value="Other" Text="Other:" />
                        </asp:CheckBoxList>
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
                                <asp:TextBox ID="S_otherDocumentLevelTextBox" runat="server" Visible="false" />
                                </td>
                            <td>
                               <asp:Button ID="S_goToGrouping" runat="server" Text="Go To Grouping" onclick="S_goToGrouping_Click" />
                               </td>
                        </tr>
                    </table>      
                </asp:View>
                <asp:View ID="S_grouping" runat="server">
                    <h1>Grouping</h1>
                    <table id="S_groupingTable" style="width: 100%;">
                        <tr>
                            <td rowspan="6" class="style59">
                   <asp:CheckBoxList ID="S_groupingCheckBoxList" runat="server" AutoPostBack="True" onselectedindexchanged="S_groupingCheckBoxList_SelectedIndexChanged">
                            <asp:ListItem Value="Box" Text="Box" />
                            <asp:ListItem Value="Folder" Text="Folder" />
                            <asp:ListItem Value="Document" Text="Document" />
                            <asp:ListItem Value="Child" Text="Child" />
                            <asp:ListItem Value="Other" Text="Other:" />
                        </asp:CheckBoxList>
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
                                <asp:TextBox ID="S_otherGroupingTextBox" runat="server" Visible="false" />
                            </td>
                            <td>
                               <asp:Button ID="S_goToScanning" runat="server" Text="Go To Scanning" onclick="S_goToScanning_Click" />
                            </td>
                        </tr>
                    </table>   
                </asp:View>
                <asp:View ID="S_scanning" runat="server">
                    <h1>Scanning</h1>
                    <table style="width: 100%;">
                        <tr>
                            <td class="style44" colspan="2">
                               <asp:CheckBox ID="S_pickAndChoose" Text="Pick and Choose(See Special Instructions)" runat="server"/></td>
                            <td>
                                 <asp:CheckBox ID="S_scanAllPortrait" Text="Scan All Paper Portrait" runat="server"/></td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2">
                               <asp:Label ID="S_yesColOne" runat="server" Text="Yes" />
                               <asp:Label ID="S_noColOne" runat="server" Text="No"/>
                            </td>
                            <td>
                               <asp:Label ID="S_yesColTwo" runat="server" Text="Yes"/>
                               <asp:Label ID="S_noColTwo" runat="server" Text="No"/>
                            </td>
                        </tr>
                        <tr>
                            <td class="style45" colspan="2">
                                <asp:RadioButtonList ID="S_coversRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Covers" />
                                </asp:RadioButtonList>

                                <asp:RadioButtonList ID="S_redweldFolderCovers" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Redweld/Folder Covers" />
                                </asp:RadioButtonList>
    
                                <asp:RadioButtonList ID="S_redweldFolderTabs" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Redweld/Folder Tabs" />
                                </asp:RadioButtonList>
    
                                <asp:RadioButtonList ID="S_dividerTabs" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Divider Tabs" />
                                </asp:RadioButtonList>
                    
                                <asp:RadioButtonList ID="S_postitNotes" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" onselectedindexchanged="S_postitNotes_SelectedIndexChanged">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Post It Notes" />
                                </asp:RadioButtonList>
                            </td>
                            <td rowspan="2">
                                <asp:RadioButtonList ID="S_coloredSheets" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Colored Sheets" />
                        </asp:RadioButtonList>
                        <asp:RadioButtonList ID="S_binderSpines" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Binder Spines" />
                        </asp:RadioButtonList>
                    
                        <asp:RadioButtonList ID="S_envelopes" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Envelopes" />
                        </asp:RadioButtonList>
                    
                        <asp:RadioButtonList ID="S_standardLang" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Standard Lang." />
                        </asp:RadioButtonList>
                    
                        <asp:RadioButtonList ID="S_carbon" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Carbon" />
                        </asp:RadioButtonList>&nbsp; &nbsp; &nbsp; </td>
                        </tr>
                        <tr>
                            <td class="style46">
                                &nbsp;</td>
                            <td class="style47">
                                <asp:RadioButtonList ID="S_postItNoteInstruction" runat="server" 
                                    RepeatDirection="Horizontal" style="margin-left: 0px" Visible="False">
                                    <asp:ListItem Text="On" Value="on" />
                                    <asp:ListItem Text="One On/One Off" Value="oneOnOneOff" />
                                    <asp:ListItem Text="Separtely" Value="separtely" />
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2">
                                &nbsp;&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style62" colspan="2">
                                <asp:CheckBox ID="S_reduceToCheckBox" runat="server" Text="Reduce To:" AutoPostBack="True" oncheckedchanged="S_reduceToCheckBox_CheckedChanged" />
                                <asp:RadioButtonList ID="S_reduceToRadioButtonList" runat="server" AutoPostBack="True" onselectedindexchanged="S_reduceToRadioButtonList_SelectedIndexChanged" RepeatDirection="Horizontal" Visible="False">
                                    <asp:ListItem Text="11 X 17" Value="11 X 17" />
                                    <asp:ListItem Text="Other" Value="other" />
                                </asp:RadioButtonList>

                                <asp:TextBox ID="S_reduceToOtherTextBox" runat="server" Visible="False" />
                           </td>
                           <td class="style16">
                                <asp:CheckBox ID="S_sizeForSizeCheckBox" runat="server" Text="Size for Size" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2">
                                &nbsp;
                                </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2" >
                                <h3><asp:Label ID="S_colorLbl" runat="server" Text="Color:" /></h3>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2">
                                <asp:Label ID="S_colorColOne" runat="server" Text="Color" />
                                <asp:Label ID="S_B_WColOne" runat="server" Text="B&amp;W" />
                            </td>
                            <td>
                               <asp:Label ID="S_colorColTwo" runat="server" Text="Color"/>
                               <asp:Label ID="S_B_WColTwo" runat="server" Text="B&W"/></td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2">
                                <asp:RadioButtonList ID="S_any_allColor" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Any/All Color" />
                                </asp:RadioButtonList>

                                <asp:RadioButtonList ID="S_highlights" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Highlights" />
                                </asp:RadioButtonList>
    
                                <asp:RadioButtonList ID="S_photosFront" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Photos Front" />
                                </asp:RadioButtonList>

                                <asp:RadioButtonList ID="S_photosBack" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Photos Back" />
                                </asp:RadioButtonList>

                                <asp:RadioButtonList ID="S_colorCopies" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Color Copies" />
                                </asp:RadioButtonList>
                           </td>
                           <td>
                                <asp:RadioButtonList ID="S_handwrittenColor" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Handwritten Color" />
                                </asp:RadioButtonList>

                                <asp:RadioButtonList ID="S_printingPressColor" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Printing Press Color" />
                                </asp:RadioButtonList>
    
                                <asp:RadioButtonList ID="S_chartsGraphsColor" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Charts/Graphs Color" />
                                </asp:RadioButtonList>

                                <asp:RadioButtonList ID="S_colorHandStamps" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Color Hand Stamps" />
                                </asp:RadioButtonList>

                                <asp:RadioButtonList ID="S_oversize" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="" />
                                    <asp:ListItem Value="no" Text="Oversized(Create Tag)" />
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style44" colspan="2">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="S_goToMedia" runat="server" onclick="S_goToMedia_Click" Text="Go to Media" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="S_mediaView" runat="server">
                    <h1>Media</h1>
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="S_yesCol" runat="server" Text="Yes" />
                                <asp:Label ID="S_noCol" runat="server" Text="No" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButtonList ID="S_scanAndTagMedia" runat="server"
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Text="" Value="yes" />
                                    <asp:ListItem Text="Scan and Tag as MEDIA" Value="no" />
                                </asp:RadioButtonList>
                                <asp:RadioButtonList ID="S_duplicateAndTagMedia" runat="server"
                                    AutoPostBack="True"
                                    onselectedindexchanged="S_duplicateAndTagMedia_SelectedIndexChanged"
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Text="" Value="yes" />
                                    <asp:ListItem Text="Duplicate and tag as MEDIA" Value="no" />
                                </asp:RadioButtonList>
                                <asp:TextBox ID="S_numberOfDuplicatesTextBox" runat="server"
                                    Text="Enter Number of Duplicates" Visible="false" Width="180px" />
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
                                <asp:Button ID="S_goToDeliverable" runat="server" onclick="S_goToDeliverable_Click"
                                    Text="Go to Deliverable" />
                            </td>
                        </tr>
                    </table> 
                </asp:View> 
                <asp:View ID="S_deliverable" runat="server">
                <h1>Deliverable</h1>
                        <table style="width: 100%;">
                            <tr>
                                <td class="style2" rowspan="3">
                                    <asp:CheckBoxList ID="S_deliverables" runat="server" Height="185px" 
                                        AutoPostBack="True" onselectedindexchanged="S_deliverables_SelectedIndexChanged">
                                        <asp:ListItem Value="dtiStandard" Text="DTI Standard" />
                                        <asp:ListItem Value="concordance" Text="Concordance" />
                                        <asp:ListItem Value="summation" Text="Summation" />
                                        <asp:ListItem Value="ipro" Text="IPRO" />
                                        <asp:ListItem Value="sanction_TrialDirector" Text="Sanction/Trial Director" />
                                        <asp:ListItem Value="pdf" Text="PDF" />
                                        <asp:ListItem Value="other" Text="Other" />
                                    </asp:CheckBoxList>
                                </td>
                                <td class="style13">
                                    &nbsp;
                                </td>
                                <td class="style14">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="style10">
                                    <asp:RadioButtonList ID="S_pdfPer" runat="server" RepeatDirection="Horizontal" 
                                        Visible="false" AutoPostBack="True" 
                                        onselectedindexchanged="S_pdfPer_SelectedIndexChanged">
                                         <asp:ListItem Value="document" Text="PDF per Document" Enabled="true" />
                                         <asp:ListItem Value="folder" Text="PDF per Folder" />
                                         <asp:ListItem Value="other" Text="PDF per Other" />
                                    </asp:RadioButtonList>
                                </td>
                                <td>
                                    <asp:TextBox ID="S_pdfPerTextBox" runat="server" Visible="false" Width="158px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    <asp:TextBox ID="S_deliverablesOtherTextBox" runat="server" Visible="false" 
                                        Width="202px" />
                                </td>
                                <td class="style16">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    Viewer: 
                                    <asp:RadioButtonList ID="S_viewer" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="no" Text="None" Selected="True"/>
                                    <asp:ListItem Value="eddie" Text="Eddie" />
                                    <asp:ListItem Value="eddieFielded" Text="Eddie w/Fielded Info" />
                                    <asp:ListItem Value="ipublish" Text="Ipublish" />
                                    <asp:ListItem Value="searchableIpublish" Text="Searchable Ipublish" />
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="S_gotoIndexingInstructions" runat="server" 
                                        Text="Go to Indexing Instructions" onclick="S_gotoIndexingInstructions_Click" />
                                </td>
                            </tr>
                        </table>
                </asp:View>
                <asp:View ID="S_indexingInstructions" runat="server">
                <h1>Indexing Instructions</h1>
                            <table id="S_indexingInsructions" style="width: 100%;">
                                <tr>
                                    <td class="style17">
                                        Do Not Export
                                    </td>
                                    <td colspan="2">
                                        Field Description
                                    </td>
                                    <td>
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
                                    <td class="style65">
                                        Text 1
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_textOneFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textOneTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                        Text 2
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_textTwoFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textTwoTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                        Text 3
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_textThreeFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textThreeTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                        Text 4
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_textFourFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textFourTextBox" runat="server" Width="440px"  />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                        Text 5
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_textFiveFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textFiveTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                        Text 6
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_textSixFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textSixTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                        Text 7
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_textSevenFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textSevenTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                       Text 8
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_testEightFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:TextBox ID="S_textEightTextBox" runat="server" Width="440px" />
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;
                                    </td>
                                    <td class="style65">
                                       Tag 1
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_tagOneFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:RadioButtonList ID="S_tagOneRadioButtonList" runat="server" RepeatDirection="Horizontal">
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
                                    <td class="style65">
                                        Tag 2
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_tagTwoFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:RadioButtonList ID="S_tag2RadioButtonList" runat="server" RepeatDirection="Horizontal">
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
                                    <td class="style65">
                                        Tag 3
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_tagThreeFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:RadioButtonList ID="S_tagThreeRadioButtonList" runat="server" RepeatDirection="Horizontal">
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
                                    <td class="style65">
                                        Tag 4
                                    </td>
                                    <td class="style66">
                                        <asp:TextBox ID="S_tagFourFieldTextBox" runat="server" Width="95px" /></td>
                                    <td>
                                        <asp:RadioButtonList ID="S_tagFourRadioButtonList" runat="server" RepeatDirection="Horizontal">
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
                                    <td class="style65">
                                        Tag
                                    </td>
                                    <td class="style66">
                                        Color
                                    </td>
                                    <td>
                                        <asp:RadioButtonList ID="S_tagColorRadioButtonList" runat="server" RepeatDirection="Horizontal">
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
                                    <td class="style65">
                                        Tag
                                    </td>
                                    <td class="style66">
                                        Oversize
                                    </td>
                                    <td>
                                        <asp:RadioButtonList ID="S_tagOversizeRadioButtonList" runat="server" RepeatDirection="Horizontal">
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
                                    <td class="style65">
                                        Tag&nbsp;
                                    </td>
                                    <td class="style66">
                                        Media</td>
                                    <td>
                                        <asp:RadioButtonList ID="S_tagMediaRadioButtonList" runat="server" RepeatDirection="Horizontal">
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
                                    <td colspan="4">
                                        <asp:Button ID="S_goToEBS" runat="server" onclick="S_goToEBS_Click" 
                                            Text="Go To EBS Instructions" />
                                    </td>
                                </tr>
                            </table>
                </asp:View>
                <asp:View ID="S_ebsInstructions" runat="server">
                <h1>EBS Instructions</h1>
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:RadioButtonList ID="S_ebsOptionsRadioButtonList" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" onselectedindexchanged="S_ebsOptionsRadioButtonList_SelectedIndexChanged">
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                    <asp:ListItem Value="yes" Text="Yes" />                                    
                                </asp:RadioButtonList>
                            </td>
                            <td rowspan="9">
                                <asp:RadioButtonList ID="S_ebsNumberingRadioButtonList" runat="server" Visible="false" AutoPostBack="True" onselectedindexchanged="S_ebsNumberingRadioButtonList_SelectedIndexChanged">
                                    <asp:ListItem Value="ebsControlNumber" Text="EBS Control Number" Selected="True" />
                                    <asp:ListItem Value="ebsOther" Text="EBS Other" />
                                </asp:RadioButtonList><br />
                                <asp:TextBox ID="S_ebsOtherPrefixTextBox" runat="server" Text="Prefix for EBS" 
                                    Width="165px" Visible="false" 
                                    ontextchanged="S_ebsOtherPrefixTextBox_TextChanged" AutoPostBack="True" /><br />
                                <asp:TextBox ID="S_ebsOtherStartNumberTextBox" runat="server" 
                                    Text="Starting Number for EBS" Width="165px" Visible="false" 
                                    ontextchanged="S_ebsOtherStartNumberTextBox_TextChanged" AutoPostBack="True" /><br />
                                <asp:TextBox ID="S_ebsOtherSuffixTextBox" runat="server" Text="Suffix for EBS" 
                                    Width="165px" Visible="false" 
                                    ontextchanged="S_ebsOtherSuffixTextBox_TextChanged" AutoPostBack="True" /><br />
                                <asp:Label ID="S_ebsOtherNewControlNumberLabel" runat="server" Text="New Control Number for EBS:" Visible="false" /><br />
                                <asp:TextBox ID="S_ebsOtherControlNumberTextBox" runat="server" ReadOnly="true" Visible="false" />
                                &nbsp; &nbsp;
                            </td>
                            <td rowspan="3">
                                <asp:Label ID="S_ebsLocationLabel" runat="server" Text="EBS Location" Visible="false" />
                                <asp:RadioButtonList ID="S_ebsLocationsRadioButtonList" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" RepeatLayout="Table" Visible="false">
                                    <asp:ListItem Value="lowerRight" Text="Lower Right(Default)" Selected="True" />
                                    <asp:ListItem Value="lowerLeft" Text="Lower Left" />
                                    <asp:ListItem Value="lowerCenter" Text="Lower Center" />
                                    <asp:ListItem Value="upperRight" Text="Upper Right" />
                                    <asp:ListItem Value="upperLeft" Text="Upper Left" />
                                    <asp:ListItem Value="upperCenter" Text="Upper Center" />
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="S_ebsSizeOptionLabel" runat="server" Text="EBS Size" 
                                    Visible="False" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:DropDownList ID="S_ebsOptionSizeDropDownBox" runat="server" 
                                    Visible="False">
                                    <asp:ListItem Value="10" Text="10" Selected="True" />
                                    <asp:ListItem Value="12" Text="12" />
                                    <asp:ListItem Value="14" Text="14" />
                                    <asp:ListItem Value="16" Text="16" />
                                    <asp:ListItem Value="18" Text="18" />
                                    <asp:ListItem Value="20" Text="20" />
                                    <asp:ListItem Value="24" Text="24" />
                                    <asp:ListItem Value="26" Text="26" />
                                    <asp:ListItem Value="32" Text="32" />
                                    <asp:ListItem Value="36" Text="36" />
                                    <asp:ListItem Value="42" Text="42" />
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Label ID="S_ebsFontOptionLabel" runat="server" Text="EBS Font" Visible="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:DropDownList ID="S_ebsOptionFontDropDownList" runat="server" 
                                    Visible="False">
                                    <asp:ListItem Value="arial" Text="Arial" Selected="True" />
                                    <asp:ListItem Value="times" Text="Times New Roman" />
                                </asp:DropDownList>
                                <asp:DropDownList ID="S_ebsFontOptionStyleDropDownList" runat="server" 
                                    Visible="False">
                                    <asp:ListItem Value="normal" Text="Normal" Selected="True" />
                                    <asp:ListItem Value="bold" Text="Bold" />
                                    <asp:ListItem Value="italics" Text="Italics" />
                                    <asp:ListItem Value="boldItalics" Text="Bold/Italics" />
                                </asp:DropDownList>
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
                                <asp:Label ID="S_ebsAdditionalLines" runat="server" Text="Addtional Lines" 
                                    Visible="false" />
                                <asp:RadioButtonList ID="S_ebsAddtionalLinesRadioButtonList" runat="server" 
                                    RepeatDirection="Horizontal" Visible="false" 
                                    onselectedindexchanged="S_ebsAddtionalLinesRadioButtonList_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Selected="True" Text="No" Value="no" />
                                    <asp:ListItem Text="Yes" Value="yes" />
                                </asp:RadioButtonList>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style48" colspan="3">
                                &nbsp;
                                <asp:Label ID="S_ebsOptionAdditionalLinesSizeLimitLabel" runat="server" 
                                    Text="(Additional Lines appers as one line. May not exceed 60 characters incling spaces and punctuation per line.) " 
                                    Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="S_ebsOptionAdditionalLinesLineOneLabel" runat="server" 
                                    Text="Line 1:" Visible="False" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="S_ebsOptionAdditionalLinesLineOneTextBox" runat="server" 
                                    MaxLength="60" Visible="False" Width="440px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="S_ebsOptionAdditionalLinesLineTwoLabel" runat="server" 
                                    Text="Line 2:" Visible="false" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="S_ebsOptionAdditionalLinesLineTwoTextBox" runat="server" 
                                    MaxLength="60" Visible="False" Width="440px" />
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
                                        <asp:ListItem Value="yes" Text="Yes" />
                                        <asp:ListItem Value="no" Text="No" Selected="True" />
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
                                <td class="style41">
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
                            <td colspan="2">
                                <h1>CD Label</h1>
                            </td>
                            <td>
                                (will appear in this order on disk)
                            </td>
                        </tr>
                        <tr>
                            <td class="style39">
                                &nbsp;</td>
                            <td class="style57">
                                Firm Name
                            </td>
                            <td>
                                (Always Included)
                            </td>
                        </tr>
                        <tr>
                            <td class="style56">
                                &nbsp;</td>
                            <td class="style57">
                                Case
                            </td>
                            <td>
                                <asp:TextBox ID="S_cdLabelCaseNameTextBox" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style56">
                                &nbsp;</td>
                            <td class="style57">
                                Volume
                            </td>
                            <td>
                                (Always Included)
                            </td>
                        </tr>
                        <tr>
                            <td class="style56">
                                &nbsp;</td>
                            <td class="style57">
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
                            <td class="style56">
                                &nbsp;</td>
                            <td class="style57">
                                Number Of Images
                            </td>
                            <td>
                                (Always Included)
                            </td>
                        </tr>
                        <tr>
                            <td class="style56">
                                &nbsp;</td>
                            <td class="style57">
                                Client Matter
                            </td>
                            <td>
                                <asp:TextBox ID="S_cdLabelClientMatterTextBox" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style56">
                                &nbsp;</td>
                            <td class="style57">
                                Notes
                            </td>
                            <td>
                                <asp:TextBox ID="S_cdLabelNotesTextBox" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style56">
                                &nbsp;</td>
                            <td class="style57">
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
                                <td class="style40">
                                    &nbsp;
                                </td>
                                <td>
                                   <asp:Button ID="S_goToPrinting2" runat="server" Text="Go To Printing" 
                                        Visible="false" onclick="S_goToPrinting_Click" />
                                </td>
                            </tr>
                        </table>
                    
                </asp:View>
                <asp:View ID="printing" runat="server">
                <h1>Printing/Blowbacks</h1>
                    <table id="printOptions" style="width: 100%; margin-right: 0px;">
                        <tr>
                            <td class="style54">
                                Clean Set(No EBS)
                            </td>
                            <td class="style53">
                                <asp:DropDownList ID="S_printQuantityCleanDropDown" runat="server">
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
                                    <asp:ListItem Value="11" Text="11" />
                                    <asp:ListItem Value="12" Text="12" />
                                    <asp:ListItem Value="13" Text="13" />
                                    <asp:ListItem Value="14" Text="14" />
                                    <asp:ListItem Value="15" Text="15" />
                                    <asp:ListItem Value="16" Text="16" />
                                    <asp:ListItem Value="17" Text="17" />
                                    <asp:ListItem Value="18" Text="18" />
                                    <asp:ListItem Value="19" Text="19" />
                                    <asp:ListItem Value="20" Text="20" />
                                    <asp:ListItem Value="21" Text="21" />
                                    <asp:ListItem Value="22" Text="22" />
                                    <asp:ListItem Value="23" Text="23" />
                                    <asp:ListItem Value="24" Text="24" />
                                    <asp:ListItem Value="25" Text="25" />
                                    <asp:ListItem Value="26" Text="26" />
                                    <asp:ListItem Value="27" Text="27" />
                                    <asp:ListItem Value="28" Text="28" />
                                    <asp:ListItem Value="29" Text="29" />
                                    <asp:ListItem Value="30" Text="30" />
                                </asp:DropDownList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                EBS/Annotated
                            </td>
                            <td class="style53">
                                <asp:DropDownList ID="S_printQuantityEBSedDropDown" runat="server">
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
                                    <asp:ListItem Value="11" Text="11" />
                                    <asp:ListItem Value="12" Text="12" />
                                    <asp:ListItem Value="13" Text="13" />
                                    <asp:ListItem Value="14" Text="14" />
                                    <asp:ListItem Value="15" Text="15" />
                                    <asp:ListItem Value="16" Text="16" />
                                    <asp:ListItem Value="17" Text="17" />
                                    <asp:ListItem Value="18" Text="18" />
                                    <asp:ListItem Value="19" Text="19" />
                                    <asp:ListItem Value="20" Text="20" />
                                    <asp:ListItem Value="21" Text="21" />
                                    <asp:ListItem Value="22" Text="22" />
                                    <asp:ListItem Value="23" Text="23" />
                                    <asp:ListItem Value="24" Text="24" />
                                    <asp:ListItem Value="25" Text="25" />
                                    <asp:ListItem Value="26" Text="26" />
                                    <asp:ListItem Value="27" Text="27" />
                                    <asp:ListItem Value="28" Text="28" />
                                    <asp:ListItem Value="29" Text="29" />
                                    <asp:ListItem Value="30" Text="30" />
                                </asp:DropDownList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                BarCoded
                            </td>
                            <td class="style53">
                                <asp:DropDownList ID="S_printQuantityBarCodedDropDown" runat="server">
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
                                    <asp:ListItem Value="11" Text="11" />
                                    <asp:ListItem Value="12" Text="12" />
                                    <asp:ListItem Value="13" Text="13" />
                                    <asp:ListItem Value="14" Text="14" />
                                    <asp:ListItem Value="15" Text="15" />
                                    <asp:ListItem Value="16" Text="16" />
                                    <asp:ListItem Value="17" Text="17" />
                                    <asp:ListItem Value="18" Text="18" />
                                    <asp:ListItem Value="19" Text="19" />
                                    <asp:ListItem Value="20" Text="20" />
                                    <asp:ListItem Value="21" Text="21" />
                                    <asp:ListItem Value="22" Text="22" />
                                    <asp:ListItem Value="23" Text="23" />
                                    <asp:ListItem Value="24" Text="24" />
                                    <asp:ListItem Value="25" Text="25" />
                                    <asp:ListItem Value="26" Text="26" />
                                    <asp:ListItem Value="27" Text="27" />
                                    <asp:ListItem Value="28" Text="28" />
                                    <asp:ListItem Value="29" Text="29" />
                                    <asp:ListItem Value="30" Text="30" />
                                </asp:DropDownList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Binders: 
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printBindersOptionRadioButtonList" runat="server" 
                                    AutoPostBack="True" RepeatDirection="Horizontal" 
                                    onselectedindexchanged="S_printBindersOptionRadioButtonList_SelectedIndexChanged">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                <asp:RadioButtonList ID="S_printBindersSizeRadioButtonList" runat="server" 
                                    RepeatDirection="Horizontal" Visible="false" Width="311px"> 
                                    <asp:ListItem Value="1inch" Text="1 Inch" />
                                    <asp:ListItem Value="2inch" Text="2 Inch" />
                                    <asp:ListItem Value="3inch" Text="3 Inch" Selected="True" />
                                    <asp:ListItem Value="4inch" Text="4 Inch" />
                                    <asp:ListItem Value="5inch" Text="5 Inch" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                <asp:RadioButtonList ID="S_printBinderOptionViewRadioBttonList" runat="server" RepeatDirection="Horizontal" Visible="false">
                                    <asp:ListItem Value="nonView" Text="Non View" Selected="True" />
                                    <asp:ListItem Value="view" Text="View" />
                                </asp:RadioButtonList>
                                </td>
                        </tr>
                        <tr>
                            <td class="style54">
                                2-hole Acco
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printAccoRadioButtonList" runat="server" 
                                    AutoPostBack="True" RepeatDirection="Horizontal" 
                                    onselectedindexchanged="S_printAccoRadioButtonList_SelectedIndexChanged">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                <asp:RadioButtonList ID="S_printAccoSideRadioButtonList" runat="server" 
                                    RepeatDirection="Horizontal" Visible="False">
                                    <asp:ListItem Value="side" Text="Side" />
                                    <asp:ListItem Value="top" Text="Top" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                GBC Comb Binding
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printCombRadioButtonList" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                <asp:RadioButtonList ID="S_printCombOptionsRadioBttonList" runat="server" 
                                    Visible="false" RepeatDirection="Horizontal" Width="253px">
                                    <asp:ListItem Value="perDoc" Text="Per Document" Selected="True" />
                                    <asp:ListItem Value="perFolder" Text="Per Folder" />
                                    <asp:ListItem Value="other" Text="Other" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Velo
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printVeloRadioButtonList" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                <asp:RadioButtonList ID="S_printVeloOptionRadioButtonList" runat="server" Visible="false" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="perDoc" Text="Per Document" Selected="True" />
                                    <asp:ListItem Value="perFolder" Text="Per Folder" />
                                    <asp:ListItem Value="other" Text="Other" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Spiral
                            </td>
                             <td class="style53">
                                <asp:RadioButtonList ID="S_printSpiralRadioButtonList" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                <asp:RadioButtonList ID="S_printSpiralOptionsRadioButtonList" runat="server" Visible="false" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="perDoc" Text="Per Document" Selected="True" />
                                    <asp:ListItem Value="perFolder" Text="Per Folder" />
                                    <asp:ListItem Value="other" Text="Other" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                <h3>Assembly:</h3>
                            </td>
                            <td class="style53">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Match Originals
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printMatchOriginalsRadioButtonList" runat="server" 
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Drilling
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printDrillingRadioButtonList" runat="server" AutoPostBack="true" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                <asp:RadioButtonList ID="S_printDrillingOptionRadioButton" runat="server" Visible="false" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="2Hole" Text="2 Hole" />
                                    <asp:ListItem Value="3Hole" Text="3 Hole" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                2 Sided (8.5 X 11 ONLY)
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printingTwoSidedRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Color For Color
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printColor4ColorRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Size For Size
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printSize4SizeRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Slip Sheets
                            </td>
                            <td class="style49" colspan="3">
                                <asp:RadioButtonList ID="S_printSlipSheetsRadioButtonList" runat="server" 
                                    RepeatColumns="2" RepeatDirection="Horizontal" RepeatLayout="Table" 
                                    Width="410px">
                                    <asp:ListItem Value="slipSheetPerDoc" Text="Slip Sheet Per Doc" Selected="True" />
                                    <asp:ListItem Value="noSlipSheets" Text="No Slip Sheets" />
                                    <asp:ListItem Value="fileNameOnSlipSheet" Text="File Name on Slip Sheet" />
                                    <asp:ListItem Value="fileNameAndPathOnSlipSheets" Text="File Name & Path on Slip Sheets" />
                                </asp:RadioButtonList>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td class="style54">
                                Staple Per Doc
                            </td>
                            <td class="style53">
                                <asp:RadioButtonList ID="S_printStapleRadioButton" runat="server" 
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Value="yes" Text="Yes" />
                                    <asp:ListItem Value="no" Text="No" Selected="True" />
                                </asp:RadioButtonList>
                            </td>
                            <td class="style50">
                                &nbsp;
                            </td>
                            <td class="style50">
                                &nbsp;</td>
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

