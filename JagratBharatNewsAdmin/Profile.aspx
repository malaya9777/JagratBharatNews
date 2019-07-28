<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="JagratBharatNewsAdmin.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            max-width: 85%;
            margin: 30px 50px auto auto;
            display: grid;
            grid-template-columns: repeat(2,1fr);
            grid-gap: 10px;
            grid-template-areas: "profileInfo resetRequest";
        }

        .profileInformation {
            padding:10px;
            border: 1px solid rgba(0,0,0,.2);
            border-radius: 3px;
            grid-area: profileInfo;
            display:grid;
            grid-template-columns: repeat(2,1fr);
            grid-gap: 5px;
        }

        .resetRequest {
            padding:10px;
            border: 1px solid rgba(0,0,0,.2);
            border-radius: 3px;
            grid-area: resetRequest;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="profileInformation">
            <div>User Name</div><div id="userName" runat="server"></div>
            <div>Role</div><div id="role" runat="server"></div>
            <div>Email</div><div id="email" runat="server"></div>
            <div>Mobile</div><div id="mobile" runat="server"></div>
            <div>Created On</div><div id="createdOn" runat="server"></div>
            <div>Created By</div><div id="createdBy" runat="server"></div>
        </div>
        <div class="resetRequest">
            <div class="notAllowed" runat="server" id="notAllowed">
                <p>
                    You are not authorized to view this page!<br>
                    Please contack administrator.
                </p>
            </div>
            <asp:GridView ID="grdUsers" runat="server" Width="100%" GridLines="Horizontal" RowStyle-Height="30" AutoGenerateColumns="false">
                <Columns>

                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
