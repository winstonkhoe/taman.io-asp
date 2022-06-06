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
    }
}