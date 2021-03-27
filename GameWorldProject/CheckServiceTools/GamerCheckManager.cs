using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.CheckServiceTools
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Customer customer)
        {
            return true;
        }
    }
}
