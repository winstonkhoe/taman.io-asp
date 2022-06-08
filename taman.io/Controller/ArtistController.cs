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
    public class ArtistController
    {
        public static string CreateArtist(string name, int reputation_point, int user_id, string image)
        {
            string error = null;
            if(name.Length < 3)
            {
                error = "Name must be more than 3 character";
            }
            if(error == null)
            {
                ArtistHandler.CreateArtist(name, reputation_point, user_id, image);
            }
            return error;
        }
        public static artist GetArtist(int artistId)
        {
            return ArtistHandler.GetArtist(artistId);
        }
    }
}