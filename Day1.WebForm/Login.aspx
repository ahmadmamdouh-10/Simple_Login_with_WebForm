<%@ Page MasterPageFile="~/MasterOne.Master" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Day1.WebForm.Login" %>



<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <style type="text/css">
        .auto-style1 {
            color: #0000FF;
            text-align: center;
            width: 353px;
        }

        .auto-style4 {
            width: 286px;
        }

        .auto-style6 {
            width: 39px;
            color: #0033CC;
        }

        .auto-style7 {
            width: 353px;
            margin-left: 40px;
        }

        .auto-style9 {
            width: 39px;
        }

        .auto-style10 {
            width: 353px;
        }
    </style>

    <script>
        function IsITIEmail(src, args) {
            if (args.Value.includes("@iti.gov.eg"))
                args.IsValid = true;
            else
                args.IsValid = false;

        }

    </script>

    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style6">Login</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">UserName:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUName" ErrorMessage="User Name is Required!" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtUName" Display="Dynamic" ErrorMessage="Not iti Email" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="IsITIEmail">*</asp:CustomValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Password:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtUPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVPassword" runat="server" ControlToValidate="txtUPassword" Display="Dynamic" ErrorMessage="Password is Required!" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Language:</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="DDLLanguages" runat="server" Width="128px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">
                    <asp:CheckBox ID="ChKRM" runat="server" Text="Remember Me" />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="check_Login" />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="LblMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>

