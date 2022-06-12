using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class GardenOfferRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static garden_offers CreateOffer(int design_id, int seller_id, int price)
        {
            garden_offers data = db.garden_offers.Add(GardenOfferFactory.Create(design_id, seller_id, price));
            db.SaveChanges();
            return data;
        }
        public static void RemoveOffer(int design_id, int seller_id)
        {
            garden_offers data = db.garden_offers.Where(x => x.design_id == design_id && x.seller_id == seller_id && x.valid_to == null).FirstOrDefault();
            if(data != null)
            {
                data.valid_to = DateTime.Now;
                db.SaveChanges();
            }
        }

        public static List<garden_offers> GetGardenOffers(int designId)
        {
            return db.garden_offers.Where(x => x.design_id == designId).ToList();
        }
    }
}