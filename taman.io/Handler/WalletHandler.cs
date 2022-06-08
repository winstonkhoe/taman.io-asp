using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;
using taman.io.Repository;

namespace taman.io.Handler
{
    public class WalletHandler
    {
        public static void CreateWallet(int userId, int balance)
        {
            WalletRepository.CreateWallet(userId, balance);
        }
    }
}