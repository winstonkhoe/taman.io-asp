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
        
        public static user UpdateProfile(string previousEmail, string name, string email, string phone, string address, string image)
        {
            user user = db.users.
                Where(x => x.email == previousEmail).
                FirstOrDefault();
            if(user != null)
            {
                user.name = name;
                user.email = email;
                user.phone = phone;
                user.address = address;
                user.image = image;
                db.SaveChanges();
            }
            return user;
        }
        public static user IsValidCredential(string email, string password)
        {
            user user = db.users.
                Where(x => x.email == email).
                FirstOrDefault();

            if(user != null)
            {
                return IsSamePassword(password, user.password) == true ? user : null;
            }

            return null;
        }

        public static bool IsSamePassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}