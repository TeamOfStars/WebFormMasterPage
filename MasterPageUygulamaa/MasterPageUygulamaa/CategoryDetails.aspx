<%@ page title="" language="C#" masterpagefile="~/AnaSayfa.Master" autoeventwireup="true" codebehind="CategoryDetails.aspx.cs" inherits="MasterPageUygulamaa.CategoryDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>kategori sayfası</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlace" runat="server">
    <div style="width: 800px; height: 420px; float: left">
        <asp:GridView runat="server" ID="kategoriGrid" AutoGenerateColumns="false" OnRowCommand="kategoriGrid_RowCommand" DataKeyNames="productID">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Unit price" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="Stock" />
               <asp:ButtonField ButtonType="Link" Text="seç" CommandName="sec"/>
            </Columns>
        </asp:GridView>
        <asp:Label Text="" runat="server" ID="blg" />
        <asp:GridView runat="server" ID="bilgi">

        </asp:GridView>
    </div>
</asp:Content>
