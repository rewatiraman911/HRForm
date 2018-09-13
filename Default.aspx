<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table table-bordered table-hover">
        <asp:repeater id="repeater1" runat="server">
            <HeaderTemplate>
            <tr>
                <th>DepartmentID</th>
                <th>DepartmentName</th>
            </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("DepId")%></td>
                    <td><%# Eval("DepName")%></td>
                </tr>
            </ItemTemplate>
        </asp:repeater>
    </table>
</asp:Content>

