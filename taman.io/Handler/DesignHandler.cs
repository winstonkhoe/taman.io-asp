using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class DesignHandler
    {
        public static design CreateDesign(int artist_id, string name, string description, int price)
        {
            return DesignRepository.CreateDesign(artist_id, name, description, price);
        }
        public static design_images CreateDesignImage(int design_id, string filename)
        {
            return DesignRepository.CreateDesignImage(design_id, filename);
        }
        public static List<design> GetDesigns()
        {
            return DesignRepository.GetDesigns();
        }
        public static List<design> GetDesigns(int artistId)
        {
            return DesignRepository.GetDesigns(artistId);
        }
        public static List<design_images> GetImages(int designId)
        {
            return DesignRepository.GetImages(designId);
        }
    }
}