using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderApp
{
    public class Order : IComparable<Order>
    {
        private readonly List<OrderDetail> details = new List<OrderDetail>();
        
        public int id { get; set; }
        public Customers Customer { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        public float Price
        {
            get => details.Sum(d => d.Total);
        }
        public Order() {CreateTime = DateTime.Now; }
        public Order(int orderid, Customers customer, DateTime creatTime)
        {
            id = orderid;
            Customer = customer;
            CreateTime = creatTime;
        }

        public List<OrderDetail> Details => details;
        public void AddDetails(OrderDetail orderDetail) 
        {
            if(details.Contains(orderDetail) )
            {
                throw new ApplicationException($"The products ({orderDetail.product.Name}) exist in order {id}");
            }
            details.Add(orderDetail);
        }
        public void RemoveDetails(int nums)
        {
            Details.RemoveAt(nums);
        }

        public int CompareTo(Order other) 
        {
            return (other == null) ? 1 : (int)(id - other.id);
        }
        
        public override bool Equals(object? obj)
        {
            var order = obj as Order;
            return (order != null && id == order.id);
        }
        public override string ToString() 
        {
            StringBuilder result = new StringBuilder();
            result.Append($"orderId:{id}, customer:({Customer})");
            details.ForEach(detail => result.Append("\n\t" + detail));
            return result.ToString();
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}