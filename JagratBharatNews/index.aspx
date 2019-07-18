<%@ Page Title="Home" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JagratBharatNews.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="leftSidebar">
            <ul>
                <li><a href="#">Fasion</a></li>
                <li><a href="#">Sceince</a></li>
                <li><a href="#">Technology</a></li>
                <li><a href="#">Health</a></li>
                <li><a href="#">Daily News</a></li>
            </ul>
        </div>
        <div class="mainContent">
            <h3>News Team</h3>
            <div class="cards">
                <div class="card">
                    <img src="https://source.unsplash.com/200x200/?face" alt="people">
                    <h4>Jhon Doe</h4>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam nulla, in, et perspiciatis
                        dolores explicabo
                    </p>
                </div>
                <div class="card">
                    <img src="https://source.unsplash.com/200x200/?face" alt="people">
                    <h4>Jhon Doe</h4>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam nulla, in, et perspiciatis
                        dolores explicabo
                    </p>
                </div>
                <div class="card">
                    <img src="https://source.unsplash.com/200x200/?face" alt="people">
                    <h4>Jhon Doe</h4>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam nulla, in, et perspiciatis
                        dolores explicabo
                    </p>
                </div>
                <div class="card">
                    <img src="https://source.unsplash.com/200x200/?face" alt="people">
                    <h4>Jhon Doe</h4>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam nulla, in, et perspiciatis
                        dolores explicabo
                    </p>
                </div>
                <div class="card">
                    <img src="https://source.unsplash.com/200x200/?face" alt="people">
                    <h4>Jhon Doe</h4>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam nulla, in, et perspiciatis
                        dolores explicabo
                    </p>
                </div>
                <div class="card">
                    <img src="https://source.unsplash.com/200x200/?face" alt="people">
                    <h4>Jhon Doe</h4>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam nulla, in, et perspiciatis
                        dolores explicabo
                    </p>
                </div>
            </div>
        </div>
        <div class="rightSidebar">
            <div class="video">
                <iframe width="100%" src="https://www.youtube.com/embed/wKAsYNcQ34A?controls=0" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                <div class="scroll" id="scroll">
                    <p id="para" runat="server">
                       
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
                    <p>Rashifal</p>
                    <ul>
                        <li>
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
                        </li>
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
