<%@ Page Title="Register | Taman.io" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="taman.io.View.User.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="w-100 position-relative" style="min-height: calc(100vh)">
        <div class="card position-absolute login-wrapper" style="height: 700px">
            <div class="w-100 h-100 login-card overflow-hidden">
                <div class="w-100 h-100 mx-auto d-flex flex-column align-items-center py-5">
                    <div class="w-100 h-100">
                        <div class="w-100 h-75 d-flex flex-column align-items-center" style="height: 75%">
                            <h3 class="m-0 header">REGISTER</h3>
                            <asp:Image ID="ImageLogo" class="my-3" runat="server" style="object-fit: contain; object-position: center; width: 120px; height: 120px;" ImageUrl="~/Image/Assets/logo_full.png" alt="plantSop"/>
                            <div class="w-75 py-2 login-input mb-2" >
                                <div class="h-100 w-100 px-3 d-flex align-items-center" >
                                    <div class="icon-input d-flex align-items-center">
                                        <i class="fa-solid fa-user"></i>
                                    </div>
                                    <asp:TextBox ID="FieldName" class="w-100 px-2" runat="server" placeholder="Name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="w-75 py-2 login-input mb-2" >
                                <div class="h-100 w-100 px-3 d-flex align-items-center" >
                                    <div class="icon-input d-flex align-items-center">
                                        <i class="fa-solid fa-at"></i>
                                    </div>
                                    <asp:TextBox ID="FieldEmail" class="w-100 px-2" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
                                </div>
                            </div>
                            <div class="w-75 py-2 login-input mb-2" >
                                <div class="h-100 w-100 px-3 d-flex align-items-center" >
                                    <div class="icon-input d-flex align-items-center">
                                        <i class="fa-solid fa-user"></i>
                                    </div>
                                    <asp:TextBox ID="FieldPhone" class="w-100 px-2" runat="server" placeholder="Phone"></asp:TextBox>
                                </div>
                            </div>
                            <div class="w-75 py-2 login-input mb-2" >
                                <div class="h-100 w-100 px-3 d-flex align-items-center" >
                                    <div class="icon-input d-flex align-items-center">
                                        <i class="fa-solid fa-lock"></i>
                                    </div>
                                    <asp:TextBox ID="FieldPassword" class="w-100 px-2" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="w-75 py-2 login-input mb-2" >
                                <div class="h-100 w-100 px-3 d-flex align-items-center" >
                                    <div class="icon-input d-flex align-items-center">
                                        <i class="fa-solid fa-lock"></i>
                                    </div>
                                    <asp:TextBox ID="FieldConfirmPassword" class="w-100 px-2" runat="server" TextMode="Password" placeholder="Confirm Password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="w-75 py-2 login-input mb-1" >
                                <div class="h-100 w-100 px-3 d-flex align-items-center" >
                                    <div class="icon-input d-flex align-items-center">
                                        <i class="fa-solid fa-map"></i>
                                    </div>
                                    <asp:TextBox ID="FieldAddress" class="w-100 register-textarea px-2" TextMode="MultiLine" runat="server" style="height: 80px; resize: none;" placeholder="Type your address.."></asp:TextBox>
                                </div>
                            </div>
                            <div class="w-75 d-flex justify-between mb-2 px-3">
                                <a class="hyperlink" href="/View/User/Login.aspx">Already have an account?</a>
                            </div>
                            <div class="w-75 d-flex align-items-center mb-2 justify-content-center" style="color: red;">
                                <p class="m-0">
                                    <asp:Label ID="LabelError" runat="server" Visible="false">

                                    </asp:Label>
                                </p>
                            </div>
                            <asp:Button ID="ButtonSubmit" runat="server" Text="REGISTER" class="login-btn py-2" style="width: 30%" OnClick="RegisterBtn_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
