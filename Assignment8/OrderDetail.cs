using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{

    public class OrderDetail
    {

        public string Id { get; set; }
        public int Index { get; set; } //序号
        public string ProductId { get; set; }
        public Products ProductsItem { get; set; }
        public String ProductName { get => ProductsItem != null ? this.ProductsItem.Name : ""; }
        public double UnitPrice { get => ProductsItem != null ? this.ProductsItem.Price : 0.0; }
        public string OrderId { get; set; }
        public int Quantity { get; set; }


        public OrderDetail()
        {
            Id = Guid.NewGuid().ToString();
        }

        public OrderDetail(int index, Products product, int quantity)
        {
            this.Index = index;
            this.ProductsItem = product;
            this.Quantity = quantity;
        }

        public double TotalPrice
        {
            get => ProductsItem == null ? 0.0 : ProductsItem.Price * Quantity;
        }

        public override string ToString()
        {
            return $"[No.:{Index},goods:{ProductName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderDetail;
            return item != null &&
                  ProductName == item.ProductName;
        }

        public override int GetHashCode()
        {
            var hashCode = -11451419;
            hashCode = hashCode * -1738612379 + Index.GetHashCode();
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            hashCode = hashCode * -1738612379 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
