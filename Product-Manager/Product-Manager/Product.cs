using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Manager {
    class Product {
        public String Code { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }

        public Product() {

        }

        public Product (String code, String description, double price) {
            this.Code = code;
            this.Description = description;
            this.Price = price;

        }

        public override string ToString() {
            return $"Product: {Code}, {Description}, {Price.ToString("C")}";
        }

    }
}
