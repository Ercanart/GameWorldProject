using GameWorldProject.Adapters;
using GameWorldProject.MethodClasses;
using GameWorldProject.PropertyClasses;
using System;

namespace GameWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //MasterCustomerDirector masterCustomerDirector = new GamerCustomerManager(new MernisServiceAdapter());
            //masterCustomerDirector.Register(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108", ProductSelection ="God of War", Id = 1 });

            GamerCustomerManager gamerCustomerManager = new GamerCustomerManager(new MernisServiceAdapter());
            Customer customer = new Customer()
            {
                FirstName = "Engin",
                NationalityId = "28861499108",
                DateOfBirth = new DateTime(1985, 1, 6),
                LastName = "Demiroğ",
                Id = 1
            };
            Customer customer2 = new Customer()
            {
                FirstName = "Haldun",
                NationalityId = "346464678",
                DateOfBirth = new DateTime(1978, 07, 26),
                LastName = "Ankara",
                Id = 2
            };
            gamerCustomerManager.Register(customer);
            gamerCustomerManager.Delete(customer);
            gamerCustomerManager.Update(customer);
            

            Game game = new Game()
            {
                Id = 1,
                Name = "God of War",
                Description = "Müthiş oyun" +
                "Tanrılarla savaşıyor",
                Price = 400
            };
            Game game2 = new Game()
            {
                Id = 2,
                Name = "Age of Empires",
                Description = "Strateji oyunu" +
                "Savaş stratejisi",
                Price = 250
            };
            GameManager gameManager = new GameManager();

            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);
            gameManager.Add(game2);
            gameManager.Update(game2);
            gameManager.Delete(game2);

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Discount = 80,
                Name = "Fall Discount",
                CampaignEndTime = new DateTime(2021, 09, 26)
            };
            Campaign campaign2 = new Campaign()
            {
                Id = 1,
                Discount = 80,
                Name = "Winter Discount",
                CampaignEndTime = new DateTime(2021, 03, 26)
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign2);

            SaleManager salesManager = new SaleManager();
            salesManager.Sale(customer, game);
            salesManager.CampaignSale(customer, game, campaign);
            salesManager.Sale(customer, game2);
            salesManager.CampaignSale(customer, game2, campaign2);

        }
    }
}
