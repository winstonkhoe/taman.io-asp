<%@ Page Title="Home" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="taman.io.View.Common.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="container-fluid d-flex flex-column px-5 background min-vh-100 pt-5" style="">
        <div class="row mb-5">
            <asp:Repeater ID="designRpt" runat="server">
                <ItemTemplate>
                    <div class="product-card  ms-4 mt-4 p-0" style="width: 230px">
                    <a class="d-flex flex-column flex-grow-1" href='/View/Design/Home.aspx?id=<%# Eval("id") %>'>
                        <div class="w-100" style="height: 200px">
                            <asp:Image ID="Image1" class="w-100 h-100" alt="Design" style="object-fit: cover; object-position: center" runat="server" 
                                ImageUrl='<%# "~/Image/" + GetImage(Container.DataItem) %>'
                                />
                        </div>
                        <div class="w-100 h-100 d-flex flex-column p-3">
                            <h5 class="product-title header" style="font-weight: 800"><%# Eval("name") %></h5>
                            <div class="d-flex flex-grow-1">
                                <div class="d-flex flex-column w-100">
                                    <div class="d-flex align-items-center mb-2">
                                        <i class="fa-solid fa-paintbrush fa-xs"></i>
                                        <b class="product-artist header m-0 ms-2 p-0"><%# Eval("artist.name") %></b>
                                    </div>
                                    <h6 class="card-subtitle mb-2 text-muted">Rp <%# Eval("price") %></h6>
                                </div>
                                <div class="card-separator"></div>
                                <div class="d-flex flex-column w-100 h-100 overflow-hidden">
                                    <div class="d-flex w-100 mb-2 align-items-center justify-content-between">
                                        <i class="fa-solid fa-hammer fa-xs"></i>
                                        <b class="header m-0 ms-1 p-0" style="font-size: 0.7rem">Contractors</b>
                                    </div>
                                    <asp:Repeater ID="contractorsRpt" runat="server" DataSource='<%# GetOffers(Eval("garden_offers")) %>'>
                                        <ItemTemplate>
                                            <p class="m-0 p-0" style="font-size: 0.7rem"><%# Eval("seller.name") %></p>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                    </a>
                </div>
                </ItemTemplate>
            </asp:Repeater>  
        </div>
    </div>
</asp:Content>
