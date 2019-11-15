<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmEditEmployee.aspx.cs" Inherits="frmEditEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link rel="Stylesheet" type="text/css"
	 href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body>
    <form id="grdEditPersonnel" runat="server">
        <div style="text-align: center">
            <strong><font face="Comic Sans MS" color="blue" size="4">Cool</font><font face="Comic Sans MS" color="#ff6600" size="4">Biz</font><font face="Comic Sans MS" size="4"> <font color=#993366>Productions</font>, Inc.</font></strong>
        </div>
        <asp:GridView ID="gvPersonal" runat="server"  EnableModelValidation="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="ID" Width="693px" >
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
				<asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
				<asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
				<asp:BoundField DataField="PayRate" HeaderText="PayRate" SortExpression="PayRate" />
				<asp:BoundField DataField="StartDate" HeaderText="StartDate" SortExpression="StartDate" />
				<asp:BoundField DataField="EndDate" HeaderText="EndDate" SortExpression="EndDate" />
				<asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollSystem_DBConnectionString %>" ProviderName="<%$ ConnectionStrings:PayrollSystem_DBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblPersonnel]" DeleteCommand="DELETE FROM [tblPersonnel] WHERE [ID] = ?" InsertCommand="INSERT INTO [tblPersonnel] ([ID], [FirstName], [LastName], [PayRate], [StartDate], [EndDate]) VALUES (?, ?, ?, ?, ?, ?)" UpdateCommand="UPDATE [tblPersonnel] SET [FirstName] = ?, [LastName] = ?, [PayRate] = ?, [StartDate] = ?, [EndDate] = ? WHERE [ID] = ?">
			<DeleteParameters>
				<asp:Parameter Name="ID" Type="Int32" />
			</DeleteParameters>
			<InsertParameters>
				<asp:Parameter Name="ID" Type="Int32" />
				<asp:Parameter Name="FirstName" Type="String" />
				<asp:Parameter Name="LastName" Type="String" />
				<asp:Parameter Name="PayRate" Type="Int32" />
				<asp:Parameter Name="StartDate" Type="DateTime" />
				<asp:Parameter Name="EndDate" Type="String" />
			</InsertParameters>
			<UpdateParameters>
				<asp:Parameter Name="FirstName" Type="String" />
				<asp:Parameter Name="LastName" Type="String" />
				<asp:Parameter Name="PayRate" Type="Int32" />
				<asp:Parameter Name="StartDate" Type="DateTime" />
				<asp:Parameter Name="EndDate" Type="String" />
				<asp:Parameter Name="ID" Type="Int32" />
			</UpdateParameters>
		</asp:SqlDataSource>
      <br />
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Edit Employees"></asp:Label>
    </form>
</body>
</html>
