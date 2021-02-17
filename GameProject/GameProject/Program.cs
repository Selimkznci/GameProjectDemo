using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Registration(new Gamer { NationalityNumber = "33355544422", FirstName = "Selim", LastName = "Kazancı", DateBirth = 14-01-1998});

            GamerManager gamerManager2 = new GamerManager(new NewLisValidationManager());
            gamerManager2.Registration(new Gamer { NationalityNumber = "33355544422", FirstName = "Selim", LastName = "Kazancı", DateBirth = 14 - 01 - 1998 });

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(new Gamer { NationalityNumber = "33355544422", FirstName = "Selim", LastName = "Kazancı", DateBirth = 14 - 01 - 1998 });

            CampaigneManager campaigneManager = new CampaigneManager();
            campaigneManager.CampaingneEnter();
            campaigneManager.CampaingneUpdate();
            campaigneManager.NewCampaingneEnter();
        }
    }
}
