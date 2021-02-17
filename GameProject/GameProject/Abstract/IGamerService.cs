using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Registration(Gamer gamer);
        void Update(Gamer gamer);
        void DeRegistration(Gamer gamer);
    }
}
