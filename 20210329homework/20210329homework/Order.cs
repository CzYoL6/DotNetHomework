using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210329homework {
    class Order : IComparable<Order> {
        public int OrderId { get; set; }
        
        public Customer TheCustomer { get; private set; }
        public double Cost { get => orderDetails.Sum(d => d.Amount); }

        public List<OrderDetail> orderDetails;
        public Order(int orderId, Customer customer)  {
            OrderId = orderId;
            TheCustomer = customer;
            orderDetails = new List<OrderDetail>();
        }


        public int CompareTo(Order other) {
            if (other == null) return 1;
            return OrderId - other.OrderId;
        }

        public override int GetHashCode() {
            return HashCode.Combine(OrderId, TheCustomer, Cost, orderDetails);
        }

        public bool addOrderDetail(OrderDetail orderDetail) {
            /*var t = from n in orderDetails
                    where n == orderDetail
                    select n;
            if (t != null) return false; */
            if (orderDetails.Contains(orderDetail)) {
                return false;    
            }
            orderDetails.Add(orderDetail);
            return true;
        }

        public override string ToString() {
            return "orderID:" + OrderId + 
                ",customer:" + TheCustomer.ToString() +
                ",total cost:" + Cost;
        }

        public override bool Equals(object obj) {
            return obj is Order order &&
                   OrderId == order.OrderId;
        }
    }
}
