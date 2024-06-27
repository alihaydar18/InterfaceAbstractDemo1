using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPersonAsync(Customer customer)
        {
            using (var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
            {
                var result = await client.TCKimlikNoDogrulaAsync(
                    customer.TCKimlikNo,
                    customer.Ad.ToUpper(),
                    customer.Soyad.ToUpper(),
                    customer.DogumYili
                );
                return result.Body.TCKimlikNoDogrulaResult;
            }
        }
    }
}
