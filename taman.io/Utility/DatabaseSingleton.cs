using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Repository
{
    public class DatabaseSingleton
    {
        public static TamanEntities db;

        public static TamanEntities Connections()
        {
            return (db == null) ? new TamanEntities() : db;
        }
    }
}