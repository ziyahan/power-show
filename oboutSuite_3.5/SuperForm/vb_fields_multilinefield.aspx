﻿<%@ Page Title="" Language="VB" MasterPageFile="~/SuperForm/SuperForm.master" AutoEventWireup="true" CodeFile="vb_fields_multilinefield.aspx.vb" Inherits="SuperForm_vb_fields_multilinefield" %>
<%@ Register TagPrefix="obout" Namespace="Obout.SuperForm" Assembly="obout_SuperForm" %>
<%@ Register TagPrefix="obout" Namespace="OboutInc.Calendar2" Assembly="obout_Calendar2_NET" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    
    <span class="tdText"><b>ASP.NET Super Form - MultiLineField</b></span>
    
    <br /><br />
    <asp:PlaceHolder runat="server" ID="SuperForm1Container" /> 
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
        ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" 
        SelectCommand="SELECT OrderID, ShipName, AdditionalInformation, AdditionalInformationHTML FROM [Orders]"
        UpdateCommand="UPDATE Orders SET ShipName=@ShipName, AdditionalInformation=@AdditionalInformation, AdditionalInformationHTML=@AdditionalInformationHTML
                         WHERE OrderID=@OrderID"
        InsertCommand="INSERT INTO Orders(ShipName, AdditionalInformation, AdditionalInformationHTML) VALUES(@ShipName, @AdditionalInformation, @AdditionalInformationHTML)" 
        DeleteCommand="DELETE FROM Orders WHERE OrderID = @OrderID" />
    
    <br /><br />
    
    <span class="tdText">
        Add <b>MultiLineField</b> objects to the <b>Fields</b> collection to manually specify the fields that will be editable using a multi line text box.<br />
        This type of field will render an OboutTextBox control in add/edit mode, which will allow end users to modify the underlying data.<br />
        The OboutTextBox control will be configured to work in multi line mode.<br /><br />

        The <b>MultiLineField</b> class exposes some important properties:<br />
        <ul>
            <li><b>DataField</b> - gets or sets the name of the data field to bind to the MultiLineField object.</li>
            <li><b>HeaderText</b> - gets or sets the text that is displayed as the label of the field.</li>
            <li><b>ReadOnly</b> - gets or sets a value indicating whether the field is editable in add/edit mode.</li>
        </ul>
        
        The <b>AutoGenerateRows</b> property of the Super Form needs to be set to <span class="option2">false</span> when manually defining the fields.
    </span>
</asp:Content>

