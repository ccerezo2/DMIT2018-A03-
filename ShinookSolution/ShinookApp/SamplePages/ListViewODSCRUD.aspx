<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListViewODSCRUD.aspx.cs" Inherits="ShinookApp.SamplePages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1> ListView ODS CRUD</h1>
    <blockquote>
        This page will demonstrate a CRUD process using the ListView control
        and only ODS Datasources. Web control Validation will be demonstrated
        under the EditTemplate and InsertTemplate
    </blockquote>
    <asp:ListView ID="AlbumList" runat="server"></asp:ListView>
    <asp:ObjectDataSource ID="AlbumListODS" runat="server" 
        DataObjectTypeName="ChinookSystem.Data.Entities.Album"
        DeleteMethod="Album_Delete" 
        InsertMethod="Album_Add" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="Album_List" 
        TypeName="ShinookSystem.BLL.AlbumController" 
        UpdateMethod="Album_Update">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ArtistListODS" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="Artist_List" 
        TypeName="ShinookSystem.BLL.ArtistController">
    </asp:ObjectDataSource>
</asp:Content>

