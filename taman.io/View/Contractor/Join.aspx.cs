using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using taman.io.Controller;
using taman.io.Model;

namespace taman.io.View.Contractor
{
    public partial class Join : System.Web.UI.Page
    {
        protected design design;
        protected seller seller;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/User/Login.aspx");
            }
            else if (Request.QueryString["id"] == null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                user user = (user)Session["user"];
                if(user.sellers.FirstOrDefault() == null)
                {
                    Response.Redirect("~/View/Home.aspx");
                } else
                {
                    seller = user.sellers.FirstOrDefault();
                    design = DesignController.GetDesign(Int32.Parse(Request.QueryString["id"]));
                    if (design == null)
                    {
                        Response.Redirect("~/View/Home.aspx");
                    }
                    else
                    {
                        LabelName.Text = design.name;
                        ImageDesign.ImageUrl = DesignController.GetImage(design.design_images.FirstOrDefault());
                    }
                }
            }
        }

        protected void ButtonJoin_Click(object sender, EventArgs e)
        {
            int price;
            if(Int32.TryParse(FieldPrice.Text, out price))
            {
                Debug.WriteLine(GardenOfferController.CreateOffer(design.id, seller.id, price));
                Response.Redirect("~/View/Home.aspx");
            } else
            {
                LabelError.Text = "Price is invalid!";
                LabelError.Visible = true;
            }
        }
    }
}