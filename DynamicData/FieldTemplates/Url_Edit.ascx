﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Url_Edit.ascx.cs" Inherits="Url_EditField" %>


<asp:TextBox ID="TextBox1" runat="server" CssClass="DDTextBox" Text='<%# FieldValueEditString %>' TextMode="Url"></asp:TextBox>


<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="Static" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="Static" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="Static" />

