using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Factory;
using taman.io.Model;
using taman.io.Repository;

namespace taman.io.Handler
{
    public class UserHandler
    {
        public static void RegisterUser(string name, string email, string password, string phone, string address, string image)
        {
            UserRepository.RegisterUser(name, email, password, phone, address, image);
        }
        public static user IsValidCredential(string email, string password)
        {
            return UserRepository.IsValidCredential(email, password);
        }
    }
}