﻿using System;
using System.Web.Security;

public partial class login : System.Web.UI.Page
{
    Chandan_Banjara_WorldEntities EF = new Chandan_Banjara_WorldEntities();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtPWD.Text == EF.tbl_Account.Find(txtUID.Text).acc_Password)
                FormsAuthentication.RedirectFromLoginPage(txtUID.Text, false);
            else
                lblError.Text = "Wrong Credentials";
        }
        catch (Exception ex)
        {
            lblError.Text = "Below Jham Happen <br/><br/>" + ex.Message;
        }
    }
}