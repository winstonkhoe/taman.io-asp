<%@ Page Title="Login | Taman.io" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="taman.io.View.User.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="w-100 position-relative" style="min-height: calc(100vh)">
        <div class="card position-absolute login-wrapper">
            <div class="w-100 h-100 login-card overflow-hidden">
            <div class="w-100 h-100 mx-auto d-flex flex-column align-items-center justify-content-center py-5">
                <h3 class="header">LOGIN</h3>
                <asp:Image ID="ImageLogo" class="my-5" runat="server" style="object-fit: contain; object-position: center; width: 150px; height: 150px;" ImageUrl="~/Image/Assets/logo_full.png" alt="plantSop"/>
                <div class="w-100 h-75 d-flex flex-column align-items-center" style="height: 75%">
                    <div class="w-75 py-3 login-input mb-3" >
                        <div class="h-100 w-100 px-3 d-flex align-items-center" >
                            <i class="fa-solid fa-user"></i>
                            <asp:TextBox ID="FieldEmail" class="w-100 px-2" runat="server" TextMode="Email" placeholder="user@tamanio.com"></asp:TextBox>
                        </div>
                    </div>
                    <div class="w-75 py-3 login-input mb-1" >
                        <div class="h-100 w-100 px-3 d-flex align-items-center" >
                            <i class="fa-solid fa-lock"></i>
                            <asp:TextBox ID="FieldPassword" class="w-100 px-2" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="w-75 d-flex justify-content-between mb-5 px-3">
                        <div class="d-flex items-center">
                            <input type="checkbox" name="remember_me" id="">
                            <span class="ms-2 hyperlink">Remember Me</span>
                        </div>
                        <a class="hyperlink" href="/View/User/Register.aspx">Create Account</a>
                    </div>
                    <div class="w-75 d-flex align-items-center mb-2 justify-content-center" style="color: red;">
                                <p class="m-0">
                                    <asp:Label ID="LabelError" runat="server" Visible="false">

                                    </asp:Label>
                                </p>
                            </div>
                    <asp:Button ID="ButtonSubmit" runat="server" Text="LOGIN" class="login-btn py-2" style="width: 30%" OnClick="LoginBtn_Click"/>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
