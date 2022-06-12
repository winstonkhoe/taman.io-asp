<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="taman.io.View.Design.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <script src="/js/design.js"></script>
    <div class="container-fluid d-flex flex-column px-5 background min-vh-100 pt-5" style="">
        <h5 class="product-title header" style="font-weight: 700; font-size: 1.5rem;">
            <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
        </h5>
            <div class="w-50" style="height: 300px">
                <asp:Image ID="ImageDesign" class="w-100 h-100 br-card" runat="server" alt="Design" style="object-fit: cover; object-position: center"/>
            </div>
            <div class="d-flex mt-5 flex-grow">
                <div class="details d-flex flex-column w-75">
                    <section class="w-100">
                        <h5 class="product-title header my-3" style="font-weight: 600; font-size: 1.2rem;">Details</h5>
                        <p>
                            <asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label>
                        </p>
                    </section>
                    <section class="w-100">
                        <h5 class="product-title header my-3" style="font-weight: 600; font-size: 1.2rem;">Contractors</h5>
                        <div class="container-fluid d-flex w-100">
                            <div class="row w-100">
                                <asp:Repeater ID="RepeaterContractors" runat="server">
                                    <ItemTemplate>
                                        <div class="col-4">
                                            <label class="constructor-option w-100 h-100" >
                                                <%--<asp:RadioButton ID='<%# Eval("seller.id") %>' runat="server"  />--%>
                                                <%--<input type="radio" name="offer_id" id=<%# Eval("seller.id") %> value=<%# Eval("id") %> />--%>

                                                <div class="container br-card d-flex align-items-center p-3 mt-4" onclick="setPrice(`<%# Eval("price") %>`, `<%# GetTotal((int)Eval("price")) %>`)">
                                                    <div class="" style="height: 50px; width: 50px">
                                                        <asp:Image ID="Image1" class="w-100 h-100 rounded-circle" runat="server" ImageUrl='<%# GetImage(Eval("seller")) %>' alt="profile-picture" style="object-fit: cover; object-position: center"/>
                                                    </div>
                                                    <div class="d-flex flex-column ms-3">
                                                        <p class="m-0 p-0" style="font-weight: 800">
                                                            <%# Eval("seller.name") %>
                                                        </p>
                                                        <p class="m-0 p-0" style="font-size: 0.75rem; font-weight: 600">
                                                            Rp <%# Eval("price") %>
                                                        </p>
                                                    </div>
                                                </div>
                                            </label>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </section>
                </div>
                <div class="summary container br-card w-25 mb-5">
                    <div class="d-flex flex-column p-3">
                        <h6 class="header" style="font-size: 1.3rem; font-weight: 700;">Summary</h6>
                        <div class="d-flex w-100 justify-content-between">
                            <h6 class="header" style="font-size: 1rem; font-weight: 400;">Biaya Design</h6>
                            <h6 class="header" style="font-size: 1rem; font-weight: 400;">Rp <asp:Label ID="LabelDesignPrice" runat="server" Text=""></asp:Label></h6>
                        </div>
                        <div class="d-flex w-100 justify-content-between">
                            <h6 class="header" style="font-size: 1rem; font-weight: 400;">Biaya Konstruksi</h6>
                            <h6 id="construction-price" class="header" style="font-size: 1rem; font-weight: 400;">Rp <asp:Label ID="LabelConstructorPrice" runat="server" Text=""></asp:Label></h6>
                        </div>
                        <hr class="summary-separator">
                        <div class="d-flex w-100 justify-content-between">
                            <h6 class="header" style="font-size: 1.3rem; font-weight: 700;">Total Cost</h6>
                            <h6 id="final-price" class="header" style="font-size: 1.3rem; font-weight: 700;"><asp:Label ID="LabelTotalPrice" runat="server" Text=""></asp:Label></h6>
                        </div>

                        <asp:Button ID="ButtonBuilding" class="mt-5 flex-fill btn_green" runat="server" Text="Start Building" OnClick="ButtonBuilding_Click" />

                        <asp:Panel ID="PanelModifications" runat="server" Visible ="false">
                            <button class="mt-5 flex-fill w-100 d-flex text-center">Modify Design</button>
                            <button class="mt-2 flex-fill w-100 d-flex text-center">Remove Design</button>
                        </asp:Panel>
                        <asp:Panel ID="PanelContractorQuit" runat="server" Visible ="false">
                            <a href="#" class="mt-2 w-100 d-flex">
                                <asp:Button ID="ButtonQuit" class="flex-fill btn_green" runat="server" Text="Quit From Contractor Geng" OnClick="ButtonQuit_Click" />
                            </a>
                        </asp:Panel>
                        <asp:Panel ID="PanelContractorJoin" runat="server" Visible ="false">
                            <a href="#" class="mt-2 w-100 d-flex">
                                <asp:Button ID="ButtonJoin" class="flex-fill btn_green" runat="server" Text="Join Contractor Geng" OnClick="ButtonJoin_Click" />
                            </a>
                        </asp:Panel>

                    </div>
                </div>
            </div>
    </div>
</asp:Content>
