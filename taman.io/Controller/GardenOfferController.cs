using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Handler;
using taman.io.Model;
using taman.io.Repository;

namespace taman.io.Controller
{
    public class GardenOfferController
    {
        public static garden_offers CreateOffer(int design_id, int seller_id, int price)
        {
            return GardenOfferHandler.CreateOffer(design_id, seller_id, price);
        }
        
        public static void RemoveOffer(int design_id, int seller_id)
        {
            GardenOfferHandler.RemoveOffer(design_id, seller_id);
        }

        public static List<garden_offers> GetGardenOffers(int designId)
        {
            return GardenOfferHandler.GetGardenOffers(designId);
        }
    }
}