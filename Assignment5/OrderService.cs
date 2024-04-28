using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{
    public class OrderService
    {
        private readonly List<Order> orders = new List<Order>();    
        
        public void AddOrder(Order order) 
        {   
            if (orders.Contains(order)) { throw new ApplicationException($"the order {order.id} already exists!"); }
            orders.Add(order); 
        }
        public void Update(Order order)
        { 
            if (orders.Contains(order)) {  orders.Remove(order); } 
            int index = orders.FindIndex(o=> o.id == order.id);
            if (index < 0) { throw new ApplicationException($"the order {order.id} Wrong!"); }
            orders.RemoveAt(index);
            orders.Add(order);
        }  
        public void RemoveOrder(int orderid) 
        { 
            int index = orders.FindIndex(o=> o.id == orderid);
            if(index >= 0) 
            {
                orders.RemoveAt(index);
            } 
             orders.RemoveAll(o=> o.id == orderid);
        }

        public Order Searchwithid(int orderid) 
        {
            return orders.FirstOrDefault(o=> o.id == orderid);
        }
        public List<Order> SearchwithPN(string productname)
        {
            var search = orders.Where(
             o => o.Details.Where(d => d.product.Name == productname).Count() > 0)
               .OrderBy(o => o.Price);
            return search.ToList();
        }
        public List<Order> SearchwithCN(string customerName)
        {
            var search = orders
                .Where(o => o.Customer.Name == customerName)
                .OrderBy(o => o.Price);
            return search.ToList();
        }
        public List<Order> SearchwithCP(long customerPhone)
        {
            var search = orders
                .Where(o => o.Customer.phone == customerPhone)
                .OrderBy(o => o.Price);
            return search.ToList();
        }
        public List<Order> SearchwithTP(float totalprice)
        {
            var search = orders.Where(o => o.Price >= totalprice)
                .OrderBy(o => o.Price);
            return search.ToList();
        }
        public List<Order> SearchAll() 
        {
            return orders;
        }

        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }

        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orders.Where(o => condition(o)).OrderBy(o => o.Price);
        }

    }
}
