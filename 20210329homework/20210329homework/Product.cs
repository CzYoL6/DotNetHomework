using System;
using System.Collections.Generic;
using System.Text;

namespace _20210329homework {
    class Product {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int iD, string name, double price) {
            ID = iD;
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj) {
            return obj is Product product &&
                   ID == product.ID ;
        }

        public override int GetHashCode() {
            return 2108858624 + ID.GetHashCode();
        }

        public override string ToString() {
            return $"Id:{ID}, Name:{Name}, Value:{Price}";
        }
    }
}
