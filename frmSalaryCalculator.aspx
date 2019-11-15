<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
		<link rel="Stylesheet" type="text/css"
	   href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Annual Hours"></asp:Label>
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
    
        <asp:HyperLink ID="HyperLink1" runat="server" 
            ImageUrl="~/images/CoolBiz_Productions_logo.JPG" NavigateUrl="~/frmMain.aspx">HyperLink</asp:HyperLink>
    
    </div>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Rate"></asp:Label>
        <asp:TextBox ID="txtRate" runat="server" style="margin-left: 56px" Width="120px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Calculate Salary" style="margin-left: 71px" Width="250px" />
    </p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
