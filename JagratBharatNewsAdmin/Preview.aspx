<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Preview.aspx.cs" Inherits="JagratBharatNewsAdmin.Preview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        @import url('https://fonts.googleapis.com/css?family=Montserrat&display=swap');

        * {
            padding: 0;
            margin: 0;
            font-family: 'Montserrat', sans-serif;
        }

        .container {
            max-width: 800px;
            margin: 10px auto 10px auto;
            padding: 0px 20px 0px 20px;
        }

        .justified {
            margin-top: 15px;
            text-align: justify;
            
        }

        .heading {
            position: relative;
            text-align: center;
            height: 500px;
            
        }

        #PostHeader {
            color: rgba(255,255,255,.8);
            position: absolute;
            bottom: 20px;
            left: 20px;
        }

        .category {
            margin-top: 15px;
            height: 40px;
            width: 200px;
            background-color: red;
        }

        #category {
            text-align: center;
            padding-top: 5%;
            color: rgb(255,255,255);
        }

        #info {
            margin-top: 10px;
            text-align: left;
            color: rgb(0,0,0);
        }

        @media(max-width:600px) {
            .heading {
                position: relative;
                text-align: center;
                height: 200px;
                
            }

            #PostHeader {
                color: rgba(255,255,255,.8);
                position: absolute;
                bottom: 5px;
                left: 5px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <main>
                <article>
                    <div id="heading" runat="server" class="heading">
                        <h2 id="PostHeader" runat="server"></h2>
                    </div>
                    <div class="category">
                        <p id="category" runat="server"></p>
                    </div>
                    <div class="info">
                        <p id="info" runat="server"></p>
                    </div>
                    <div id="PostContent" runat="server"></div>
                    <div id="ads" runat="server"></div>
                </article>
            </main>
        </div>
    </form>
</body>
</html>
