using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class DesignRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static design CreateDesign(int artist_id, string name, string description, int price)
        {
            design data = db.designs.Add(DesignFactory.Create(artist_id, name, description, price));
            db.SaveChanges();
            return data;
        }

        public static design_images CreateDesignImage(int design_id, string filename)
        {
            design_images data = db.design_images.Add(DesignFactory.CreateImage(design_id, filename));
            db.SaveChanges();
            return data;
        }

        public static design GetDesign(int designId)
        {
            return db.designs.Where(x => x.id == designId).FirstOrDefault();
        }
        
        public static List<design> GetDesigns()
        {
            return db.designs.ToList();
        }

        public static List<design> GetDesigns(int artistId)
        {
            return db.designs.Where(x => x.artist_id == artistId).ToList();
        }

        public static List<design_images> GetImages(int designId)
        {
            return db.design_images.Where(x => x.design_id == designId).ToList();
        }
    }
}