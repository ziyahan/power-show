﻿Imports Obout.SuperForm
Imports System.Data
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Web.UI.WebControls
Imports Obout.Interface
Partial Class SuperForm_vb_fields_templatefield
    Inherits System.Web.UI.Page
    Dim SuperForm1 As Obout.SuperForm.SuperForm
    Sub Page_load(ByVal sender As Object, ByVal e As EventArgs)
        SuperForm1 = New SuperForm()
        SuperForm1.ID = "SuperForm1"
        SuperForm1.Title = "Order Details"
        SuperForm1.DataSourceID = "SqlDataSource1"
        SuperForm1.AutoGenerateRows = False
        SuperForm1.AutoGenerateInsertButton = True
        SuperForm1.AutoGenerateEditButton = True
        SuperForm1.AutoGenerateDeleteButton = True
        SuperForm1.AutoGenerateDateFields = True
        Dim keyNames1() As String = {"OrderID"}
        SuperForm1.DataKeyNames = keyNames1
        SuperForm1.AllowPaging = True
        SuperForm1.DefaultMode = DetailsViewMode.Edit

        AddHandler SuperForm1.ItemUpdating, AddressOf SuperForm1_ItemUpdating
        AddHandler SuperForm1.ItemInserting, AddressOf SuperForm1_ItemInserting

        Dim field1 As Obout.SuperForm.BoundField = New Obout.SuperForm.BoundField()
        field1.DataField = "OrderID"
        field1.HeaderText = "Order ID"
        field1.ReadOnly = True
        field1.InsertVisible = False

        Dim field2 As Obout.SuperForm.BoundField = New Obout.SuperForm.BoundField()
        field2.DataField = "ShipName"
        field2.HeaderText = "Ship Name"

        Dim field3 As Obout.SuperForm.BoundField = New Obout.SuperForm.BoundField()
        field3.DataField = "ShipCity"
        field3.HeaderText = "Ship City"

        Dim field4 As Obout.SuperForm.BoundField = New Obout.SuperForm.BoundField()
        field4.DataField = "ShipRegion"
        field4.HeaderText = "Ship Region"

        Dim field5 As Obout.SuperForm.TemplateField = New Obout.SuperForm.TemplateField()
        field5.HeaderText = "Ship Country"
        field5.ItemTemplate = New ShipCountryItemTemplate()
        field5.EditItemTemplate = New ShipCountryEditItemTemplate()

        Dim field6 As Obout.SuperForm.TemplateField = New Obout.SuperForm.TemplateField()
        field6.HeaderText = "Sent"
        field6.ItemTemplate = New SentItemTemplate()
        field6.EditItemTemplate = New SentEditItemTemplate()

        SuperForm1.Fields.Add(field1)
        SuperForm1.Fields.Add(field2)
        SuperForm1.Fields.Add(field3)
        SuperForm1.Fields.Add(field4)
        SuperForm1.Fields.Add(field5)
        SuperForm1.Fields.Add(field6)

        SuperForm1Container.Controls.Add(SuperForm1)
    End Sub

    Sub SuperForm1_ItemUpdating(ByVal sender As Object, ByVal e As DetailsViewUpdateEventArgs)
        e.NewValues("ShipCountry") = CType(CType(SuperForm1.Rows(4), DetailsViewRow).FindControl("ShipCountry"), Obout.ListBox.ListBox).SelectedValue
        e.NewValues("Sent") = CType(CType(SuperForm1.Rows(5), DetailsViewRow).FindControl("OboutRadioButton1"), OboutRadioButton).Checked
    End Sub

    Sub SuperForm1_ItemInserting(ByVal sender As Object, ByVal e As DetailsViewInsertEventArgs)
        e.Values("ShipCountry") = CType(CType(SuperForm1.Rows(4), DetailsViewRow).FindControl("ShipCountry"), Obout.ListBox.ListBox).SelectedValue
        e.Values("Sent") = CType(CType(SuperForm1.Rows(5), DetailsViewRow).FindControl("OboutRadioButton1"), OboutRadioButton).Checked
    End Sub

    Public Class ShipCountryItemTemplate
        Implements ITemplate

        Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn

            Dim templatePlaceHolder As Literal = New Literal()
            container.Controls.Add(templatePlaceHolder)

            AddHandler templatePlaceHolder.DataBinding, AddressOf DataBindTemplate
        End Sub

        Sub DataBindTemplate(ByVal sender As Object, ByVal e As EventArgs)

            Dim templatePlaceHolder As Literal = CType(sender, Literal)
            Dim row As DetailsViewRow = CType(templatePlaceHolder.Parent.Parent, DetailsViewRow)
            Dim form As SuperForm = CType(row.Parent.Parent, SuperForm)

            templatePlaceHolder.Text = DataBinder.Eval(Form.DataItem, "ShipCountry").ToString()
        End Sub
    End Class

    Public Class ShipCountryEditItemTemplate
        Implements ITemplate
       Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
            Dim templatePlaceHolder As PlaceHolder = New PlaceHolder()
            container.Controls.Add(templatePlaceHolder)

            Dim ListBox As Obout.ListBox.ListBox = New Obout.ListBox.ListBox()
            templatePlaceHolder.Controls.Add(ListBox)

            ListBox.ID = "ShipCountry"
            ListBox.DataSourceID = "SqlDataSource2"
            ListBox.Height = Unit.Pixel(150)
            ListBox.DataValueField = "ShipCountry"
            ListBox.DataTextField = "ShipCountry"

            AddHandler templatePlaceHolder.DataBinding, AddressOf DataBindTemplate
        End Sub

        Sub DataBindTemplate(ByVal sender As Object, ByVal e As EventArgs)

            Dim templatePlaceHolder As PlaceHolder = CType(sender, PlaceHolder)
            Dim row As DetailsViewRow = CType(templatePlaceHolder.Parent.Parent, DetailsViewRow)
            Dim form As SuperForm = CType(row.Parent.Parent, SuperForm)

            Dim listBox As Obout.ListBox.ListBox = CType(templatePlaceHolder.Controls(0), Obout.ListBox.ListBox)

            ListBox.SelectedValue = DataBinder.Eval(Form.DataItem, "ShipCountry").ToString()
        End Sub
    End Class

    Public Class SentItemTemplate
        Implements ITemplate
        Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn

            Dim templatePlaceHolder As Literal = New Literal()
            container.Controls.Add(templatePlaceHolder)

            AddHandler templatePlaceHolder.DataBinding, AddressOf DataBindTemplate
        End Sub

        Sub DataBindTemplate(ByVal sender As Object, ByVal e As EventArgs)
            Dim templatePlaceHolder As Literal = CType(sender, Literal)
            Dim row As DetailsViewRow = CType(templatePlaceHolder.Parent.Parent, DetailsViewRow)
            Dim form As SuperForm = CType(row.Parent.Parent, SuperForm)

            Dim value As String = DataBinder.Eval(form.DataItem, "Sent").ToString()
            If value = "True" Then
                templatePlaceHolder.Text = "Yes"
            Else
                templatePlaceHolder.Text = "No"
            End If

        End Sub
    End Class

    Public Class SentEditItemTemplate
        Implements ITemplate
        Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn

            Dim templatePlaceHolder As PlaceHolder = New PlaceHolder()
            container.Controls.Add(templatePlaceHolder)

            Dim OboutRadioButton1 As OboutRadioButton = New OboutRadioButton()
            templatePlaceHolder.Controls.Add(OboutRadioButton1)
            OboutRadioButton1.ID = "OboutRadioButton1"
            OboutRadioButton1.GroupName = "Sent"
            OboutRadioButton1.Text = "Yes"

            Dim OboutRadioButton2 As OboutRadioButton = New OboutRadioButton()
            templatePlaceHolder.Controls.Add(OboutRadioButton2)
            OboutRadioButton2.ID = "OboutRadioButton2"
            OboutRadioButton2.GroupName = "Sent"
            OboutRadioButton2.Text = "No"

            AddHandler templatePlaceHolder.DataBinding, AddressOf DataBindTemplate
        End Sub

        Sub DataBindTemplate(ByVal sender As Object, ByVal e As EventArgs)

            Dim templatePlaceHolder As PlaceHolder = CType(sender, PlaceHolder)
            Dim row As DetailsViewRow = CType(templatePlaceHolder.Parent.Parent, DetailsViewRow)
            Dim Form As SuperForm = CType(row.Parent.Parent, SuperForm)

            Dim OboutRadioButton1 As OboutRadioButton = CType(templatePlaceHolder.Controls(0), OboutRadioButton)
            Dim OboutRadioButton2 As OboutRadioButton = CType(templatePlaceHolder.Controls(1), OboutRadioButton)

            Dim value As Object = DataBinder.Eval(Form.DataItem, "Sent")
            If value.ToString() And value <> Nothing Then
                OboutRadioButton1.Checked = "True"
            ElseIf value.ToString() Or value = Nothing Then

                OboutRadioButton2.Checked = "False"
            End If
          
        End Sub
    End Class
End Class
