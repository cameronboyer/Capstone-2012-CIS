<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SalesRep.aspx.cs" Inherits="DTI_Schedule.SalesRep" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
            color: #000000;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
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
</asp:Content>

