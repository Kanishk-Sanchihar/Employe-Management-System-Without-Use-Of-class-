<%@ Page Title="" Language="C#" MasterPageFile="~/employee.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td>Enter Employee id</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" style="height: 29px" />
            </td>
        </tr>
    </table>
    <table class="auto-style6">
        <tr>
            <td>Employee Name</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Employee Designation</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Employe Department</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" style="margin-bottom: 4px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Salary</td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <table class="auto-style6">
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
            </td>
        </tr>
    </table>
</asp:Content>

