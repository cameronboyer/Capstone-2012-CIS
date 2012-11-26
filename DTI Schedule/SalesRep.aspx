<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SalesRep.aspx.cs" Inherits="DTI_Schedule.SalesRep" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server" >
    <style type="text/css"> 
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
                <h1>Media</h1><table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="yesCol" runat="server" Text="Yes"/>
                    <asp:Label ID="noCol" runat="server" Text="No"/>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RadioButtonList ID="scanAndTagMedia" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="yes" Text="" />
                        <asp:ListItem Value="no" Text="Scan and Tag as MEDIA" />
                    </asp:RadioButtonList>
                    <asp:RadioButtonList ID="duplicateAndTagMedia" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" onselectedindexchanged="duplicateAndTagMedia_SelectedIndexChanged">
                        <asp:ListItem Value="yes" Text="" />
                        <asp:ListItem Value="no" Text="Duplicate and tag as MEDIA" />
                    </asp:RadioButtonList>
                    <asp:TextBox ID="numberOfDuplicatesTextBox" runat="server" Text="Enter Number of Duplicates" Visible="false"/>
                    <asp:RadioButtonList ID="bateLabelAndTagMedia" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="yes"  Text="" />
                        <asp:ListItem Value="no" Text="Bate Label and tag as MEDIA" />
                    </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="goToDeliverable" runat="server" Text="Go to Deliverable" onclick="goToDeliverable_Click" />
            </td>
        </tr>
    </table>
                    

    
                    

                    
                </asp:View> 
                <asp:View ID="deliverable" runat="server">
                <h1>Deliverable</h1>

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

