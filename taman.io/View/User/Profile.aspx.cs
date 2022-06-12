using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using taman.io.Controller;
using taman.io.Model;

namespace taman.io.View.User
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user user = (user)Session["user"];
            if (user == null)
            {
                Response.Redirect("~/View/User/Login.aspx");
            } else if(!IsPostBack)
            {
                FieldName.Text = user.name;
                FieldEmail.Text = user.email;
                FieldPhone.Text = user.phone;
                FieldAddress.Text = user.address;
            }
            ImageProfile.ImageUrl = UserController.GetProfileImage(user);
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = FieldName.Text.Trim();
            string email = FieldEmail.Text.Trim();
            string phone = FieldPhone.Text.Trim();
            string address = FieldAddress.Text.Trim();
            string filename = ((user)Session["user"]).image;
            if (FileProfile.HasFile)
            {
                string extension = System.IO.Path.GetExtension(FileProfile.FileName);
                if(extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".gif")
                {
                    LabelError.Text = "Invalid Image Type";
                    LabelError.Visible = true;
                } else
                {
                    filename = DateTime.Now.Ticks + extension;
                    FileProfile.SaveAs(Server.MapPath(@"~\Image\" + filename));
                }
            }

            //FIX ME: Fields ga keubah ketika kita ganti value

            string error = UserController.UpdateProfile(((user)Session["user"]).email, name, email, phone, address, filename);
            if(error != null)
            {
                LabelError.Text = error;
                LabelError.Visible = true;
            } else
            {
                user user = (user)Session["user"];
                user.name = name;
                user.email = email;
                user.phone = phone;
                user.address = address;
                user.image = filename;

                Session["user"] = user;
                Response.Redirect("~/View/Home.aspx");
            }
        }
    }
}