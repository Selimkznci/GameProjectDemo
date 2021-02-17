using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer
    {
        public string NationalityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateBirth { get; set; }
        public string GamerNationalityNumber { get; internal set; }
    }
}
