﻿<%@ Page Title="Post News" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PostNews.aspx.cs" Inherits="JagratBharatNewsAdmin.PostNews" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            max-width: 85%;
            margin: 30px 50px auto auto;
            grid-template-columns: 55% 40%;
            display: grid;
            grid-gap: 10px;
        }

        .postNews {
            border: 1px solid rgba(0,0,0,.1);
            border-radius: 5px;
            padding: 10px;
        }

        .latestNews {
            
        }

        .action {
            margin-top: 10px;
        }

        @media (max-width:1400px) {
            .container {
                width: 80%;
                grid-template-columns: 50% 50%;
                display: grid;
                grid-gap: 10px;
            }
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">      
                <div class="postNews">
                    <div class="newsCategory">
                        <asp:DropDownList runat="server" ID="ddlCategory" CssClass="textBox"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rf3" runat="server" ControlToValidate="ddlCategory" ValidationGroup="Main" InitialValue="0" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="newsHeadline">
                        <asp:TextBox runat="server" CssClass="textBox" ID="txtHeadline" placeholder="News Headline" Width="100%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rf1" runat="server" ControlToValidate="txtHeadline" ValidationGroup="Main" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="newsDate">
                        <asp:TextBox runat="server" ID="txtNewsDate" CssClass="textBox" placeholder="News Date" AutoCompleteType="None"></asp:TextBox>
                        <asp:ToolkitScriptManager runat="server"></asp:ToolkitScriptManager>
                        <asp:CalendarExtender TargetControlID="txtNewsDate" Format="dd-MMM-yyyy" runat="server" ID="ce1" />
                    </div>
                    <div class="newsBody">
                        <asp:TextBox runat="server" CssClass="textBox" ID="txtBody" placeholder="News Body" TextMode="MultiLine" Height="500px" Width="100%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rf2" runat="server" ControlToValidate="txtBody" ErrorMessage="*" ValidationGroup="Main" ForeColor="Red"></asp:RequiredFieldValidator>

                    </div>
                    <div class="Embedvideo">
                        <asp:TextBox runat="server" CssClass="textBox" ID="videoEmbed" Width="100%" placeholder="YouTube Video URL"></asp:TextBox>
                    </div>
                    <div class="newsImage">
                        <asp:FileUpload runat="server" CssClass="textBox" ID="fImage" placeholder="Select Image" />
                    </div>

                    <div class="action">                        
                        <asp:Button ID="btnSubmit" runat="server" CssClass="btn green" Text="Submit" ValidationGroup="Main" OnClick="btnSubmit_Click" />
                    </div>
                </div>
           
        <div class="latestNews">
            <asp:GridView ID="grdPost" runat="server" GridLines="Horizontal" HeaderStyle-HorizontalAlign="Left" RowStyle-Height="40" BorderStyle="None" AutoGenerateColumns="false" Width="100%">
                <Columns>
                   <asp:BoundField DataField="Id" HeaderText="ID"  />
                    <asp:BoundField DataField="HeadLine" HeaderText="Head Line"/>                       
                    <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="imgThumnail" runat="server" AlternateText='<%#Eval("OriginalImageURL") %>' ImageUrl='<%#Eval("ThumbnailImageURL") %>' Height="20" Width="40" onclick="openImage(this.alt)"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Preview">
                        <ItemTemplate>
                            <a href='<%#Eval("PreviewURL") %>' target="_blank">Preview</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn orange" CommandArgument='<%# Eval("Id")%>' CommandName="editPost"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Submitted" HeaderText="Submitted" />
                </Columns>
            </asp:GridView>
            <asp:Image ID="imgTest" runat="server" />
        </div>
    </div>
    <script>

        function openImage(ImageURL) {
            console.log(ImageURL);
        }
    </script>
</asp:Content>
