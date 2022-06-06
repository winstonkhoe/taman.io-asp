using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using taman.io.Model;

namespace taman.io.Factory
{
    public class UserFactory
    {
        public static user Create(string name, string email, string password,  string phone, string address, string image)
        {
            return new user
            {
                name = name,
                email = email,
                password = password,
                phone = phone,
                address = address,
                image = image
            };
        }
    }
}