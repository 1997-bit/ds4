<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio171._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row"> 
    <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
        AllowSorting="True" AllowPaging="True"
        DataKeyNames="ProductoID"
        AutoGenerateEditButton="true"
        Runat="Server" />

    <asp:SqlDataSource ID="MyDataSource1" runat="server"
        ConnectionString="data source=SQLExpress;ini"
        ProviderName="System.Data.SqlClient"
        SelectCommand="SELECT ProdcutId, ProductName, UnitPrice From Prom"
    </div>

</asp:Content>
