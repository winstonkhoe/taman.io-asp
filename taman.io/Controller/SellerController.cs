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
    public class SellerController
    {
        public static seller CreateSeller(string name, string phone, string city, string address, int reputation_point, int user_id, string image)
        {
            return SellerHandler.CreateSeller(name, phone, city, address, reputation_point, user_id, image);
        }

        public static seller GetSeller(int sellerId)
        {
            return SellerHandler.GetSeller(sellerId);
        }

    }
}