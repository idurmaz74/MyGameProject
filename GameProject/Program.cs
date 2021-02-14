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
            Customer customer = new Customer { Id = 1, FirstName = "Bulut", LastName = "Çalışkan", TcNo = "12345678901", BirthOfYear = 2007 };
            ICustomerService customerService = new CustomerManager(new CustomerControlManagerAdapter());
            customerService.Add(customer);

            Campaign campaignWinter = new Campaign() { Discount = 25 };
            Campaign campaignBlackFriday = new Campaign() { Discount = 55 };
            Game game = new Game() { Name = "Halo 2", Platform = "PC", Price = 275, Type = "Action" };

            IGameSaleService gameSaleService = new GameSaleManager(new GameSaleCampaignManager(campaignWinter));
            gameSaleService.Sale(customer, game);
        }
    }
}
