<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobStatus.aspx.cs" Inherits="WorkScheduler.JobStatus" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Job Schedule</title>
</head>
<body bgcolor="lightgrey">
    <form id="form1" runat="server">
    <div>
        <p style="height: 475px; width: 1120px;">
            &nbsp;
            <asp:Label ID="jobListLabel" runat="server" Text="Job List" Width="212px" style="z-index: 100; left: 16px; position: absolute;
                 top: 22px; font-size:x-large"  />

            <asp:ListBox ID="jobListBox" runat="server" Width="224px" style="position: absolute; left: 10px; top:50px; height: 426px;" 
                AutoPostBack="True" 
                onselectedindexchanged="jobListBox_SelectedIndexChanged1" 
                DataSourceID="SqlDataSource1" DataTextField="JobNumber" 
                DataValueField="JobNumber">
            </asp:ListBox>

            <asp:GridView ID="jobDetails" runat="server" 
                
                
                style="height: 133px; width: 686px; position: absolute; left: 270px; top:55px" AutoGenerateColumns="False" 
                        onselectedindexchanged="jobListBox_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="JobNumber" HeaderText="Job Number" 
                        SortExpression="JobNumber" >
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Client" HeaderText="Client" SortExpression="Client" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DeliveryTime" HeaderText="Delivery Time/Date" 
                        SortExpression="DeliveryTime" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="JobType" HeaderText="Job Type" 
                        SortExpression="JobType" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="JobLocation" HeaderText="Job Location" 
                        SortExpression="JobLocation" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Shift" HeaderText="Shift" SortExpression="Shift" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Employee" HeaderText="Employee" 
                        SortExpression="Employee">
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:chucksDB %>" 
                
                SelectCommand="SELECT [JobNumber], [Client], [JobType], [DeliveryTime], [JobLocation], [Employee], [JobStatus], [Shift] FROM [JobList]">
            </asp:SqlDataSource>

            <asp:Button ID="addJobButton" runat="server" Text="Add Job" style="z-index: 113; left: 252px; position: absolute; top: 438px" 
                Font-Size="Large" onclick="addJobButton_Click" />
        </p>
    </div>
    </form>
</body>
</html>
