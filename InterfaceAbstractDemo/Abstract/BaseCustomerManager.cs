using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual async Task SaveAsync(Customer customer)
        {
            Console.WriteLine("Person saved on db : " + customer.Ad);
        }
    }
}