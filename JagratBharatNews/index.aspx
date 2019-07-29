<%@ Page Title="Home" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JagratBharatNews.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="leftSidebar">
            <p style="margin: 10px auto 5px auto; text-align: center">Categories</p>
            <ul runat="server" id="categoryList">
                <%-- Auto Generated Categories --%>
            </ul>
        </div>
        <div class="mainContent">
            <h3>Top Stories</h3>
            <div class="cards" id="cards" runat="server">
                <%-- Auto Generated Cards --%>
            </div>
        </div>
        <div class="rightSidebar">
            <div class="video">
                <div runat="server" id="videoFrame">
                    <%-- Auto Generated Video --%>
                </div>
                <div class="scroll" id="scroll">
                    <p id="para" runat="server">
                        <%-- Auto Generated Scroll --%>
                    </p>
                </div>
            </div>
            <div class="advertisement">
                <p>Advertisement</p>
                <div class="ad">
                </div>
            </div>
            <div class="other">
                <div class="callender">
                    <div id="txtDate" runat="server" class="date">
                        9
                    </div>
                    <div id="txtEvent" runat="server" class="event">
                        Sunday
                    </div>
                    <div id="txtMonthYear" runat="server" class="monthYear">
                        th June 2019
                    </div>
                </div>
                <div class="rashifal">
                    <script>
                        function expand() {
                            let rashi = document.getElementById('ctl00_ContentPlaceHolder1_rashifal');
                            if (rashi.style.display == "block") {
                                rashi.style.display = "none";

                            } else {
                                rashi.style.display = "block";
                            }
                        }
                    </script>
                    <p style="cursor: pointer;padding:5px; border-radius:3px; color:white; background-color:darkviolet; margin-top:5px" onclick="expand()">Rashifal</p>
                    <ul id="rashifal" runat="server">
                        <%--<li>
                            <p>Aries</p>
                        </li>
                        <li>
                            <p>Taurus</p>
                        </li>
                        <li>
                            <p>Gemini</p>
                        </li>
                        <li>
                            <p>Cancer</p>
                        </li>
                        <li>
                            <p>Leo</p>
                        </li>
                        <li>
                            <p>Virgo</p>
                        </li>
                        <li>
                            <p>Libra</p>
                        </li>
                        <li>
                            <p>Scorpio</p>
                        </li>
                        <li>
                            <p>Sgittarius</p>
                        </li>
                        <li>
                            <p>Capricorn</p>
                        </li>
                        <li>
                            <p>Aquarius</p>
                        </li>
                        <li>
                            <p>Pisces</p>
                        </li>--%>
                    </ul>

                </div>
                <div class="watch">
                    <iframe
                        src="https://free.timeanddate.com/clock/i6sq6m47/n1690/szw110/szh110/hocbbb/hbw6/cf100/hgr0/fas16/fdi64/mqc000/mqs4/mql20/mqw2/mqd94/mhc000/mhs3/mhl20/mhw2/mhd94/mmc000/mml10/mmw1/mmd94/hmr7/hsc000/hss1/hsl90"
                        frameborder="0" width="110" height="110"></iframe>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
