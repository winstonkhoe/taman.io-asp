using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class WalletFactory
    {
        public static wallet Create(int user_id, int balance, string phone, string address, string image)
        {
            return new wallet
            {
                user_id = user_id,
                balance = balance,
                created_at = DateTime.Now
            };
        }
    }
}