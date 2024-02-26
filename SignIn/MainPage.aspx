<%@ Page Title="" Language="C#" MasterPageFile="~/SignIn.master" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="MainPage.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="Votes">
        <div class="VoteCard">   
            <asp:Image Class="Img" runat="server" Height="185px" Width="189px" ImageUrl="~/Images/BatmanProfile.jpg"/>
            <asp:Button ID="Button1" runat="server" Text="Vote" Width="188px" OnClick="Button1_Click"/>          
            <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
        </div>
        <div class="VoteCard">   
            <asp:Image Class="Img" runat="server" Height="185px" Width="189px" ImageUrl="~/Images/Superman.jpg" />
            <asp:Button ID="Button2" runat="server" Text="Vote" Width="188px" OnClick="Button2_Click" />          
            <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
        </div>
    </div>
</asp:Content>

