<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="JagratBharatNews.News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        @import url('https://fonts.googleapis.com/css?family=Montserrat&display=swap');        

        .container {
            max-width: 800px;
            margin: 80px auto 10px auto;
            padding: 0px 20px 0px 20px;
        }

        .justified {
            margin-top: 15px;
            text-align: justify;
        }

        .header {
            position: relative;
            text-align: center;
            height: 500px;
        }

        .PostHeader {
            color: rgba(255,255,255,.8);
            position: absolute;
            bottom: 20px;
            left: 20px;
        }

        .cat{
            margin-top: 15px;
            height: 40px;
            width: 200px;
            background-color: red;
        }

        .categoryInner {
            text-align: center;
            padding-top: 5%;
            color: rgb(255,255,255);
        }

        .infoDetails {
            margin-top: 10px;
            text-align: left;
            color: rgb(0,0,0);
        }  

        

        @media(max-width:600px) {
            .header {
                position: relative;
                text-align: center;
                height: 200px;
            }

            .PostHeader {
                color: rgba(255,255,255,.8);
                position: absolute;
                bottom: 5px;
                left: 5px;
            }
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <main>
            <article>
                <div id="heading" runat="server" class="header">
                    <h2 id="PostHeader" class="PostHeader" runat="server"></h2>
                </div>
                <div class="cat">
                    <p id="category" class="categoryInner" runat="server"></p>
                </div>
                <div class="info">
                    <p id="info" class="infoDetails" runat="server"></p>
                </div>
                <div id="PostContent" runat="server"></div>
                <div id="ads" runat="server"></div>

            </article>
        </main>
    </div>

</asp:Content>
