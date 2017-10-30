﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NoRole.aspx.cs" Inherits="SCM.Web.NoRole" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户权限</title>
    <link href="Css/CommonStyle.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" runat="server">
    <table style="margin-left: auto; margin-right: auto; margin-top: 50px;">
        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/noRole.gif" />
            </td>
            <td style="height: 100px; font-size: 60px; font-family: 华文仿宋; text-align: center;">
                您的权限不足
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center;">
                <asp:LinkButton PostBackUrl="#" ID="btnClose" runat="server" Text="关闭页面" CssClass="LinkButton3"
                    Visible="false" Enabled="false"></asp:LinkButton>
            </td>
        </tr>
        <tr>
        <td colspan="2">
        <hr />
        </td>
        </tr>
        <tr>
        <td colspan="2" style="text-align:center;">
             如若想打开此页面，请与管理员联系，并取得权限
        </td>
        </tr>
    </table>
    </form>
</body>
</html>
