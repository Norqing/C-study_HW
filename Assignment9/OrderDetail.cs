using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Models
{

    public class OrderDetail
    {

        public string Id { get; set; }

        public int Index { get; set; } //序号

        public string? ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Products? ProductItem { get; set; }

        public String? ProductsName { get => ProductItem != null ? this.ProductItem.Name : ""; }

        public double? UnitPrice { get => ProductItem != null ? this.ProductItem.Price : 0.0; }

        public string? OrderId { get; set; }

        public int Quantity { get; set; }

        public OrderDetail()
        {
            Id = Guid.NewGuid().ToString();
        }

        public OrderDetail(int index, Products products, int quantity)
        {
            this.Index = index;
            this.ProductItem = products;
            this.Quantity = quantity;
        }

        public double TotalPrice
        {
            get => ProductItem == null ? 0.0 : ProductItem.Price * Quantity;
        }

        public override string ToString()
        {
            return $"[No.:{Index},goods:{ProductsName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderDetail;
            return item != null &&
                   ProductsName == item.ProductsName;
        }

        public override int GetHashCode()
        {
            var hashCode = -11451419;
            hashCode = hashCode * -1738612379 + Index.GetHashCode();
            hashCode = hashCode * -1738612379 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1738612379 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
