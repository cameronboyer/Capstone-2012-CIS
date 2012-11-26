<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DTI_Schedule.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


h1
{
    font-size: 1.6em;
    padding-bottom: 0px;
    margin-bottom: 0px;
}

h1, h2, h3, h4, h5, h6
{
    font-size: 1.5em;
    color: #666666;
    font-variant: small-caps;
    text-transform: none;
    font-weight: 200;
    margin-bottom: 0px;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">

    <asp:MultiView ID="addOrStatusMV" runat="server" Visible="False" >
    <asp:View runat="server">
        
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Button ID="addCopyButton" runat="server" Text="Add Copy Job" />
                </td>
                <td>
                    <asp:Button ID="addScanButton" runat="server" onclick="addButton_Click" Text="Add Scan Job" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="addDataButton" runat="server" Text="Add Data Job" />
                </td>
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
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        
    </asp:View>
    </asp:MultiView>

    </form>
</body>
</html>
