using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using taman.io.Controller;
using taman.io.Model;

namespace taman.io.View.User
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = FieldEmail.Text.Trim();
            string password = FieldPassword.Text.Trim();

            user user = UserController.IsValidCredential(email, password);
            if (user != null)
            {
                Session["user"] = user;
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                LabelError.Text = "Invalid Credentials!";
                LabelError.Visible = true;
            }
        }
    }
}