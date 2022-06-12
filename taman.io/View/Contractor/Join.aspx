<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="Join.aspx.cs" Inherits="taman.io.View.Contractor.Join" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="min-vh-100 flex items-center justify-content-center px-5 py-5 soft-bg">
        <div class="max-w-md w-100">
            <div class="d-flex flex-column w-100">
            <div class="py-5">
                <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                    Join as Contractors
                </h2>
                <h6 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                    <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
                </h6>
                <div class="w-100 d-flex flex-column align-items-center justify-content-center mt-5">
                    <asp:Image ID="ImageDesign" class="rounded-3" style="width: 400px; height: 300px; object-fit: cover; cursor: pointer" runat="server" alt="Design" />
                    
                    <h6 class="nav-link disabled">Garden Design</h6>
                </div>
            </div>
                <div class="d-flex w-100 flex-column">
                    <div class="mt-3 d-flex flex-column">
                        <label for="email-address">Price Offer<span class="requi" style="color: red">*</span></label>
                        <div class="input-box d-flex">
                            <asp:TextBox ID="FieldPrice" TextMode="Number" class="flex-fill" placeholder="50000" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="w-100 d-flex justify-content-center my-5">
                    <asp:Button ID="ButtonJoin" class="btn_green" runat="server" Text="Join Now" OnClick="ButtonJoin_Click" />
                </div>
                <%--<div class=" text-red-700">
                    @foreach($errors->all() as $e)
                        <ul class="list-disc pl-5 space-y-1">
                        </ul>
                    @endforeach
                </div>--%>
                <div class="mt-2 text-sm d-flex align-items-center justify-content-center" style="color: red;">
                    <p class="m-0">
                        <asp:Label ID="LabelError" runat="server" Visible="false">

                        </asp:Label>
                    </p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
