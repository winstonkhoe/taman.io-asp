using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;
using taman.io.Repository;

namespace taman.io.Handler
{
    public class TransactionHandler
    {
        public static transaction_headers CreateTransactionHeader(int userId)
        {
            return TransactionRepository.CreateTransactionHeader(userId);
        }

        public static transaction_detail_gardens CreateTransactionDetailGarden(int transactionId, int gardenId, int quantity)
        {
            return TransactionRepository.CreateTransactionDetailGarden(transactionId, gardenId, quantity);
        }

        public static transaction_detail_services CreateTransactionDetailService(int transactionId, int serviceId, int quantity)
        {
            return TransactionRepository.CreateTransactionDetailService(transactionId, serviceId, quantity);
        }

        public static List<transaction_headers> GetTransactionHeaders(int userId)
        {
            return TransactionRepository.GetTransactionHeaders(userId);
        }

        public static List<transaction_detail_gardens> GetTransactionDetailGardens(int transactionId)
        {
            return TransactionRepository.GetTransactionDetailGardens(transactionId);
        }

        public static List<transaction_detail_services> GetTransactionDetailService(int transactionId)
        {
            return TransactionRepository.GetTransactionDetailService(transactionId);
        }
    }
}