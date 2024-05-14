using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp.Models
{
    public class Products
    {
        public string id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Products()
        {
            id = Guid.NewGuid().ToString();
        }

        public Products(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            var goods = obj as Products;
            return goods != null &&
                   id == goods.id &&
                   Name == goods.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 11451419;
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
