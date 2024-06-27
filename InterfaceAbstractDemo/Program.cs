using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;


namespace InterfaceAbstractDemo;
class Program
{
    static async Task Main(string[] args)
    {
        BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
        await customerManager.SaveAsync(new Customer
        {
            //DogumYili = dogumyılınız,
            //Ad = "adınız",
            //Soyad = "soyadınız",
            //TCKimlikNo = tcNo
            
        }); Console.ReadLine();
    }
}
