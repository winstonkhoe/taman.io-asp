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
    public class TransactionController
    {
        public static transaction_headers CreateTransactionHeader(int userId)
        {
            return TransactionHandler.CreateTransactionHeader(userId);
        }

        public static transaction_detail_gardens CreateTransactionDetailGarden(int transactionId, int gardenId, int quantity)
        {
            return TransactionHandler.CreateTransactionDetailGarden(transactionId, gardenId, quantity);
        }

        public static transaction_detail_services CreateTransactionDetailService(int transactionId, int serviceId, int quantity)
        {
            return TransactionHandler.CreateTransactionDetailService(transactionId, serviceId, quantity);
        }

        public static List<transaction_headers> GetTransactionHeaders(int userId)
        {
            return TransactionHandler.GetTransactionHeaders(userId);
        }

        public static List<transaction_detail_gardens> GetTransactionDetailGardens(int transactionId)
        {
            return TransactionHandler.GetTransactionDetailGardens(transactionId);
        }

        public static List<transaction_detail_services> GetTransactionDetailService(int transactionId)
        {
            return TransactionHandler.GetTransactionDetailService(transactionId);
        }
    }
}