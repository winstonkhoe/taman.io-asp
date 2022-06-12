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
    public partial class Transactions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/User/Login.aspx");
            } else
            {
                user user = (user)Session["user"];
                RepeaterTransaction.DataSource = TransactionController.GetTransactionHeaders(user.id);
                RepeaterTransaction.DataBind();
            }
        }

        protected string GetTransactionType(transaction_headers header)
        {
            if (header.transaction_detail_gardens.FirstOrDefault() != null) return "Garden";
            return "Service";
        }

        protected garden_offers GetContractor(transaction_headers header)
        {
            return header.transaction_detail_gardens.FirstOrDefault().garden_offers;
        }
        protected bool IsGarden(transaction_headers header)
        {
            return header.transaction_detail_gardens.FirstOrDefault() != null;
        }
        protected bool IsService(transaction_headers header)
        {
            return header.transaction_detail_services.FirstOrDefault() != null;
        }

        protected string GetTransactionDate(DateTime date)
        {
            string format = "d MMM yyyy";
            return date.ToString(format);
        }

    }
}