using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class TransactionFactory
    {
        public static transaction_headers Create(int user_id)
        {
            return new transaction_headers
            {
                user_id = user_id,
                created_at = DateTime.Now
            };
        }

        public static transaction_detail_services CreateDetailServices(int transaction_header_id, int service_id, int quantity)
        {
            return new transaction_detail_services
            {
                transaction_header_id = transaction_header_id,
                service_id = service_id,
                quantity = quantity
            };
        }

        public static transaction_detail_gardens CreateDetailGardens(int transaction_header_id, int garden_offer_id, int quantity)
        {
            return new transaction_detail_gardens
            {
                transaction_header_id = transaction_header_id,
                garden_offer_id = garden_offer_id,
                quantity = quantity
            };
        }
    }
}