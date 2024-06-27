using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private readonly ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override async Task SaveAsync(Customer customer)
        {
            if (await _customerCheckService.CheckIfRealPersonAsync(customer))
            {
                await base.SaveAsync(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
