using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{
    public class Customers
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int id { get; set; }
        public long phone {  get; set; }
        public Customers(string name, string address, int id,long  phonenums)
        {
            Name = name;
            Address = address;
            this.id = id;
            phone = phonenums;
        }


        public override string ToString() => $"顾客:{Name},地址:{Address}";

        public override bool Equals(object obj)
        {
            var customer = obj as Customers;
            return customer!= null && (Name == customer.Name && id == customer.id);
        }

        public override int GetHashCode()
        {
            return 11451419 + id.GetHashCode();
        }
    }

}
