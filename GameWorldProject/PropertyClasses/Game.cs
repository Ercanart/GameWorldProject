using GameWorldProject.İnterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.PropertyClasses
{
    class Game : ICustomerReservist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
