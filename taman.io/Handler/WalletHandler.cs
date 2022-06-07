using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class WalletHandler
    {
        public static void CreateWallet(int userId, int balance)
        {
            WalletRepository.CreateWallet(userId, balance);
        }
    }
}