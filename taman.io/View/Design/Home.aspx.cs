using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using taman.io.Controller;
using taman.io.Model;

namespace taman.io.View.Design
{
    public partial class Home : System.Web.UI.Page
    {
        protected design design;
        protected artist artist;
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
                design = DesignController.GetDesign(Int32.Parse(Request.QueryString["id"]));
                if(design == null)
                {
                    Response.Redirect("~/View/Home.aspx");
                } else
                {
                    LabelName.Text = design.name;
                    ImageDesign.ImageUrl = DesignController.GetImage(design.design_images.FirstOrDefault());
                    LabelDesignPrice.Text = design.price.ToString();
                    LabelConstructorPrice.Text = "-";
                    LabelTotalPrice.Text = "-";
                    LabelDescription.Text = design.description;
                    RepeaterContractors.DataSource = GetOffers(design.garden_offers);
                    RepeaterContractors.DataBind();

                    user user = (user)Session["user"];
                    artist = user.artists.FirstOrDefault();
                    seller = user.sellers.FirstOrDefault();   
                    if (artist != null && artist.id == design.artist_id)
                    {
                        PanelModifications.Visible = true;
                    }
                    if(seller != null)
                    {
                        bool isContractors = design.garden_offers.Where(x => x.seller_id == seller.id && x.valid_to == null).FirstOrDefault() == null ? false : true;
                        if(isContractors)
                        {
                            PanelContractorQuit.Visible = true;
                        } else
                        {
                            PanelContractorJoin.Visible = true;
                        }
                    }
                }
            }
        }
        protected List<garden_offers> GetOffers(dynamic offers)
        {
            HashSet<garden_offers> garden_Offers = offers;
            return garden_Offers.Where(s => s.valid_to == null).ToList();
        }

        protected string GetImage(dynamic seller)
        {
            return UserController.GetProfileImage(seller);
        }
        protected string GetTotal(int price)
        {
            int cost = design == null ? 0 : design.price;
            return (cost + price) + "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonJoin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Contractor/Join.aspx?id="+design.id);
        }

        protected void ButtonQuit_Click(object sender, EventArgs e)
        {
            GardenOfferController.RemoveOffer(design.id, seller.id);
            Response.Redirect(Request.RawUrl);
            Debug.WriteLine("Button Quit");
        }

        protected void ButtonBuilding_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                transaction_headers header = TransactionController.CreateTransactionHeader(((user)Session["user"]).id);
                TransactionController.CreateTransactionDetailGarden(header.id, design.id, 1);
                Response.Redirect("~/View/User/Transactions.aspx");
            }
        }
    }
}