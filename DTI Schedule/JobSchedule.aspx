<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobSchedule.aspx.cs" Inherits="WorkScheduler.JobSchedule" %>

<link href="http://localhost:21100/Styles/Site.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Job Schedule</title>
</head>
<body bgcolor="lightgrey">
    <form id="form1" runat="server">
    <div>
        <p>
            &nbsp;
            <asp:Label ID="jobNumberLabel" runat="server" Text="Unscheduled Job List" Width="212px" style="z-index: 100; left: 40px; position: absolute; top: 38px; font-size:x-large"  />
            <asp:TextBox ID="jobTextBox" runat="server" CssClass="textbox" Columns="20" Rows="25"
                TextMode="MultiLine" style="z-index: 101; left: 34px; position: absolute; top: 69px" Width="207px" />
            
            &nbsp;
            <asp:Label ID="jobLabel" runat="server" Text="Job Number:" Width="100px" style="z-index: 100; left: 270px; position: absolute; top: 86px" Font-Size="Large" />
            <asp:TextBox ID="jobNumber" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 434px; position: absolute; top: 84px" />
            
            &nbsp;
            <asp:Label ID="clientLabel" runat="server" Text="Client:" Width="100px" style="z-index: 100; left: 270px; position: absolute; top: 133px" Font-Size="Large" />
            <asp:TextBox ID="clientInfo" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 437px; position: absolute; top: 130px" />
            
            &nbsp;
            <asp:Label ID="deliveryDateLabel" runat="server" Text="Estimated Delivery Time:" Width="117px" style="z-index: 100; left: 270px; position: absolute; top: 192px" Font-Size="Large" />
            <asp:TextBox ID="deliveryDateTextBox" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 441px; position: absolute; top: 203px" />
            
            &nbsp;
            <asp:Label ID="shiftLabel" runat="server" Text="Responsible Shift:" Width="100px" style="z-index: 100; left: 270px; position: absolute; top: 277px" Font-Size="Large" />
            <asp:TextBox ID="shiftTextBox" runat="server" CssClass="textbox" Columns="20" Rows="2" style="z-index: 100; left: 438px; position: absolute; top: 286px" />
            
            <asp:Button ID="scheduleJobButton" runat="server" Text="Schedule Job" style="z-index: 113; left: 282px; position: absolute; top: 438px" Font-Size="Large" />
       </p>
    </div>
    </form>
</body>
</html>
