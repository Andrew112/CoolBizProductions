﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSearchPersonnel.aspx.cs" Inherits="frmSearchPersonnel"  %>

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

   
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="Search for employee by last name:"></asp:Label>
        <asp:TextBox ID="txtSearchName" runat="server"></asp:TextBox>
       <asp:Button ID="btnSearch" runat="server" Text="Search" 
            PostBackUrl="~/frmViewPersonnel.aspx" />
    </div>
    </form>
</body>
</html>
