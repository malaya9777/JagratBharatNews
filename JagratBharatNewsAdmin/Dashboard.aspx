<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="JagratBharatNewsAdmin.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            max-width: 85%;
            margin: 30px 50px auto auto;
            grid-template-columns: repeat(2,1fr);
            display: grid;
            grid-gap: 10px;
            grid-template-areas: "userDetails userList" "latestNews scroller" "categories horoscope";
        }

        .UserDetails {
            grid-area: userDetails;
            border: 1px solid rgba(0,0,0,.2);
            border-radius: 3px;
            padding: 20px;
        }

        .UserList {
            grid-area: userList;
            background-color: #b6ff00;
        }

        .LatestNews {
            grid-area: latestNews;
            background-color: #4cff00;
        }

        .Scroller {
            grid-area: scroller;
            background-color: #1539e4;
        }

        .Horoscope {
            grid-area: horoscope;
            background-color: #18ebf2;
        }

        .Categories {
            grid-area: categories;
            text-align: center;
            border-radius: 3px;
            border: 1px solid rgba(0,0,0,.1);
            max-height: 300px;
        }

        .row {
            background-color: rgb(128, 128, 128);
            width: 100%;
            text-align: center;
        }

        .textBox, .checkbox, .btnSubmit {
            display: block;
            height: 30px;
            width: 250px;
            margin: 10px auto auto auto;
        }

        .textBox {
            text-indent: 8px;
            border: 1px solid rgba(0,0,0,.2);
            border-radius: 3px;
        }

        .btnSubmit {
            border: none;
            background-color: #00b715;
            color: #fff;
            border-radius: 3px;
        }

        .row {
            display: inline-flex;
            height: 50px;
        }

        .center {
            margin: auto!important;
        }

        @media (max-width:1400px) {
            .container {
                width: 80%;
                grid-template-columns: repeat(2,1fr);
                display: grid;
                grid-gap: 10px;
                grid-template-areas: "userDetails userList" "latestNews scroller" "categories horoscope";
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="UserDetails">
        </div>
        <div class="UserList">M</div>
        <div class="LatestNews">N</div>
        <div class="Scroller">O</div>
        <div class="Categories">
            <div class="row">
                <asp:TextBox runat="server" ID="txtCategory" CssClass="textBox center" placeholder="Category"></asp:TextBox>
                <asp:Button runat="server" ID="btnAdd" CssClass="btn green center" Text="Add" OnClick="btnAdd_Click" />
            </div>
            <asp:Panel runat="server" ID="pnl" ScrollBars="Vertical" Height="200px">
                <asp:GridView runat="server" ID="grdCategories" GridLines="Horizontal" RowStyle-Height="30" Width="100%" edit BorderWidth="0" OnRowEditing="grdCategories_RowEditing" OnRowUpdating="grdCategories_RowUpdating" OnRowCancelingEdit="grdCategories_RowCancelingEdit" AutoGenerateEditButton="true" AutoGenerateColumns="false" ShowHeader="true">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="true" />
                        <asp:BoundField DataField="Name" HeaderText="Category" ControlStyle-CssClass="textBox" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>

        </div>
        <div class="Horoscope"></div>
    </div>

</asp:Content>
