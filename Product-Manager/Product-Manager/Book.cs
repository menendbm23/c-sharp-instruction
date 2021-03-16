using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Manager {
    class Book : Product {
        public String Author { get; set; }
        
        public Book() { }
        
        public Book(string code, string description, double price, string author): 
            base(code, description, price) {
            
            Author = author;
        }

        public override string ToString() {
            return base.ToString() + $"Book: {Author}";
        }

    }
}
