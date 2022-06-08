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
    public class WalletController
    {
        public static void CreateWallet(int userId, int balance)
        {
            WalletHandler.CreateWallet(userId, balance);
        }
    }
}