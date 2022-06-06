using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;

namespace taman.io.Repository
{
    public class UserRepository
    {
        public static TamanEntities db = DatabaseSingleton.Connections();
        public static void RegisterUser(string name, string email, string password, string phone, string address, string image)
        {
            db.users.Add(UserFactory.Create(name, email, password, phone, address, image));
            db.SaveChanges();
        }
        public static user IsValidCredential(string email, string password)
        {
            return db.users.
                Where(x => x.email == email && x.password == password).
                FirstOrDefault();
        }
    }
}