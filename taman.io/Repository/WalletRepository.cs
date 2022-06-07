using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class WalletRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static void CreateWallet(int user_id, int balance)
        {
            db.wallets.Add(WalletFactory.Create(user_id, balance));
            db.SaveChanges();
        }
    }
}