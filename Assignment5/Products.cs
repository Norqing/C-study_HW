using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{
    public class Products
    {
        public string Name { get; set; }
        public int id { get; set; }
        private float price { get; set; }
        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("价格必须不低于0元!");
                price = value;
                ;
            }
        }
        public Products(string name,int id ,float price) 
        {
           Name = name; 
           this.id = id;   
           Price = price;
        }

        public override bool Equals(object obj)
        {
            var products = obj as Products;
            return products != null && id == products.id;
        }
        public override string ToString() => $"商品:{Name},价格{Price}";
        public override int GetHashCode()
        {
            return 1145141919 + id.GetHashCode();
        }
    }
}
