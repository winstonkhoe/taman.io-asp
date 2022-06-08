using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using taman.io.Controller;
using taman.io.Model;
using taman.io.Repository;

namespace taman.io.View.NewFolder1
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user user = Session["user"] == null ? null : (user)Session["user"];
            ImageUser.ImageUrl = UserController.GetProfileImage(user);
            if (user != null)
            {
                PanelGuest.Visible = false;
                LabelName.Text = user.name;
                artist artist = user.artists.FirstOrDefault();
                seller seller = user.sellers.FirstOrDefault();
                ImageArtist.ImageUrl = UserController.GetProfileImage(artist);
                ImageSeller.ImageUrl = UserController.GetProfileImage(seller);
                if (artist != null)
                {
                    LabelArtistName.Text = artist.name;
                    HyperlinkArtist.NavigateUrl = "~/Artist/Home.aspx";
                } else
                {
                    LabelArtistName.Text = "Register Artist";
                    HyperlinkArtist.NavigateUrl = "~/Artist/Register.aspx";
                }
                
                if (seller != null)
                {
                    LabelArtistName.Text = seller.name;
                    HyperlinkSeller.NavigateUrl = "~/Seller/Home.aspx";
                } else
                {
                    LabelSellerName.Text = "Register Seller";
                    HyperlinkSeller.NavigateUrl = "~/Seller/Register.aspx";
                }
            } else
            {
                PanelUserNavigations.Visible = PanelArtistSeller.Visible = false;
                LabelName.Text = "Guest";
            }
        }
    }
}