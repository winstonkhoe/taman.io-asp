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
    public class ServiceController
    {
        public static service CreateService(string name, string description, int estimation_day, int price, int seller_id)
        {
            return ServiceHandler.CreateService(name, description, estimation_day, price, seller_id);
        }
        public static service_images CreateServiceImage(int service_id, string filename)
        {
            return ServiceHandler.CreateServiceImage(service_id, filename);
        }
        public static List<service> GetServices()
        {
            return ServiceHandler.GetServices();
        }
        public static List<service> GetServices(int sellerId)
        {
            return ServiceHandler.GetServices(sellerId);
        }
        public static List<service_images> GetImages(int serviceId)
        {
            return ServiceHandler.GetImages(serviceId);
        }
    }
}