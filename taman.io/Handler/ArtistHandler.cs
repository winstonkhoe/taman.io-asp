using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;
using taman.io.Repository;

namespace taman.io.Handler
{
    public class ArtistHandler
    {
        public static artist CreateArtist(string name, int reputation_point, int user_id, string image)
        {
            return ArtistRepository.CreateArtist(name, reputation_point, user_id, image);
        }
        public static artist GetArtist(int artistId)
        {
            return ArtistRepository.GetArtist(artistId);
        }
    }
}