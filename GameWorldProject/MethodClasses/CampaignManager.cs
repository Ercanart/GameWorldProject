using GameWorldProject.İnterfaces;
using GameWorldProject.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.MethodClasses
{
    class CampaignManager : ICampignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Adlı kampanya yüzde " + campaign.Discount
                + " indirimle " + campaign.CampaignEndTime + " tarihine kadar geçerlidir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Adlı kampanya silinmistir. ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Adlı kampanya yüzde " + campaign.Discount + "TL indirimle "
                + campaign.CampaignEndTime + " tarihine kadar uzatılıp, güncellenmiştir.");
        }
    }

    
}
