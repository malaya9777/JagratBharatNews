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
            text-align:left;
            padding:0px 10px 0px 0px;
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
        h5.relatedNews{
            background-color:darkviolet;
            padding:5px;
            color:#fff;
        }

        .catSpan {
            position: relative;
            padding: 5px;
            background-color: red;
            float: left;
            display: block;
            color: white;
            top: 15px;
        }

        .cardHeadline {
            text-align: left;
        }

        .cards {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            grid-gap: 5px;
            padding: 10px;
            background-color: rgba(0,0,0,.1);
        }

        .card {
            background-color: rgba(255, 255, 255, 1);
            border: 1px solid rgba(0, 0, 0, .1);
            padding: 5px;
            border-radius: 5px;
        }

            .card > img {
                width: 100%;
            }

            .card > h4 {
                text-align: left;
                text-indent: 10px;
            }

            .card > p {
                padding: 5px;
                text-align: justify;
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
                text-align:left;
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
                <div id="ads1" runat="server"></div>
                <div class="cat">
                    <p id="category" class="categoryInner" runat="server"></p>
                </div>
                <div class="info">
                    <p id="info" class="infoDetails" runat="server"></p>
                </div>
                <div id="PostContent" runat="server"></div>
                <h5 class="relatedNews">Related News</h5>
                <div id="RelatedNews" class="cards" runat="server">
                    
                </div>
                <div id="ads" runat="server"></div>

            </article>
        </main>
    </div>

</asp:Content>
