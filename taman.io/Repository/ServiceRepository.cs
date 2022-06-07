using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class ServiceRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static service CreateService(string name, string description, int estimation_day, int price, int seller_id)
        {
            service data = db.services.Add(ServiceFactory.Create(name, description, estimation_day, price, seller_id));
            db.SaveChanges();
            return data;
        }

        public static service_images CreateServiceImage(int service_id, string filename)
        {
            service_images data = db.service_images.Add(ServiceFactory.CreateImage(service_id, filename));
            db.SaveChanges();
            return data;
        }

        public static List<service> GetServices()
        {
            return db.services.ToList();
        }

        public static List<service> GetServices(int sellerId)
        {
            return db.services.Where(x => x.seller_id == sellerId).ToList();
        }

        public static List<service_images> GetImages(int serviceId)
        {
            return db.service_images.Where(x => x.service_id == serviceId).ToList();
        }
    }
}