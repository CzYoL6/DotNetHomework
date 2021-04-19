using System;
using System.Collections.Generic;

namespace _20210402homework {
    class Program {
        static void Main(string[] args) {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Product apple = new Product(1, "apple", 10.0f);
            Product egg = new Product(2, "egg", 1.2f);
            Product milk = new Product(3, "milk", 50f);

            Order order1 = new Order(1, customer1);
            order1.addOrderDetail(new OrderDetail(apple, 80));
            order1.addOrderDetail(new OrderDetail(egg, 200));
            order1.addOrderDetail(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.addOrderDetail(new OrderDetail(egg, 200));
            order2.addOrderDetail(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2);
            order3.addOrderDetail(new OrderDetail(apple, 80));
            order3.addOrderDetail(new OrderDetail(milk, 10));

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            List<Order> orders;

            Console.WriteLine("\nGetOrdersById:1");
            orders = orderService.QueryOrderByID(1);
            orders.ForEach(o => Console.WriteLine(o));


            Console.WriteLine("\nGetAllOrders");
            orders = orderService.QueryAll();
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersByCustomerName:'Customer2'");
            orders = orderService.QueryOrderByCustomerName("Customer2");
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersByGoodsName:'eggs'");
            orders = orderService.QueryOrderByProductName("eggs");
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersTotalAmount:1000");
            orders = orderService.QueryOrderByCost(OrderService.EQUAL, 1000);
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nRemove order(id=2) and qurey all");
           // orderService.DelOrder(2);
            orderService.QueryAll().ForEach(
                o => Console.WriteLine(o));

            Console.WriteLine("\n order by Amount");
            orderService.Sort(
              (o1, o2) => o2.Cost.CompareTo(o1.Cost));
            orderService.QueryAll().ForEach(
                o => Console.WriteLine(o));
        }
    }
}
