using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    //inheritance
    class UserValidationManager : IUserValidationService 
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.NationalityNumber == "33355544422" && gamer.FirstName == "Selim" && gamer.LastName == "Kazancı" && gamer.DateBirth == 14 - 01 - 1998)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
