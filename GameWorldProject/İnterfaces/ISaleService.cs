using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.İnterfaces
{
    interface ISaleService
    {
        void Sale(Customer customer, Game game);   //Satış
        void CampaignSale(Customer customer, Game game, Campaign campaign); //İndirimli Satış
    }
}
