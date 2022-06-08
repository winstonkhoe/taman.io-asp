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
    public class DesignController
    {
        public static design CreateDesign(int artist_id, string name, string description, int price)
        {
            return DesignHandler.CreateDesign(artist_id, name, description, price);
        }
        public static design_images CreateDesignImage(int design_id, string filename)
        {
            return DesignHandler.CreateDesignImage(design_id, filename);
        }
        public static List<design> GetDesigns()
        {
            return DesignHandler.GetDesigns();
        }
        public static List<design> GetDesigns(int artistId)
        {
            return DesignHandler.GetDesigns(artistId);
        }
        public static List<design_images> GetImages(int designId)
        {
            return DesignHandler.GetImages(designId);
        }
    }
}