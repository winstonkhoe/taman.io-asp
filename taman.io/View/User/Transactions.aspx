<%@ Page Title="Transactions | Taman.io" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="taman.io.View.User.Transactions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <script src="/js/search.js" defer></script>
    <link rel="stylesheet" href='css/product.css'>
    <div class="container-fluid d-flex flex-column px-5 background min-vh-100 pt-5 align-items-center" style="">
        <div class="row mb-5">
            <asp:Repeater ID="RepeaterTransaction" runat="server">
                <ItemTemplate>
                <div class="product-card  ms-4 mt-4 py-4 px-5" style="height: 300px; width: 800px">
                    <span class="d-flex flex-column flex-grow-1">
                        <div class="w-100 h-25 d-flex align-items-center">
                            <h6 class="m-0 p-0" style="font-size: 1rem; font-weight: 700;">
                                <%# GetTransactionType((taman.io.Model.transaction_headers)Container.DataItem) %>
                            </h6>
                            <p class="m-0 ms-3 p-0" style="font-size: 1rem; font-weight: 400;">
                                <%# GetTransactionDate((DateTime)Eval("created_at")) %>
                            </p>
                        </div>
                        <div class="w-100 h-75 mt-3" style="">
                            <div class="w-100 h-25 d-flex align-items-center justify-content-between">
                                <a class="m-0 p-0" href="" style="font-size: 1rem; font-weight: 700;">
                                    <asp:Panel ID="PanelArtist" runat="server" Visible="<%# IsGarden((taman.io.Model.transaction_headers)Container.DataItem) %>">
                                        <%# GetContractor((taman.io.Model.transaction_headers)Container.DataItem).design.artist.name %>
                                    </asp:Panel>
                                    <asp:Panel ID="PanelService" runat="server" Visible="<%# IsService((taman.io.Model.transaction_headers)Container.DataItem) %>">
                                        <%# GetContractor((taman.io.Model.transaction_headers)Container.DataItem).seller.name %>
                                    </asp:Panel>
                                    </a>
                                    <asp:Panel ID="PanelContractor" runat="server" Visible="<%# IsGarden((taman.io.Model.transaction_headers)Container.DataItem) %>">
                                        <span class="d-flex align-items-center">
                                            <p class="m-0 p-0 font-weight-bolder" style="font-size: 0.8rem;">Construction </p>
                                            <a class="m-0 ms-2 p-0" href="" style="font-size: 1rem; font-weight: 700;">
                                                <%# GetContractor((taman.io.Model.transaction_headers)Container.DataItem).seller.name %>
                                            </a>
                                        </span>
                                    </asp:Panel>
                            </div>
                            <asp:Panel ID="Panel1" runat="server" Visible="<%# IsGarden((taman.io.Model.transaction_headers)Container.DataItem) %>">
                                <div class="w-100 h-25 d-flex justify-content-between mt-4">
                                    <asp:Image ID="ImageDesign" runat="server" ImageUrl='<%# taman.io.Controller.DesignController.GetImage(GetContractor((taman.io.Model.transaction_headers)Container.DataItem).design.design_images.FirstOrDefault()) %>' style="width: 250px; height: 150px; object-fit: cover" alt=""/>
                                    <div class="w-100 ms-3 d-flex flex-column justify-content-start">
                                        <h6 class="m-0 p-0 mb-3" style="font-size: 1.5rem; font-weight: 600"><%# GetContractor((taman.io.Model.transaction_headers)Container.DataItem).design.name %></h6>
                                        <div class="d-flex justify-content-between" style="width: 250px">
                                            <p class="m-0 p-0" style="font-size: 0.9rem; font-weight: 700; opacity: 0.6;">Design Price</p>
                                            <p class="m-0 p-0" style="font-size: 0.9rem; font-weight: 600; opacity: 0.6;">Rp <%# GetContractor((taman.io.Model.transaction_headers)Container.DataItem).design.price.ToString() %></p>
                                        </div>
                                        <div class="d-flex justify-content-between" style="width: 250px">
                                            <p class="m-0 p-0" style="font-size: 0.9rem; font-weight: 700; opacity: 0.6;">Construction Price</p>
                                            <p class="m-0 p-0" style="font-size: 0.9rem; font-weight: 600; opacity: 0.6;">Rp <%# GetContractor((taman.io.Model.transaction_headers)Container.DataItem).price.ToString() %></p>
                                        </div>
                                        <hr class="my-2 w-50">
                                        <div class="d-flex flex-column">
                                            <p class="m-0 p-0" style="font-size: 0.9rem; font-weight: 700; opacity: 0.8;">Total</p>
                                            <h3 class="m-0 p-0" style="font-size: 1.4rem; font-weight: 700;">Rp <%# (GetContractor((taman.io.Model.transaction_headers)Container.DataItem).price + GetContractor((taman.io.Model.transaction_headers)Container.DataItem).design.price).ToString() %></h3>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                        </div>
                    </span>
                </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
