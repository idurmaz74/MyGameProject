using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameSaleCampaignManager : IGameSaleCampaignService
    {
        Campaign _campaign;

        public GameSaleCampaignManager(Campaign campaign)
        {
            _campaign = campaign;
        }

        public decimal Discount()
        {
            return _campaign.Discount;
        }
    }
}
