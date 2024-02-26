<%@ Page Title="" Language="C#" MasterPageFile="~/SignIn.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div class="Card" style="width:10em; height:7em; margin-top:10em;margin:auto">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="UsernameText" runat="server" Width="151px"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="PasswordText" runat="server" OnTextChanged="PasswordText_TextChanged" TextMode="Password" Width="151px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Log In" Width="160px" OnClick="Button1_Click1" />
                        <div style="margin:auto; width:3em; height:1em;">
                  <a href="SıgnIn.aspx">Sign In</a>
        </div>
            </div>
</asp:Content>

