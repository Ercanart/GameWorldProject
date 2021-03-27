using GameWorldProject.İnterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.PropertyClass
{
    class Campaign: ICustomerReservist
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public string Name { get; set; }

        public DateTime CampaignEndTime { get; set; }
    }
}
