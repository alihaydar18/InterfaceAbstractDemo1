using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TCKimlikNo { get; set; }
    }


}

