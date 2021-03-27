using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.CheckServiceTools

{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Customer customer);
        
    }
}
