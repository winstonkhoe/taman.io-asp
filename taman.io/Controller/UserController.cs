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
    public class UserController
    {
        public static void RegisterUser(string name, string email, string password, string phone, string address, string image)
        {
            UserHandler.RegisterUser(name, email, password, phone, address, image);
        }
        public static user IsValidCredential(string email, string password)
        {
            return UserHandler.IsValidCredential(email, password);
        }

        public static string GetProfileImage(dynamic profile)
        {
            if (profile == null || profile.image == "") return "~/Image/DefaultProfile.jpg";
            return "~/Image/" + profile.image;
        }
    }
}