﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EnumerationFilter : System.Web.DynamicData.QueryableFilterUserControl {
    private const string NullValueString = "[null]";
    public override Control FilterControl {
        get {
            return DropDownList1;
        }
    }

    public void Page_Init(object sender, EventArgs e) {
        if (!Page.IsPostBack) {
            if (!Column.IsRequired) {
                DropDownList1.Items.Add(new ListItem("[Not Set]", NullValueString));
            }
            PopulateListControl(DropDownList1);
            // Set the initial value if there is one
            string initialValue = DefaultValue;
            if (!String.IsNullOrEmpty(initialValue)) {
                DropDownList1.SelectedValue = initialValue;
            }
        }
    }

    public override IQueryable GetQueryable(IQueryable source) {
        string selectedValue = DropDownList1.SelectedValue;
        if (String.IsNullOrEmpty(selectedValue)) {
            return source;
        }

        object value = selectedValue;
        if(selectedValue == NullValueString) { 
            value = null;
        }
        if(DefaultValues != null) {
            DefaultValues[Column.Name] = value;
        }
        return ApplyEqualityFilter(source, Column.Name, value);
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {
        OnFilterChanged();
    }

}
