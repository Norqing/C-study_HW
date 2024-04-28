using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{

    class Maintry
    {
        public static void Main()
        {
            try
            {
                //客户信息录入
                Customers customer1 = new Customers("张三","翻斗花园",1,17386123795);
                Customers customer2 = new Customers( "李四","信息学部",2,18902296418);
                //产品信息录入
                Products product1= new Products("GenShen", 1,648.00f);
                Products product2 = new Products( "yuanmeng&star",2, 168.88f);
                Products product3 = new Products("Nagger",3, 9.10f);
                Products product4 = new Products("Apple", 4, 5.59f);
                //购买数量的新增
                OrderService orderService = new OrderService();
                Order order1 = new Order(1, customer1, new DateTime(2024, 3, 31));
                order1.AddDetails(new OrderDetail(product1, 10));
                order1.AddDetails(new OrderDetail(product2, 9));
                orderService.AddOrder(order1);
                //新增2
                Order order2 = new Order(2, customer2, new DateTime(2024, 3, 31));
                order2.AddDetails(new OrderDetail(product3, 24));
                order2.AddDetails(new OrderDetail(product4, 40));
                orderService.AddOrder(order2);
                //根据id查询订单
                Console.WriteLine("\n Search Order");
                Console.WriteLine("with id:\n");
                Console.WriteLine(orderService.Searchwithid(1));
                Console.WriteLine(orderService.Searchwithid(999));
                //查全部
                Console.WriteLine("\n All: \n");
                List<Order> orders = orderService.SearchAll();
                orders.ForEach(o => Console.WriteLine(o));
                //根据客户的名字查询
                Console.WriteLine("\n with Custom Name: \n");
                orders = orderService.SearchwithCN("Customer1");
                orders.ForEach(o => Console.WriteLine(o));
                //根据客户的电话查询
                Console.WriteLine("\n with PhoneNum: \n");
                orders = orderService.SearchwithPN("Nagger");
                orders.ForEach(o => Console.WriteLine(o));
                //根据订单的金额查询
                Console.WriteLine("\nwith Total Price\n");
                orders = orderService.SearchwithTP(1000);
                orders.ForEach(o => Console.WriteLine(o));      
                //根据金额的一定条件进行查询
                Console.WriteLine("\nSearch with price\n");
                var query = orderService.Query(o => o.Price > 8848);
                foreach (Order order in query)
                {
                    Console.WriteLine(order);
                }
                //删除订单并检查是否成功删除
                Console.WriteLine("\nRemove order (id=1) and check\n");
                orderService.RemoveOrder(1);
                orderService.SearchAll().ForEach(o => Console.WriteLine(o));
                //按顺序对订单进行排序
                Console.WriteLine("\n order by Amount");
                orderService.Sort((o1, o2) => o2.Price.CompareTo(o1.Price));
                orderService.SearchAll().ForEach(o => Console.WriteLine(o));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
