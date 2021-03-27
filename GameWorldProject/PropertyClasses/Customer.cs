using GameWorldProject.İnterfaces;
using GameWorldProject.MethodClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.PropertyClasses
{
    public class Customer:ICustomerReservist
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
        public string ProductSelection { get; set; }
    }
}
