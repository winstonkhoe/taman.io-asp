using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class ArtistFactory
    {
        public static artist Create(string name, int reputation_point, int user_id, string image)
        {
            return new artist
            {
                name = name,
                reputation_point = reputation_point,
                user_id = user_id,
                image = image,
                created_at = DateTime.Now
            };
        }
    }
}