<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table table-bordered table-hover">
        <asp:repeater id="repeater2" runat="server">
            <HeaderTemplate>
            <tr>
                <th>EmpID</th>
                <th>EmpName</th>
                <th>Salary</th>
                <th>DepID</th>
                <th>DepName</th>
            </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("empid")%></td>
                    <td><%# Eval("ename")%></td>
                    <td><%# Eval("salary")%></td>
                    <td><%# Eval("depid")%></td>
                    <td><%# Eval("depname")%></td>
                </tr>
            </ItemTemplate>
        </asp:repeater>
    </table>
</asp:Content>

