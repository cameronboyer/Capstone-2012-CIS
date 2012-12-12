<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobSchedule.aspx.cs" Inherits="WorkScheduler.JobSchedule" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Job Schedule</title>
</head>
<body bgcolor="lightgrey">
    <form id="form1" runat="server">
    <div style="height: 765px">
        <p>
            &nbsp;
            <asp:Label ID="jobNumberLabel" runat="server" Text="Unscheduled Job List" 
                
                style="z-index: 100; left: 24px; position: absolute; top: 35px; font-size:x-large; width: 215px;"  />
            
            <asp:GridView ID="jobDetails" runat="server" style="height: 133px; width: 686px; position: absolute; left: 230px;
                 top:70px; bottom: 374px;" AutoGenerateColumns="False" onselectedindexchanged="jobDetails_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="JobNumber" HeaderText="Job Number" 
                        SortExpression="JobNumber" >
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Client" HeaderText="Client" SortExpression="Client" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="JobType" HeaderText="Job Type" 
                        SortExpression="JobType" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="JobLocation" HeaderText="Job Location" 
                        SortExpression="JobLocation" />
                    <asp:BoundField DataField="JobStatus" HeaderText="Job Status" 
                        SortExpression="JobStatus" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:ButtonField CommandName="Select" Text="Assign Shift" />
                </Columns>
            </asp:GridView>

       </p>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JobList %>" 
            SelectCommand="SELECT [JobNumber], [Client], [JobType], [DeliveryTime], [JobLocation], [Employee], [JobStatus], [Shift] FROM [JobList]">
            </asp:SqlDataSource>


            <asp:Label ID="selectShiftLabel" runat="server" Font-Bold="True" style="position: absolute;
                 z-index: 1; left: 240px; top: 233px; width: 105px; height: 24px" Text="Select a Shift :" Visible="False"></asp:Label>

            <asp:RadioButtonList ID="shiftRBL1" runat="server" style="z-index: 1; left: 235px; top: 200px; position: relative; height: 27px; width: 82px" 
            Visible="False" AutoPostBack="True" 
            onselectedindexchanged="shiftRBL1_SelectedIndexChanged">
                <asp:ListItem Value="1">Shift 1</asp:ListItem>
                <asp:ListItem Value="2">Shift 2</asp:ListItem>
                <asp:ListItem Value="3">Shift 3</asp:ListItem>
            </asp:RadioButtonList>

            <asp:ListBox ID="unschedJobListBox" runat="server" onselectedindexchanged="unschedJobListBox_SelectedIndexChanged" 
                
            style="z-index: 1; left: 18px; top: 70px; position: absolute; right: 733px; height: 303px;" Width="170px"
                AutoPostBack="True">
            </asp:ListBox>

            <asp:Label ID="openJobsLabel" runat="server" Text="Open Jobs"
                style="z-index: 100; left: 30px; top: 417px; position: absolute; font-size:x-large; width: 127px;"></asp:Label>

            <asp:ListBox ID="openJobsListBox" runat="server" style="z-index: 1; left: 23px; top: 451px; position: absolute; width: 170px;
                height: 323px" AutoPostBack="True" onselectedindexchanged="openJobsListBox_SelectedIndexChanged">
            </asp:ListBox>

            <asp:GridView ID="openJobsDetails" runat="server" style="height: 133px; width: 686px; position: absolute; left: 230px;
                 top:451px; bottom: 130px;" AutoGenerateColumns="False" onselectedindexchanged="openJobsDetails_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="JobNumber" HeaderText="Job Number" 
                        SortExpression="JobNumber" >
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Client" HeaderText="Client" SortExpression="Client" >
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
                    <asp:BoundField DataField="JobStatus" HeaderText="Job Status" 
                        SortExpression="JobStatus" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Shift" HeaderText="Shift" SortExpression="Shift">
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Employee" HeaderText="Employee" 
                        SortExpression="Employee">
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:ButtonField CommandName="Select" Text="Update Shift" />
                </Columns>
            </asp:GridView>

            <asp:Label ID="shiftLabel" runat="server" Font-Bold="True" style="position: absolute;
                 z-index: 1; left: 253px; top: 623px; width: 105px; height: 24px" 
            Text="Select a Shift :" Visible="False"></asp:Label>

            <asp:RadioButtonList ID="shiftRBL2" runat="server" style="z-index: 101; left: 261px; top: 666px; position: absolute;
                 height: 27px; width: 82px" Visible="False" AutoPostBack="True" 
            onselectedindexchanged="shiftRBL2_SelectedIndexChanged">
                <asp:ListItem Value="1">Shift 1</asp:ListItem>
                <asp:ListItem Value="2">Shift 2</asp:ListItem>
                <asp:ListItem Value="3">Shift 3</asp:ListItem>
            </asp:RadioButtonList>
    </div>
    </form>
</body>
</html>
