using System;
using System.Collections.Generic;
using System.Text;

namespace _20210402homework {
    [Serializable]
    public class OrderDetail {
        public Product TheProduct { get; set; }
        private int Quantity { get; set; }
        public double Amount {
            get => TheProduct.Price * Quantity;
        }
        public OrderDetail() { }

        public OrderDetail(Product theProduct, int quantity) {
            TheProduct = theProduct;
            Quantity = quantity;
        }

        public override bool Equals(object obj) {
            return obj is OrderDetail detail &&
                   EqualityComparer<Product>.Default.Equals(TheProduct, detail.TheProduct) ;
        }

        public override int GetHashCode() {
            return 785010553 + EqualityComparer<Product>.Default.GetHashCode(TheProduct);
        }
    }
}
