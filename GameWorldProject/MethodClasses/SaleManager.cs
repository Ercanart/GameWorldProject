using GameWorldProject.İnterfaces;
using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.MethodClasses
{
    class SaleManager : ISaleService
    {
        int discountedPrice;
        public void CampaignSale(Customer customer, Game game, Campaign campaign)
        {
            discountedPrice = game.Price - ((game.Price * campaign.Discount) / 100);
            Console.WriteLine(customer.FirstName + " adlı kullanıcı " + campaign.Name
                + " adli kampanyadan yararlanarak " + game.Name + " adlı oyunu yüzde "
                + campaign.Discount + " indirimle " + discountedPrice + " fiyata almıştır.");

        }

        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı "
                + game.Name + " adlı oyunu " + game.Price + " fiyatıyla satın almıştır. ");
        }

        
    }
}
