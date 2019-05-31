﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>File Editor</h1>
        <p class="lead">Please read the file below, enter a word to replace and a word to replace it with. Press the Proceed button.</p>
        <p class="lead">
          

            
    </div>

    <style>
        .text-primary
        {
            margin:auto;
            min-width: 150px;
            max-width: 700px;
            min-height: 210px;
            max-height:220px;
            resize:inherit;
        }
    </style>
   

         <center>
             <asp:TextBox ID="displayBox" runat="server" BorderColor="#CC0099" BorderWidth="2px" Height="212px" ReadOnly="True" TextMode="MultiLine" ToolTip="The Text" CssClass="text-primary" Width="530px">hi daar</asp:TextBox>
        </center>


    <div class="row">
        <div class="col-md-4">
            <h2>Replace words</h2>


            <br />
            <asp:Label ID="Label1" runat="server" Text="Replace: "></asp:Label>
            <asp:TextBox ID="firstWord" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="With: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="secondWord" runat="server"></asp:TextBox>
            <br />
            <br />


            <p>
                &nbsp;<asp:Button ID="btnGo" runat="server" BorderColor="#CC0099" BorderWidth="1px" CssClass="btn" Height="32px" OnClick="btnGo_Click" Text="Proceed" ToolTip="Proceed" Width="128px" />
            </p>
        </div>

    </div>
</asp:Content>
