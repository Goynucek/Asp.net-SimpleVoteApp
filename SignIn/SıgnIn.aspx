<%@ Page Title="" Language="C#" MasterPageFile="~/SignIn.master" AutoEventWireup="true" CodeFile="SıgnIn.aspx.cs" Inherits="SıgnIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
                    <div class="Card" style="width:10em; height:7em; margin-top:10em;margin:auto">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="UsernameText" runat="server" Width="150px"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="PasswordText" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Sign In" Width="160px" OnClick="Button1_Click1" />
        </div>
</asp:Content>

