using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210329homework {
    class OrderService {
        public const int EQUAL = 1, LARGER_THAN = 1 << 1, SMALLER_THAN = 1 << 2;

        private static OrderService instance;
        public static OrderService Instance {
            get {
                if (instance == null) {
                    instance = new OrderService();
                }
                return instance;
            }
        }
        private List<Order> orderList;
        public OrderService() {
            orderList = new List<Order>();
        }

        public bool AddOrder(Order newOrder) {
            if (orderList.Contains(newOrder)) {
                return false;    
            }
            orderList.Add(newOrder);
            return true;
        }

        public void Update(Order order) {
            DelOrder(order.OrderId);
            orderList.Add(order);
        }

        public bool DelOrder(int orderId) {
            orderList.RemoveAll(o => o.OrderId == orderId);
            return true;
        }

        public List<Order> QueryOrderByCustomerName(string customerName) {
            var t = from n in orderList
                    where n.TheCustomer.Name == customerName
                    select n;
            return t.ToList();
        }

        public List<Order> QueryOrderByProductName(string productName) {
            var t = from n in orderList
                    where n.orderDetails.Any(d=>d.TheProduct.Name == productName)
                    select n;
            return t.ToList();
        }

        public List<Order> QueryAll() {
            return orderList;
        }

        public List<Order> QueryOrderByID(uint orderId) {
            var t = from n in orderList
                    where n.OrderId == orderId
                    select n;
            return t.ToList();
        }

        public List<Order> QueryOrderByCost(int queryType, int cost) {
            IEnumerable<Order> t;
            switch (queryType) {
                case EQUAL:
                    t = from n in orderList
                            where n.Cost == cost
                            select n;
                    return t.ToList();
                    break;
                case LARGER_THAN:
                    t = from n in orderList
                            where n.Cost > cost
                            select n;
                    return t.ToList();
                    break;
                case SMALLER_THAN:
                    t = from n in orderList
                        where n.Cost < cost
                        select n;
                    return t.ToList();
                    break;
                case EQUAL | LARGER_THAN:
                    t = from n in orderList
                        where n.Cost >= cost
                        select n;
                    return t.ToList();
                    break;
                case EQUAL | SMALLER_THAN:
                    t = from n in orderList
                        where n.Cost <= cost
                        select n;
                    return t.ToList();
                    break;
                default: return null;

            }

            
        }

        public void Sort(Comparison<Order> comparison) {
            orderList.Sort(comparison);
        }
    }
}
