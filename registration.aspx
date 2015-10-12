<%@ Page Language="VB" MasterPageFile="~/wsc.master" AutoEventWireup="false" CodeFile="registration.aspx.vb" Inherits="registration" title="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Register</h1>
    <p>
        First Name:
        <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
    </p>
    <p>
        Last Name:
        <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
    </p>
    <p>
        Address:
        <asp:TextBox ID="testAddress" runat="server"></asp:TextBox>
    </p>
    <p>
        Phone Number:
        <asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox>
    </p>
    <p>
        Username:
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox></p>
    <p>
        Password:
        <asp:TextBox ID="userPassword" runat="server" TextMode="Password"></asp:TextBox></p>
    <p>
        <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />&nbsp;</p>
</asp:Content>
