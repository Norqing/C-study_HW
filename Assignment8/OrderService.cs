using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{

    public class OrderService
    {

        public OrderService()
        {
            using (var txt = new OrderContext())
            {
                if (txt.Products.Count() == 0)
                {
                    txt.Products.Add(new Products("GenShin", 100.0));
                    txt.Products.Add(new Products("Milk", 200.0));
                    txt.SaveChanges();
                }
                if (txt.Customers.Count() == 0)
                {
                    txt.Customers.Add(new Customer("Zheng"));
                    txt.Customers.Add(new Customer("Yan"));
                    txt.SaveChanges();
                }
            }
        }

        public List<Order> Orders
        {
            get
            {
                using (var txt = new OrderContext())
                {
                    return txt.Orders
                      .Include(o => o.Details.Select(d => d.GoodsItem))
                      .Include(o => o.Customer)
                      .ToList<Order>();
                }
            }
        }

        public Order GetOrder(string id)
        {
            using (var txt = new OrderContext())
            {
                return txt.Orders
                  .Include(o => o.Details.Select(d => d.GoodsItem))
                  .Include(o => o.Customer)
                  .SingleOrDefault(o => o.OrderId == id);
            }
        }

        public void AddOrder(Order order)
        {
            FixOrder(order);
            using (var txt = new OrderContext())
            {
                txt.Entry(order).State = EntityState.Added;
                txt.SaveChanges();
            }
        }

        public void RemoveOrder(string orderId)
        {
            using (var txt = new OrderContext())
            {
                var order = txt.Orders.Include("Details")
                  .SingleOrDefault(o => o.OrderId == orderId);
                if (order == null) return;
                txt.OrderDetails.RemoveRange(order.Details);
                txt.Orders.Remove(order);
                txt.SaveChanges();
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            using (var txt = new OrderContext())
            {
                return txt.Orders
                  .Include(o => o.Details.Select(d => d.GoodsItem))
                  .Include(o => o.Customer)
                  .Where(order => order.Details.Any(item => item.GoodsItem.Name == goodsName))
                  .ToList();
            }
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var txt = new OrderContext())
            {
                return txt.Orders
                  .Include(o => o.Details.Select(d => d.GoodsItem))
                  .Include(o => o.Customer)
                  .Where(order => order.Customer.Name == customerName)
                  .ToList();
            }
        }


        public object QueryByTotalAmount(float amout)
        {
            using (var txt = new OrderContext())
            {
                return txt.Orders
                  .Include(o => o.Details.Select(d => d.ProductsItem)) 
                  .Include("Customer")
                .Where(order => order.Details.Sum(d => d.Quantity * d.ProductsItem.Price) > amout)
                .ToList();
            }
        }

        public void UpdateOrder(Order newOrder)
        {
            RemoveOrder(newOrder.OrderId);
            AddOrder(newOrder);
        }

        private static void FixOrder(Order newOrder)
        {
            newOrder.CustomerId = newOrder.Customer.id;
            newOrder.Customer = null;
            newOrder.Details.ForEach(d => {
                d.ProductId = d.ProductsItem.id;
                d.ProductsItem = null;
            });
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (var txt = new OrderContext())
                {
                    List<Order> temp = (List<Order>)xs.Deserialize(fs);
                    temp.ForEach(order => {
                        if (txt.Orders.SingleOrDefault(o => o.OrderId == order.OrderId) == null)
                        {
                            FixOrder(order);
                            txt.Orders.Add(order);
                        }
                    });
                    txt.SaveChanges();
                }
            }
        }

    }
}
