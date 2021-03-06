﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Obout.ListBox;

public partial class ListBox_cs_settings_postback : System.Web.UI.Page
{
    private Obout.ListBox.ListBox ListBox1;

    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1 = new Obout.ListBox.ListBox();
        ListBox1.ID = "ListBox1";
        ListBox1.Width = Unit.Pixel(300);
        ListBox1.Height = Unit.Pixel(200);
        ListBox1.AutoPostBack = true;
        ListBox1.DataSourceID = "sds1";
        ListBox1.DataTextField = "CompanyName";
        ListBox1.DataValueField = "CustomerID";

        ListBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

        ListBox1Container.Controls.Add(ListBox1);
       
    }

    protected void ListBox1_SelectedIndexChanged(object sender, ListBoxItemEventArgs e)
    {
        Details.Text = "<br /><br /><br /><b>" + e.Item.Text + "</b> has been selected.<br />";
    }
}
