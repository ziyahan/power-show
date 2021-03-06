﻿<%@ Page Title="" Language="VB" MasterPageFile="~/ComboBox/ComboBox.master" AutoEventWireup="true" CodeFile="vb_settings_customtext.aspx.vb" Inherits="ComboBox_vb_settings_customtext" %>
<%@ Register TagPrefix="obout" Namespace="Obout.ComboBox" Assembly="obout_ComboBox" %>
<%@ Register TagPrefix="obout" Namespace="Obout.Interface" Assembly="obout_Interface" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
    
    <span class="tdText"><b>ASP.NET ComboBox - AllowCustomText</b></span>
    
    <br /><br />
    
    <obout:OboutCheckBox runat="server" ID="OboutCheckBox1" 
        Text="Allow Custom Text" AutoPostBack="true" Checked="true" OnCheckedChanged="OboutCheckBox1_CheckedChanged" /> 
        
    <br /><br />
    <asp:PlaceHolder runat="server" ID="ComboBox1Container" />  
    
    <asp:SqlDataSource ID="sds1" runat="server" SelectCommand="SELECT TOP 10 CustomerID, CompanyName FROM Customers"
	    ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Northwind.mdb;" ProviderName="System.Data.OleDb"></asp:SqlDataSource>
	
    <br /><br />
    
    <span class="tdText">
        By default, the ComboBox only allows existing items from the list to be selected by end users.<br />
        You can configure the ComboBox to allow custom text (that doesn't exist in the items list) <br />
        to be typed into the input field. This is done by setting the <b>AllowCustomText</b> property to <span class="option2">true</span>.
    </span>
</asp:Content>

