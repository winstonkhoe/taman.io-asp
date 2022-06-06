using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class SellerFactory
    {
        public static seller Create(string name, string phone, string city, string address, int reputation_point, int user_id, string image)
        {
            return new seller
            {
                name = name,
                phone = phone,
                city = city,
                address = address,
                reputation_point = reputation_point,
                user_id = user_id,
                image = image
            };
        }
    }
}