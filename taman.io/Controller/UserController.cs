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
        public static string RegisterUser(string name, string email, string password, string confirmPassword, string phone, string address, string image)
        {
            string error = null;
            if (name == "" || password == "" || email == "" || phone == "" || address == "")
            {
                error = "Fields cannot be empty!";
            } else if (!password.Equals(confirmPassword))
            {
                error = "Password didn't match!";
            } else if (address.Length < 3)
            {
                error = "Address must be longer than 3 character!";
            }

            if(error == null)
            {
                UserHandler.RegisterUser(name, email, password, phone, address, image);
            } 
            return error;
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