﻿using KpopZtationFrontEnd.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationFrontEnd.View
{
    public partial class Register : System.Web.UI.Page
    {
        private AuthenticationController authenticationController = AuthenticationController.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string name = TextBoxUsername.Text;
            string email = TextBoxEmail.Text;
            string gender = RadioButtonListGender.SelectedValue;
            string address = TextBoxAddress.Text;
            string password = TextBoxPassword.Text;

            try
            {
                authenticationController.Register(name, email, gender, address, password);
            }
            catch (Exception ex)
            {
                LabelResult.Text = ex.Message;
                return;
            }

            Response.Redirect("Login.aspx");
        }
    }
}