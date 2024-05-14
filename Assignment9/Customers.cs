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
        public string id { get; set; }
        public string phone {  get; set; }
        public Customers() 
        {
            id = Guid.NewGuid().ToString();
            phone = Guid.NewGuid().ToString();
        }
        public Customers(string name, string address):this()
        {
            Name = name;
            Address = address;
        }


        public override bool Equals(object obj)
        {
            var customer = obj as Customers;
            return customer != null &&
                   id == customer.id &&
                   Name == customer.Name&&
                   phone == customer.phone;
        }

        

        public override int GetHashCode()
        {
            var hashCode = 11451419;
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(phone);
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(Address);
            return hashCode;
        }
    }

}
