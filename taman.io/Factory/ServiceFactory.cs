using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class ServiceFactory
    {
        public static service Create(string name, string description, int estimation_day, int price, int seller_id)
        {
            return new service
            {
                name = name,
                description = description,
                estimation_day = estimation_day,
                price = price,
                seller_id = seller_id,
                created_at = DateTime.Now
            };
        }
        public static service_images CreateImage(int service_id, string filename)
        {
            return new service_images
            {
                service_id = service_id,
                filename = filename,
                created_at = DateTime.Now
            };
        }
    }
}