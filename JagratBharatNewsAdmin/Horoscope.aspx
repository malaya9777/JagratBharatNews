<%@ Page Title="Horoscope" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Horoscope.aspx.cs" Inherits="JagratBharatNewsAdmin.Horoscope" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            max-width: 85%;
            margin: 30px 50px auto auto;
            grid-template-columns: 50% 50%;
            display: grid;
            grid-gap: 10px;
        }
        .postHoroscope, .todaysHoroscope{
            border: 1px solid rgba(0,0,0,.1);
            border-radius: 5px;
            padding: 10px;
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
        
        <div class="postHoroscope">
            <h3>Post Horoscope</h3>
            <div class="date">
                <asp:TextBox ID="txtDate" runat="server" CssClass="textBox" AutoCompleteType="None"></asp:TextBox>
                <asp:ToolkitScriptManager runat="server"></asp:ToolkitScriptManager>
                <asp:CalendarExtender runat="server" ID="ce1" TargetControlID="txtDate" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                <asp:RequiredFieldValidator ControlToValidate="txtDate" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="zodiac">
                <asp:DropDownList ID="ddlZodiac" runat="server" CssClass="textBox"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" InitialValue="0" ControlToValidate="ddlZodiac" ID="rfv1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="horoscope">
                <asp:TextBox TextMode="MultiLine" CssClass="textBox" runat="server" ID="txtHoroscope" Height="200"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="rfv2" ControlToValidate="txtHoroscope" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="submit">
                <asp:Button runat="server" Text="Submit" CssClass="btnSubmit" ID="btnSubmit" OnClick="btnSubmit_Click" />
            </div>
        </div>
        <div class="todaysHoroscope">
            <h3>Today's Horoscope</h3>
            <div class="selectDate">
                <asp:DropDownList ID="ddlDate" runat="server" CssClass="textBox" OnSelectedIndexChanged="ddlDate_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="gridList">
                <asp:GridView ID="grdHoroscope" runat="server" GridLines="Horizontal" Width="100%" HeaderStyle-Font-Bold="false" HeaderStyle-HorizontalAlign="Left" RowStyle-Height="40" BorderStyle="None" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="SL No">
                            <ItemTemplate>
                                <%# Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="zodiac" HeaderText="Zodiac" />
                        <asp:BoundField DataField="Horoscope_English" HeaderText="Horoscope" />
                       
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" Text="Submit" CssClass="btn green" CommandArgument='<%# Eval("ID") %>' CommandName="editHoroscope" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
