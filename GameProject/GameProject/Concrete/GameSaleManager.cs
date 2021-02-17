using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Product Selled");
        }

        void IGameSaleService.Sale(IGamerService gamer)
        {
            Console.WriteLine("Product Selled");
        }
    }
}
