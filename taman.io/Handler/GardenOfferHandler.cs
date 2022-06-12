using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;
using taman.io.Repository;

namespace taman.io.Handler
{
    public class GardenOfferHandler
    {
        public static garden_offers CreateOffer(int design_id, int seller_id, int price)
        {
            return GardenOfferRepository.CreateOffer(design_id, seller_id, price);
        }

        public static void RemoveOffer(int design_id, int seller_id)
        {
            GardenOfferRepository.RemoveOffer(design_id, seller_id);
        }

        public static List<garden_offers> GetGardenOffers(int designId)
        {
            return GardenOfferRepository.GetGardenOffers(designId);
        }
    }
}