<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="CrudTest.Student.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create Department</h2>
    <form id="studentform">
        <div class="form-group">
            <asp:Label runat="server">Department Name</asp:Label>
            <asp:TextBox  CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server">Department Code</asp:Label>
            <asp:TextBox runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <div class="form-group">
            <button class="btn btn-success">Save</button>
        </div>
        
        
    </form>
</asp:Content>
