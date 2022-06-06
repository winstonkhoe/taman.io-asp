using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class DesignFactory
    {
        public static design Create(int artist_id, string name, string description, int price)
        {
            return new design
            {
                artist_id = artist_id,
                name = name,
                description = description,
                price = price,
                created_at = DateTime.Now
            };
        }

        public static design_images CreateImage(int design_id, string filename)
        {
            return new design_images
            {
                design_id = design_id,
                filename = filename,
                created_at = DateTime.Now
            };
        }
    }
}