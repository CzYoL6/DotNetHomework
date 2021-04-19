using System;
using System.Collections.Generic;
using System.Text;

namespace _20210402homework {
    [Serializable]
    public class Customer {
        public uint ID { get; set; }
        public string Name { get; set; }

        public Customer() {

        }

        public Customer(uint id, string name) {
            ID = id;
            Name = name;
        }

        public override string ToString() {
            return $"customer id:{ID}, customer name:{Name}";
        }

        public override bool Equals(object obj) {
            return obj is Customer customer &&
                   ID == customer.ID;
        }

        public override int GetHashCode() {
            return ID.GetHashCode() + 2108858624;
        }
    }
}
