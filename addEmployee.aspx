<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addEmployee.aspx.cs" Inherits="addEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Emp ID" CssClass="form-control"></asp:TextBox><br /><br />
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Emp Name" CssClass="form-control" ></asp:TextBox><br /><br />
    <asp:TextBox ID="TextBox3" runat="server" placeholder="Salary" CssClass="form-control"></asp:TextBox><br /><br />
    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropdown"></asp:DropDownList><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Add" cssClass="btn btnp-primary" OnClick="Button1_Click"/> 
</asp:Content>
  
