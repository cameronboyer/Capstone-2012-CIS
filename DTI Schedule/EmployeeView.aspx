<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="WorkScheduler.EmployeeView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee View</title>
</head>
<body bgcolor="lightgrey">
    <form id="form1" runat="server">
    <div style="height: 765px">
        <p>
            &nbsp;
            <asp:Label ID="shiftLabel" runat="server" Text="Shift 1 Jobs"               
                
                style="z-index: 100; left: 20px; position: absolute; top: 40px; font-size:x-large; width: 127px;"  />

            <asp:Label ID="shift2Label" runat="server" Text="Shift 2 Jobs"               
                
                style="z-index: 100; left: 330px; position: absolute; top: 40px; font-size:x-large; width: 125px; right: 554px;"  />

            <asp:Label ID="shift3Label" runat="server" Text="Shift 3 Jobs"               
                
                style="z-index: 1; left: 650px; position: absolute; top: 40px; font-size:x-large; width: 142px;"  />

            <asp:GridView ID="jobDetails" runat="server" style="height: 133px; width: 686px; position: absolute; left: 133px;
                 top:410px; bottom: 25px;" AutoGenerateColumns="False">
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
                    <asp:BoundField DataField="Employee" HeaderText="Employee" 
                        SortExpression="Employee">
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>

       </p>

            
                <ContentTemplate>
                    <asp:ListBox ID="shift1ListBox" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="shift1ListBox_SelectedIndexChanged" 
                        style="z-index: 1; left: 18px; top: 70px; position: absolute; right: 733px; height: 300px;" 
                        Width="260px"></asp:ListBox>
                    <asp:ListBox ID="shift2ListBox" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="shift2ListBox_SelectedIndexChanged" 
                        style="z-index: 1; left: 330px; top: 70px; position: absolute; right: 733px; height: 300px;" 
                        Width="260px"></asp:ListBox>
                    <asp:ListBox ID="shift3ListBox" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="shift3ListBox_SelectedIndexChanged" 
                        style="z-index: 1; left: 650px; top: 70px; position: absolute; right: 99px; height: 300px;" 
                        Width="260px"></asp:ListBox>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:chucksDB %>" 
                        SelectCommand="SELECT [JobNumber], [Client], [JobType], [DeliveryTime], [JobLocation], [Employee], [JobStatus], [Shift] FROM [JobList]">
                    </asp:SqlDataSource>
                </ContentTemplate>





        

    </div>
    </form>
</body>
</html>
