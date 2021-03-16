using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Manager {
    class Software : Product {

        public String Version { get; set; }

        public Software() { }

        public Software(string code, string description, double price, string version) :
            base(code, description, price) {

            this.Version = version;
        }

        public override string ToString() {
            return base.ToString() + $"Software: Version: {Version}";
        }
    }
}
