<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SalesRep.aspx.cs" Inherits="DTI_Schedule.SalesRep" %>

<<<<<<< HEAD
<asp:Content ContentPlaceHolderID="HeadContent" runat="server" >
    <style type="text/css">
        .style1
        {
            
            
        }
        
        #TESTCSS
        {
            font-size:40px;
=======
<asp:Content ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
            color: #000000;
>>>>>>> 19cb90a7f030c2d0b05f2fc418f3b9925cba15f5
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<<<<<<< HEAD

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
                    <table id"documentLevelTable" style="width: 100%;">
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
                                &nbsp;
                            </td>
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
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                        
                       
                    
                        

                    
                        

                        
                    
                        

                        <div style="width:0px; height:166px; background-color:black;float:left; z-index: 1; left: 482px; top: 92px; position: absolute; bottom: 369px;"></div>

                        <asp:CheckBox ID="reduceToCheckBox" runat="server" Text="Reduce To:" style="z-index: 1; left: 500px; top: 92px; position: absolute" AutoPostBack="True" oncheckedchanged="reduceToCheckBox_CheckedChanged" />
                    
                        <asp:RadioButtonList ID="reduceToRadioButtonList" runat="server" RepeatDirection="Horizontal" style="z-index: 1; left: 593px; top: 92px; position: absolute; height: 26px; width: 140px" AutoPostBack="True" onselectedindexchanged="reduceToRadioButtonList_SelectedIndexChanged" Visible="False">
                            <asp:ListItem Value="11 X 17" Text="11 X 17" />
                            <asp:ListItem Value="other" Text="Other" />
                        </asp:RadioButtonList>
                        <asp:TextBox ID="reduceToOtherTextBox" runat="server" style="z-index: 1; left: 736px; top: 92px; position: absolute" Visible="False" />

                        <asp:CheckBox ID="sizeForSizeCheckBox" runat="server" Text="Size for Size" style="z-index:1; left:500px; top:112px; position: absolute" />

                        <asp:Label ID="colorLbl" runat="server" Text="Color:" style="z-index: 1; left: 503px; top: 132px; position: absolute" />

                        <asp:Label ID="colorColOne" runat="server" Text="Color" style="z-index: 1; left: 489px; top: 149px; position: absolute" />
                        <asp:Label ID="B_WColOne" runat="server" Text="B&W" style="z-index: 1; left: 527px; top: 149px; position: absolute" />

                        <asp:RadioButtonList ID="any_allColor" runat="server" style="z-index:1;left:498px; top:161px; position:absolute; margin-right: 1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Any/All Color" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="highlights" runat="server" style="z-index:1;left:498px; top:181px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Highlights" />
                        </asp:RadioButtonList>
    
                        <asp:RadioButtonList ID="photosFront" runat="server" style="z-index:1;left:498px; top:201px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Photos Front" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="photosBack" runat="server" style="z-index:1;left:498px; top:221px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Photos Back" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="colorCopies" runat="server" style="z-index:1;left:498px; top:241px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Color Copies" />
                        </asp:RadioButtonList>

                        <asp:Label ID="colorColTwo" runat="server" Text="Color" style="z-index: 1; left: 659px; top: 149px; position: absolute" />
                        <asp:Label ID="B_WColTwo" runat="server" Text="B&W" style="z-index: 1; left: 704px; top: 149px; position: absolute" />

                        <asp:RadioButtonList ID="handwrittenColor" runat="server" style="z-index:1;left:670px; top:161px; position:absolute; margin-right: 1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Handwritten Color" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="printingPressColor" runat="server" style="z-index:1;left:670px; top:181px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Printing Press Color" />
                        </asp:RadioButtonList>
    
                        <asp:RadioButtonList ID="chartsGraphsColor" runat="server" style="z-index:1;left:670px; top:201px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Charts/Graphs Color" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="colorHandStamps" runat="server" style="z-index:1;left:670px; top:221px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Color Hand Stamps" />
                        </asp:RadioButtonList>

                        <asp:RadioButtonList ID="oversize" runat="server" style="z-index:1;left:670px; top:241px; position:absolute; margin-right:1px;" RepeatDirection="Horizontal">
                            <asp:ListItem Value="yes" Text="" />
                            <asp:ListItem Value="no" Text="Oversized(Create Tag)" />
                        </asp:RadioButtonList>

                        <asp:Button ID="goToMedia" runat="server" style="z-index: 1; left: 897px; top: 243px; position: absolute; width: 97px" Text="Go to Media" onclick="goToMedia_Click" />
                </asp:View>
                <asp:View ID="mediaView" runat="server">
                <h1>Media</h1>
                    <asp:Label ID="yesCol" runat="server" Text="Yes" style="z-index: 1; left: 21px; top: 93px; position: absolute" />
                    <asp:Label ID="noCol" runat="server" Text="No" style="z-index: 1; left: 52px; top: 93px; position: absolute" />

                    <asp:RadioButtonList ID="scanAndTagMedia" runat="server" RepeatDirection="Horizontal" style="z-index: 1; left: 20px; top: 113px; position: absolute; height: 26px; width: 224px">
                        <asp:ListItem Value="yes" Text="" />
                        <asp:ListItem Value="no" Text="Scan and Tag as MEDIA" />
                    </asp:RadioButtonList>
                    <asp:RadioButtonList ID="duplicateAndTagMedia" runat="server" RepeatDirection="Horizontal" style="z-index: 1; left: 20px; top: 133px; position: absolute; height: 26px; width: 250px" AutoPostBack="True" onselectedindexchanged="duplicateAndTagMedia_SelectedIndexChanged">
                        <asp:ListItem Value="yes" Text="" />
                        <asp:ListItem Value="no" Text="Duplicate and tag as MEDIA" />
                    </asp:RadioButtonList>
                    <asp:TextBox ID="numberOfDuplicatesTextBox" runat="server" Text="Enter Number of Duplicates" Visible="false" style="z-index: 1; left: 66px; top: 156px; position: absolute" Width="170px"/>
                    <asp:RadioButtonList ID="bateLabelAndTagMedia" runat="server" RepeatDirection="Horizontal" style="z-index: 1; left: 20px; top: 185px; position: absolute; height: 26px; width: 256px">
                        <asp:ListItem Value="yes"  Text="" />
                        <asp:ListItem Value="no" Text="Bate Label and tag as MEDIA" />
                    </asp:RadioButtonList>

                    <asp:Button ID="goToDeliverable" runat="server" 
                        style="z-index: 1; left: 191px; top: 236px; position: absolute" 
                        Text="Go to Deliverable" onclick="goToDeliverable_Click" />
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
    
=======
    <asp:Button ID="addScanButton" runat="server" Text="Add Scan Job" onclick="addButton_Click" style="z-index: 1; left: 13px; top: 60px; position: absolute; width: 111px; margin-bottom: 0px;" />
    <asp:Button ID="addCopyButton" runat="server" Text="Add Copy Job" style="z-index:1; left:13px; top: 100px; position:absolute" />
    <asp:Button ID="addDataButton" runat="server" Text="Add Data Job" style="z-index:1; left:13px; top: 140px; position:absolute" />
    <asp:Button ID="addPrintButton" runat="server" Text="Add Print Job" style="z-index:1; left:13px; top: 180px; position:absolute" />
    <asp:Button ID="statusButton" runat="server" Text="Status of Job" style="z-index: 1; left: 205px; top: 60px; position: absolute" onclick="statusButton_Click" />

    <asp:MultiView ID="addOrStatusMV" runat="server" Visible="False" >
    <asp:View ID="add" runat="server">
        <asp:MultiView ID="scanJob" runat="server">
            <asp:View ID="clientInfo" runat="server">
            <h1>Client Information</h1>
                <%--<asp:Label ID="clientNameLbl" runat="server" Text="Client Name:"></asp:Label>
                <asp:DropDownList ID="clientNameComb" runat="server"></asp:DropDownList>
                <asp:Label ID="contactNameLbl" runat="server" Text="Contact Name:"></asp:Label>
                <asp:DropDownList ID="contactNameComb" runat="server"></asp:DropDownList>
                <asp:Label ID="addresslbl" runat="server" Text="Address:"></asp:Label>
                <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox>
                <asp:Label ID="phoneNumberLbl" runat="server" Text="Phone Number:"></asp:Label>
                <asp:TextBox ID="phoneNumberTxt" runat="server"></asp:TextBox>
                <asp:Label ID="clientMatterLbl" runat="server" Text="Client Matter:"></asp:Label>
                <asp:TextBox ID="clientMatterTxt" runat="server"></asp:TextBox>
                <asp:Button ID="addNext" runat="server" Text="Next" onclick="addNext_Click" />--%>
                <asp:Label ID="clientNameLbl" runat="server" Text="Client Name:" style="z-index: 1; left: 26px; top: 117px; position: absolute; height: 17px;" />
                <asp:DropDownList ID="clientNameDropDown" runat="server" style="z-index: 1; left: 146px; top: 116px; position: absolute" />
                <asp:Label ID="contactNameLbl" runat="server" Text="Contact Name:" style="z-index: 1; left: 19px; top: 147px; position: absolute" />
                <asp:DropDownList ID="contactNameDropDown" runat="server" style="z-index: 1; left: 145px; top: 150px; position: absolute" />
                <asp:Label ID="addressLbl" runat="server" Text="Address:" style="z-index: 1; left: 53px; top: 187px; position: absolute" />
                <asp:TextBox ID="addressTextBox" runat="server" style="z-index: 1; left: 143px; top: 183px; position: absolute" />
                <asp:Label ID="phoneNumberLbl" runat="server" Text="Phone Number:" style="z-index: 1; left: 17px; top: 228px; position: absolute" />
                <asp:TextBox ID="phoneNumberTextBox" runat="server" style="z-index: 1; left: 146px; top: 226px; position: absolute" />
                <asp:Label ID="clientMatterLbl" runat="server" Text="Client Matter:" style="z-index: 1; left: 30px; top: 265px; position: absolute" />
                <asp:TextBox ID="clientMatterTextBox" runat="server" style="z-index: 1; left: 145px; top: 263px; position: absolute" />
                <asp:Button ID="toNamingPage" runat="server" Text="Go to Control Number Naming" onclick="addNext_Click" style="z-index: 1; left: 305px; top: 260px; position: absolute" />
                
            </asp:View>
            <asp:View ID="naming" runat="server">
            <h1>Naming</h1>
                <%--<asp:Label ID="controlNumberLbl" runat="server" Text="Control Number:"></asp:Label>
                <asp:TextBox ID="controlNumberTxt" runat="server"></asp:TextBox>
                <asp:Label ID="controlNumberPrefixLbl" runat="server" Text="Prefix:"></asp:Label>
                <asp:TextBox ID="controlNumberPrefixTxt" runat="server"></asp:TextBox>
                <asp:Label ID="controlNumberBoxLbl" runat="server" Text="Box#/Exhibit/Other:"></asp:Label>
                <asp:TextBox ID="controlNumberBoxTxt" runat="server"></asp:TextBox>
                <asp:Label ID="conrolNumberIncrementingNumberLbl" runat="server" Text="Incrementing Number:"></asp:Label>
                <asp:TextBox ID="conrolNumberIncrementingNumberTxt" runat="server"></asp:TextBox>--%>
               <asp:Label ID="controlNumberLbl" runat="server" Text="Control Number:" style="z-index: 1; left: 147px; top: 204px; position: absolute" />
                <asp:TextBox ID="controlNumberTxt" runat="server" style="z-index: 1; left: 263px; top: 204px; position: absolute" />
                <asp:Label ID="controlNumberPrefixLbl" runat="server" Text="Prefix:" style="z-index: 1; left: 105px; top: 94px; position: absolute; height: 17px;"/>
                <asp:TextBox ID="controlNumberPrefixTxt" runat="server" style="z-index: 1; left: 154px; top: 93px; position: absolute" />
                <asp:Label ID="controlNumberBoxLbl" runat="server" Text="Box#/Exhibit/Other:" style="z-index: 1; left: 30px; top: 135px; position: absolute" />
                <asp:TextBox ID="controlNumberBoxTxt" runat="server" style="z-index: 1; left: 154px; top: 130px; position: absolute; margin-bottom: 0px" />
                <asp:Label ID="conrolNumberIncrementingNumberLbl" runat="server" Text="Incrementing Number:" style="z-index: 1; left: 15px; top: 169px; position: absolute" />
                <asp:TextBox ID="conrolNumberIncrementingNumberTxt" runat="server" style="z-index: 1; left: 155px; top: 166px; position: absolute" />
                <asp:Label ID="reincrementingLbl" runat="server" Text="Re-increment:" Style="z-index: 1;left: 308px; top: 95px; position: absolute" />
                <asp:CheckBox ID="reincrementingCheckBox" runat="server" Text='Yes at "0001"' Style="z-index: 1;left: 401px; top: 96px; position: absolute" />
                <asp:RadioButtonList ID="reincrementingRadioList" runat="server" 
                    Style="z-index: 1; left: 399px; top: 118px; position: absolute; height: 0px;width: 112px">
                    <asp:ListItem Text="Per Document" Value="document" />
                    <asp:ListItem Text="Per Exhibit" Value="exhibit" />
                    <asp:ListItem Text="Per Folder" Value="folder" />
                </asp:RadioButtonList>
                <asp:Label ID="spaceInControlNumberLbl" runat="server" 
                    Text="Space In Control Number:" 
                    Style="z-index: 1;left: 18px; top: 226px; position: absolute" />
                `<asp:Label ID="volumeLbl" runat="server" Text="First Volume Name:" Style="z-index: 1;left: 18px; top: 318px; position: absolute" />
                <asp:TextBox ID="volumeTextBox" runat="server" Style="z-index: 1; left: 144px; top: 318px;position: absolute" />

                <asp:Button ID="toDocumentLevel" runat="server" Text="Go to Document Level" 
                    Style="z-index: 1;left: 305px; top: 318px; position: absolute" 
                    onclick="toDocumentLevel_Click" />
            </asp:View>
            <asp:View ID="documentLevel" runat="server">
            <h1>Document Level</h1>
                <asp:CheckBox ID="lowestChecKBox" Text="Lowest" runat="server" Style="z-index: 1;left: 9px; top: 113px; position: absolute" />
                <asp:CheckBox ID="otherCheckBox" Text="Other" runat="server" Style="z-index: 1; left: 11px;top: 140px; position: absolute" />
                <asp:CheckBox ID="lddCheckBox" Text="LDD(Broker)" runat="server" Style="z-index: 1;left: 9px; top: 208px; position: absolute" />
                <asp:TextBox ID="otherTextBox" runat="server" Style="z-index: 1; left: 30px; top: 171px;position: absolute" />
            </asp:View>
        </asp:MultiView>

    </asp:View>
    <asp:View ID="status" runat="server">
    </asp:View>
    </asp:MultiView>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeaderContent">
    <span class="style1">Sales Rep</span>
>>>>>>> 19cb90a7f030c2d0b05f2fc418f3b9925cba15f5
</asp:Content>

