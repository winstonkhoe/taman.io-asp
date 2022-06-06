using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class GardenOfferFactory
    {
        public static garden_offers Create(int design_id, int seller_id, int price, string phone, string address, string image)
        {
            return new garden_offers
            {
                design_id = design_id,
                seller_id = seller_id,
                price = price,
                valid_from = DateTime.Now,
                valid_to = null
            };
        }
    }
}