<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobStatus.aspx.cs" Inherits="WorkScheduler.JobStatus" %>

<link href="http://localhost:21100/Styles/Site.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Job Status</title>
</head>
<body bgcolor="lightgrey">
    <form id="form1" runat="server">
    <div>
        <p>
            &nbsp;
            <asp:Label ID="jobNumberLabel" runat="server" Text="Job List" Width="100" style="z-index: 100; left: 40px; position: absolute; top: 38px; font-size:x-large" />
            <asp:TextBox ID="jobTextBox" runat="server" CssClass="textbox" Columns="20" Rows="25"
                TextMode="MultiLine" style="z-index: 101; left: 34px; position: absolute; top: 69px" />
            
            &nbsp;
            <asp:Label ID="jobLabel" runat="server" Text="Job Number:" Width="100px" style="z-index: 100; left: 245px; position: absolute; top: 75px" Font-Bold="False" Font-Size="Large" />
            <asp:TextBox ID="jobNumber" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 400px; position: absolute; top: 75px" />
            
            &nbsp;
            <asp:Label ID="clientLabel" runat="server" Text="Client:" Width="100px" style="z-index: 100; left: 246px; position: absolute; top: 124px" Font-Size="Large" />
            <asp:TextBox ID="clientInfo" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 400px; position: absolute; top: 117px" />
            
            &nbsp;
            <asp:Label ID="deliveryDateLabel" runat="server" Text="Estimated Delivery Time:" Width="117px" style="z-index: 100; left: 244px; position: absolute; top: 169px" Font-Size="Large" />
            <asp:TextBox ID="deliveryDateTextBox" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 400px; position: absolute; top: 182px" />
            
            &nbsp;
            <asp:Label ID="jobTypeLabel" runat="server" Text="Job Type:" Width="100px" style="z-index: 100; left: 250px; position: absolute; top: 248px" Font-Size="Large" />
            <asp:TextBox ID="jobTypeTextBox" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 400px; position: absolute; top: 245px" />
            
            &nbsp;
            <asp:Label ID="originalsLabel" runat="server" Text="Job Location:" Width="100px" style="z-index: 100; left: 246px; position: absolute; top: 312px" Font-Size="Large" />
            <asp:TextBox ID="originalsTextBox1" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 400px; position: absolute; top: 308px" />
            
            &nbsp;
            <asp:Label ID="employeeLabel" runat="server" Text="Employee:" Width="100px" style="z-index: 100; left: 248px; position: absolute; top: 377px" Font-Size="Large" />
            <asp:TextBox ID="employeeTextBox" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 400px; position: absolute; top: 373px" />
            
            <asp:Button ID="updateButton" runat="server" Text="Update Job" style="z-index: 113; left: 253px; position: absolute; top: 450px" />
        </p>
    </div>
    </form>
</body>
</html>
