﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void Sales(Game game, Gamer gamer);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
    }
}
