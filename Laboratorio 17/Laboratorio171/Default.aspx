<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio171._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row"> 
        <asp:GridView 
            ID="GridView1" 
            runat="server" 
            AutoGenerateEditButton="True" 
            DataSourceID="SqlDataSource1" 
            AutoGenerateColumns="True">
        </asp:GridView>

        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:NorthwindConnection %>"
            SelectCommand="SELECT * FROM Products" 
            UpdateCommand="UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitPrice WHERE ProductID=@ProductID">
        </asp:SqlDataSource>
    </div>  

</asp:Content>