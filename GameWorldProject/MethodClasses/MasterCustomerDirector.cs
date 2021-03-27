using GameWorldProject.İnterfaces;
using GameWorldProject.MethodClasses;
using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.MethodClasses
{
    public abstract class MasterCustomerDirector : ICustomerMaker
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted : " + customer.FirstName);
        }

        public virtual void Register(Customer customer)
        {
            Console.WriteLine("Customer recorded : " + customer.DateOfBirth);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated : " + customer.ProductSelection);
        }


    }
}
