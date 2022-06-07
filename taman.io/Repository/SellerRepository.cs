using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class SellerRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static seller CreateSeller(string name, string phone, string city, string address, int reputation_point, int user_id, string image)
        {
            seller data = db.sellers.Add(SellerFactory.Create(name, phone, city, address, reputation_point, user_id, image));
            db.SaveChanges();
            return data;
        }

        public static seller GetSeller(int sellerId)
        {
            return db.sellers.Where(x => x.id == sellerId).FirstOrDefault();
        }

    }
}