using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId+campaign.CampaignName+campaign.DiscountRate+"Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"kampanya kaldırıldı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası güncellendi");
        }
    }
}
