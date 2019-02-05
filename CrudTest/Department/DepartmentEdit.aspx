<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentEdit.aspx.cs" Inherits="CrudTest.Department.DepartmentEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit</h2>
    <form>
        <div class="form-group">
            <asp:Label runat="server">Department Name</asp:Label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDepName" AutoCompleteType="Disabled"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server">Department Code</asp:Label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDepCode" OnDataBinding="btnDepCreate_Click"></asp:TextBox>
        </div>
        <div class="form-group">
            <%--<button id="btnDepCreate" class="btn btn-success">Save</button>--%>
            <asp:Button runat="server" ID="btnDepCreate" Text="Save" CssClass="btn btn-success" OnClick="btnDepCreate_Click"/>
        </div>
        <div class="form-group">
            
        </div>
        
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </form>
</asp:Content>
