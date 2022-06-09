<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="taman.io.View.User.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="min-vh-100 flex items-center justify-content-center px-5 soft-bg">
        <div class="max-w-md w-100">
            <div class="py-5">
                <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                    Edit Profile
                </h2>
                <div class="w-100 d-flex flex-column align-items-center justify-content-center mt-5">
                    <asp:Label ID="FileProfileLabel" class="position-relative" AssociatedControlID="FileProfile" runat="server" Text="">
                        <asp:Image ID="ImageProfile" class="" runat="server" style="width: 200px; height: 200px; object-fit: cover; border-radius: 50%; cursor: pointer;" ImageUrl="~/Image/Assets/logo_full.png" alt="profile"/>
                        
                        <asp:FileUpload ID="FileProfile" accept=".jpg,.jpeg,.gif,.png" runat="server" class="invisible position-absolute start-50 top-50 w-0 h-0" ></asp:FileUpload>
                    </asp:Label>
                    <h6 class="nav-link disabled">Edit Profile Picture</h6>
                </div>
            </div>
            <div class="mt-5 d-flex flex-column w-100">
                <div class="d-flex w-100 flex-column">
                    <div class="mt-3 d-flex flex-column">
                        <label for="name">Name</label>
                        <div class="input-box d-flex">
                            <asp:TextBox ID="FieldName" class="flex-fill" runat="server" placeholder="Name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="mt-3 d-flex flex-column">
                        <label for="email-address">Email address</label>
                        <div class="input-box d-flex">
                            <asp:TextBox ID="FieldEmail" class="flex-fill" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
                        </div>
                    </div>

                    <div class="mt-3 d-flex flex-column">
                        <label for="address">Address</label>
                        <div class="input-box d-flex">
                            <asp:TextBox ID="FieldAddress" class="flex-fill" TextMode="MultiLine" runat="server" style="height: 80px; resize: none;" placeholder="Type your address.."></asp:TextBox>
                        </div>
                    </div>
                    <div class="mt-3 d-flex flex-column">
                        <label for="phone">Phone Number</label>
                        <div class="input-box d-flex">
                            <asp:TextBox ID="FieldPhone" class="flex-fill" runat="server" placeholder="Phone"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="w-100 d-flex justify-content-center mt-5">
                    <asp:Button ID="ButtonSubmit" runat="server" Text="Save Changes" class="login-btn py-2" style="width: 30%" OnClick="ButtonSubmit_Click"/>
                </div>
                <div class="d-flex align-items-center mt-2 justify-content-center" style="color: red;">
                    <p class="m-0">
                        <asp:Label ID="LabelError" runat="server" Visible="false">
                        </asp:Label>
                    </p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
