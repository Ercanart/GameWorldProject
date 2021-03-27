using GameWorldProject.CheckServiceTools;
using GameWorldProject.MethodClasses;
using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.MethodClasses
{
    public class GamerCustomerManager : MasterCustomerDirector
    {
        private IGamerCheckService _gamerCheckService;

        public GamerCustomerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }


        public override void Register(Customer customer)
        {
            if (_gamerCheckService.CheckIfRealGamer(customer))
            {
                base.Register(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
