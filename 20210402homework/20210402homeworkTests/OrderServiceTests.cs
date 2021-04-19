using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20210402homework;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace _20210402homework.Tests {
    [TestClass()]
    public class OrderServiceTests {
        /* [TestMethod()]
         public void OrderServiceTest() {
             Assert.Fail();
         }*/
        OrderService orderService = new OrderService();

        Product apple = new Product(1, "apple", 10.0f);
        Product egg = new Product(2, "egg", 1.2f);
        Product milk = new Product(3, "milk", 50f);
        Customer customer1 = new Customer(1, "Customer1");
        Customer customer2 = new Customer(2, "Customer2");

        [TestInitialize]
        public void Init() {

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

            orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
        }
        [TestMethod()]
        public void AddOrderTest() {
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

            List<Order> result = new List<Order>();
            result.Add(order1);
            result.Add(order2);
            result.Add(order3);
            CollectionAssert.AreEqual(result, orderService.orderList);
        }

        [TestMethod()]
        public void UpdateTest() {
            Order order1 = new Order(1, customer1);
            order1.addOrderDetail(new OrderDetail(apple, 8000));
            order1.addOrderDetail(new OrderDetail(egg, 20000));
            order1.addOrderDetail(new OrderDetail(milk, 1000));
            orderService.Update(order1);

            Order number1 = orderService.QueryOrderByID(1)[0];
            Assert.AreEqual(order1, number1);
        }

        [TestMethod()]
        public void DelOrderTest() {
            orderService.DelOrder(1);

            Order order2 = new Order(2, customer2);
            order2.addOrderDetail(new OrderDetail(egg, 200));
            order2.addOrderDetail(new OrderDetail(milk, 10));
            Order order3 = new Order(3, customer2);
            order3.addOrderDetail(new OrderDetail(apple, 80));
            order3.addOrderDetail(new OrderDetail(milk, 10));
            List<Order> result = new List<Order>();
            result.Add(order2);
            result.Add(order3);

            CollectionAssert.AreEqual(result, orderService.orderList);
        }

        [TestMethod()]
        public void QueryOrderByCustomerNameTest() {
            List<Order> cusOrders = orderService.QueryOrderByCustomerName("Customer1");
            Order order1 = new Order(1, customer1);
            order1.addOrderDetail(new OrderDetail(apple, 80));
            order1.addOrderDetail(new OrderDetail(egg, 200));
            order1.addOrderDetail(new OrderDetail(milk, 10));

            List<Order> result = new List<Order>();
            result.Add(order1);
            CollectionAssert.AreEqual(result, cusOrders);
        }

        [TestMethod()]
        public void QueryOrderByProductNameTest() {
            List<Order> proOrders = orderService.QueryOrderByProductName("milk");
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

            List<Order> result = new List<Order>();
            result.Add(order1);
            result.Add(order2);
            result.Add(order3);
            CollectionAssert.AreEqual(result, proOrders);
        }

        [TestMethod()]
        public void QueryAllTest() {
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

            List<Order> result = new List<Order>();
            result.Add(order1);
            result.Add(order2);
            result.Add(order3);
            CollectionAssert.AreEqual(result, orderService.QueryAll());
        }

        [TestMethod()]
        public void QueryOrderByIDTest() {
            List<Order> idOrder = orderService.QueryOrderByID(1);
            Order order1 = new Order(1, customer1);
            order1.addOrderDetail(new OrderDetail(apple, 80));
            order1.addOrderDetail(new OrderDetail(egg, 200));
            order1.addOrderDetail(new OrderDetail(milk, 10));

            List<Order> result = new List<Order>();
            result.Add(order1);
            
            CollectionAssert.AreEqual(result, idOrder);
        }

        [TestMethod()]
        public void QueryOrderByCostTest() {
            List<Order> costOrder = orderService.QueryOrderByCost(OrderService.EQUAL,1300.0);
            Order order3 = new Order(3, customer2);
            order3.addOrderDetail(new OrderDetail(apple, 80));
            order3.addOrderDetail(new OrderDetail(milk, 10));

            List<Order> result = new List<Order>();
            result.Add(order3);

            CollectionAssert.AreEqual(result, costOrder);
        }

        [TestMethod()]
        public void SortTest() {
            orderService.Sort((o1, o2) => o1.Cost.CompareTo(o2.Cost));
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

            List<Order> result = new List<Order>();
            result.Add(order2);
            result.Add(order3);
            result.Add(order1);
            CollectionAssert.AreEqual(result, orderService.orderList);
        }

        [TestMethod()]
        public void ExportTest() {
            string file = "temp.xml";
            orderService.Export(file);
            Assert.IsTrue(File.Exists(file));

            string result = File.ReadAllText(file);
            string expect = File.ReadAllText(@"..\..\..\expectedOrders.xml");
            Assert.AreEqual(expect, result);

            File.Delete(file); //Clear up
        }

        [TestMethod()]
        public void ImportTest() {
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

            List<Order> result = new List<Order>();
            result.Add(order1);
            result.Add(order2);
            result.Add(order3);

            orderService.Import(@"..\..\..\newOrders.xml");

            CollectionAssert.AreEqual(result, orderService.orderList);
        }
    }
}