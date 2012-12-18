<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="DTI_Schedule.Account.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 288px;
        }
        .style2
        {
            width: 139px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Log In
    </h2>
    <p>
        Please enter your username and password.</p>
        <table style="width:100%;">
            <tr>
                <td class="style2">
                    Username:</td>
                <td class="style1">
                    <asp:TextBox ID="txtUsername" runat="server" TabIndex="1"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Password</td>
                <td class="style1">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" TabIndex="2"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style1">
                    <asp:Label ID="errorLabel" runat="server" Text="Invalid Credentials"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Login" 
                        onclick="btnSubmit_Click" TabIndex="3" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    </asp:Content>
