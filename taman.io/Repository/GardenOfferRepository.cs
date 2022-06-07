using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class GardenOfferRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static garden_offers CreateService(int design_id, int seller_id, int price, string phone, string address, string image)
        {
            garden_offers data = db.garden_offers.Add(GardenOfferFactory.Create(design_id, seller_id, price, phone, address, image));
            db.SaveChanges();
            return data;
        }

        public static List<garden_offers> GetGardenOffers(int designId)
        {
            return db.garden_offers.Where(x => x.design_id == designId).ToList();
        }
    }
}