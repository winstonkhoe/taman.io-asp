using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using taman.io.Controller;

namespace taman.io.View.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string name = FieldName.Text.Trim();
            string password = FieldPassword.Text.Trim();
            string confirmPassword = FieldConfirmPassword.Text.Trim();
            string email = FieldEmail.Text.Trim();
            string phone = FieldPhone.Text.Trim();
            string address = FieldAddress.Text.Trim();

            string error = UserController.RegisterUser(name, email, password, confirmPassword, phone, address, "");
            if (error == null)
            {
                Response.Redirect("~/View/User/Login.aspx");
            }
            else
            {
                LabelError.Text = error;
                LabelError.Visible = true;
            }
        }
    }
}