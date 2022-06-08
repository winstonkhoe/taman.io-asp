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
        public static garden_offers CreateService(int design_id, int seller_id, int price, string phone, string address, string image)
        {
            return GardenOfferHandler.CreateService(design_id, seller_id, price, phone, address, image);
        }

        public static List<garden_offers> GetGardenOffers(int designId)
        {
            return GardenOfferHandler.GetGardenOffers(designId);
        }
    }
}