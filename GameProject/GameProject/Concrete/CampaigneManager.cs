using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaigneManager : ICampaigneService
    {
        public void CampaingneEnter()
        {
            Console.WriteLine("New Campaign created.");
        }

        public void CampaingneUpdate()
        {
            Console.WriteLine("Campaign Updated.");
        }

        public void NewCampaingneEnter()
        {
            Console.WriteLine("Campaign Deleted.");
        }
    }
}
