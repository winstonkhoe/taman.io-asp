using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class ArtistRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static artist CreateArtist(string name, int reputation_point, int user_id, string image)
        {
            artist data = db.artists.Add(ArtistFactory.Create(name, reputation_point, user_id, image));
            db.SaveChanges();
            return data;
        }

        public static artist GetArtist(int artistId)
        {
            return db.artists.Where(x => x.id == artistId).FirstOrDefault();
        }

    }
}