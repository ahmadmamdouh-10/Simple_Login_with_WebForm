<%@ Page Language="C#" MasterPageFile="~/MasterOne.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Day1.WebForm.Home" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="LblTimes" runat="server" Text="Label">You tried </asp:Label>
        </div>
        <div>
            <asp:Label ID="LblWelcome" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="Log Out" />
        <p>
            <asp:Label ID="LblVisitors" runat="server" ForeColor="#0033CC"></asp:Label>
        </p>
    </form>
</asp:Content>
