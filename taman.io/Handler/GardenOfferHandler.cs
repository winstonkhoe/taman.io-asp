using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class GardenOfferHandler
    {
        public static garden_offers CreateService(int design_id, int seller_id, int price, string phone, string address, string image)
        {
            return GardenOfferRepository.CreateService(design_id, seller_id, price, phone, address, image);
        }

        public static List<garden_offers> GetGardenOffers(int designId)
        {
            return GardenOfferRepository.GetGardenOffers(designId);
        }
    }
}