<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addDep.aspx.cs" Inherits="addDep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <fieldset>
        <legend><h2>Add Department</h2></legend>
    <asp:textbox ID="TextBox1" runat="server"></asp:textbox><br /><br />
    <asp:textbox ID="TextBox2" runat="server"></asp:textbox><br /><br />
    <asp:button ID="Button1" runat="server" text="Add" OnClick="Button1_Click" />
        </fieldset>
</asp:Content>

