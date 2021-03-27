using GameWorldProject.MethodClasses;
using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.İnterfaces
{
    public interface ICustomerMaker
    {
        public void Register(Customer customer);
        public void Delete(Customer customer);
        public void Update(Customer customer);
    }
}
