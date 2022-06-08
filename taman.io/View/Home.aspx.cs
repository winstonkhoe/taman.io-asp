using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using taman.io.Model;
using taman.io.Repository;
using System.Data.Entity;
using taman.io.Controller;

namespace taman.io.View.Common
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<design> designs = DesignController.GetDesigns();
            designRpt.DataSource = designs;
            designRpt.DataBind();
        }

        protected string GetImage(dynamic design)
        {
            return ((HashSet<design_images>)design.design_images).FirstOrDefault().filename;
        } 
        protected List<garden_offers> GetOffers(dynamic offers)
        {
            HashSet<garden_offers> garden_Offers = offers;
            return garden_Offers.Where(s => s.valid_to == null).ToList();
        }
    }
}