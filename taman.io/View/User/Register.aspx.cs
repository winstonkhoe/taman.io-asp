using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taman.io.View.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = FieldName.Text.Trim();
            string password = FieldPassword.Text.Trim();
            string confirmPassword = FieldConfirmPassword.Text.Trim();
            string email = FieldEmail.Text.Trim();
            string phone = FieldPhone.Text.Trim();
            string address = FieldAddress.Text.Trim();
            if(name == "" || password == "" || email == "" || phone == "" || address == "")
            {
                LabelError.Text = "Fields cannot be empty!";
            } else if()
            {

            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string error = UserController.CreateMember(EmailTxt.Text,
                PasswordTxt.Text, NameTxt.Text, DOBTxt.Text,
                    (MaleRb.Checked || FemaleRb.Checked) ?
                    ((MaleRb.Checked) ? MaleRb.Text : FemaleRb.Text)
                    : null,
                PhoneTxt.Text, AddressTxt.Text);
            if (error == null)
            {
                Response.Redirect("~/View/Guest/Login.aspx");
            }
            else
            {
                ErrorLbl.Text = error;
                ErrorLbl.Visible = true;
            }
        }
    }
}