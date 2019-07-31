<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="JagratBharatNews.SearchResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .container {
            max-width: 800px;
            margin: 80px auto 10px auto;
            padding: 0px 20px 0px 20px;
        }
        .results{
            background-color:rgba(94, 94, 94, 0.50);
            padding:10px;
        }
        .result{            
            margin:10px auto 0px auto;
            display:grid;
            grid-template-rows:50% 50%;
            grid-template-columns:30% 65%;
            grid-gap:20px;
            padding:10px;
            border-radius:5px;
            background-color:rgb(255, 255, 255);
        }
        .result > img{
            grid-row: span 2;
            border-radius:4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="searchTerm">
            <h5 id="searchTerm" runat="server"></h5>
        </div>
        <div class="ads"></div>
        <div id="results" class="results" runat="server">
            
        </div>
        <div class="ads">

        </div>
    </div>
</asp:Content>
