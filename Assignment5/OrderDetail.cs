using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class OrderDetail
    {
        public Products product { get; set; }
        public int Quantity { get; set; }
        
        public OrderDetail(Products products,int quantity) 
        {
            product = products;
            Quantity = quantity;
        }
        public float Total { get => product.Price * Quantity; }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&EqualityComparer<Products>.Default.Equals(product, detail.product);
        }

        public override string ToString()
        {
            return $"OrderDetail:{product},{Quantity}";
        }

        public override int GetHashCode()
        {
            return 1145141919 + EqualityComparer<Products>.Default.GetHashCode(product);
        }
    }
}
