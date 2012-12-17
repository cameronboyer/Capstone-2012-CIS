<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="DTI_Schedule.Account.admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul>
        <li>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/EmployeeView.aspx">Employee View</asp:HyperLink>
        </li>
    <li>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/JobSchedule.aspx">Job Schedule</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/JobStatus.aspx">Job Status</asp:HyperLink>
    </li>
    
    <li>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/SalesRep.aspx">SalesRep</asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="/Account/Login.aspx">Login</asp:HyperLink>
    </li>
    </ul>

        
    </div>
    </form>
</body>
</html>
