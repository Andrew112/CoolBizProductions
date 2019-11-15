<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="frmViewPersonnel" %>
<!--
 * Source: DeVry University :: Lab 4 Partial Solution :: February 1st, 2012
 * Professor:   Richard Martin :: rmartin@devry.edu
 * Comments:
 -->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p align="center">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/frmMain.aspx"><font color="black" size="2"><strong><font color="blue" face="Comic Sans MS" 
            size="4">Cool</font><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font 
            face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, 
        Inc.</font></strong> </font></asp:HyperLink>
        
    </p>

    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Employees"></asp:Label>
    
    </div>
    <asp:GridView ID="grdViewPersonnel" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
