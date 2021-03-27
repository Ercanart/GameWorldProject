using GameWorldProject.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.İnterfaces
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
