using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace taman.io.Factory
{
    public class UserFactory
    {
        public static user CreateEmployee(string email, string password, string name, DateTime dob, string gender, string phone, string address, int salary)
        {
            return new user
            {
                EmployeeAddress = address,
                EmployeeDOB = dob,
                EmployeeEmail = email,
                EmployeeGender = gender,
                EmployeeName = name,
                EmployeePassword = password,
                EmployeePhone = phone,
                EmployeeSalary = salary
            };

        }
    }
}