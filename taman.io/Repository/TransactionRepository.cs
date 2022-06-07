using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class TransactionRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();

        public static transaction_headers CreateTransactionHeader(int userId)
        {
            transaction_headers data = db.transaction_headers.Add(TransactionFactory.Create(userId));
            db.SaveChanges();
            return data;
        }

        public static transaction_detail_gardens CreateTransactionDetailGarden(int transactionId, int gardenId, int quantity)
        {
            transaction_detail_gardens data = db.transaction_detail_gardens.Add(TransactionFactory.CreateDetailGardens(transactionId, gardenId, quantity));
            db.SaveChanges();
            return data;
        }

        public static transaction_detail_services CreateTransactionDetailService(int transactionId, int serviceId, int quantity)
        {
            transaction_detail_services data = db.transaction_detail_services.Add(TransactionFactory.CreateDetailServices(transactionId, serviceId, quantity));
            db.SaveChanges();
            return data;
        }

        public static List<transaction_headers> GetTransactionHeaders(int userId)
        {
            return db.transaction_headers.Where(x => x.user_id == userId).ToList();
        }

        public static List<transaction_detail_gardens> GetTransactionDetailGardens(int transactionId)
        {
            return db.transaction_detail_gardens.Where(x => x.transaction_header_id == transactionId).ToList();
        }

        public static List<transaction_detail_services> GetTransactionDetailService(int transactionId)
        {
            return db.transaction_detail_services.Where(x => x.transaction_header_id == transactionId).ToList();
        }
    }
}