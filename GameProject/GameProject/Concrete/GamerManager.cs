using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;


namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void DeRegistration(Gamer gamer)
        {
            Console.WriteLine("Record Deleted.");
        }

        public void Registration(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Record successful.");
            }
            else
            {
                Console.WriteLine("Verification Failed.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Record Updated");
        }
    }
}

