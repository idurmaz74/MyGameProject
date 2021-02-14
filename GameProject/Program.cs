using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1,FirstName="Kübra",LastName="Kılıç",TcNo="22222222222",BirtOfYear=1997};
            ICustomerService customerService = new CustomerManager(new CustomerControlManagerAdapter());
            customerService.Add(customer);

            Campaign campaignWinter = new Campaign() { Discount = 20 };
            Campaign campaignBlackFriday = new Campaign() { Discount = 50 };
            Game game = new Game() { Name = "Lara Croft Tomb Raider", Platform = "PC", Price = 400, Type = "Action" };

            IGameSaleService gameSaleService = new GameSaleManager(new GameSaleCampaignManager(campaignBlackFriday));
            gameSaleService.Sale(customer,game);
        }
    }
}
