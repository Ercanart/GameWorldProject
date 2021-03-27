using GameWorldProject.CheckServiceTools;
using GameWorldProject.MethodClasses;
using GameWorldProject.PropertyClasses;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
            customer.FirstName.ToUpper(),
            customer.LastName.ToLower(),
            customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
