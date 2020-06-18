using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Forms
{
    class Customers
    {
        string name;
        int age;
        bool serveStat = false;

        public Customers(string customerName, int customerAge) {
            name = customerName;
            age = customerAge;
        }

        public string GetName() {
            return name;
        }

        public int GetAge() {
            return age;
        }

        public void Serve(bool served) {
            serveStat = served;
        }

        public bool AlreadyServed() {
            return serveStat;
        }
    }
}
