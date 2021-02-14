using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        IGameSaleCampaignService _gameSaleCampaignService;

        public GameSaleManager(IGameSaleCampaignService gameSaleCampaignService)
        {
            _gameSaleCampaignService = gameSaleCampaignService;
        }

        public void Sale(Customer customer, Game game)
        {
            decimal amount = game.Price - (game.Price * (_gameSaleCampaignService.Discount() / 100));

            Console.WriteLine("Game:{0} price: {1} was saled to: {2} Amount ={3}",
                game.Name, game.Price, customer.FirstName, amount);
        }
    }
}
