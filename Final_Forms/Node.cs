using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Forms
{
    class Node
    {
        private object element;
        private Node next;

        public Node(object e, Node n) {
            element = e;
            next = n;
        }
        public object GetElement() {
            return element;
        }
        public Node GetNext() {
            return next;
        }
      /* public void SetElement(Customers element) {
            this.element = element;
        }*/
        public void SetNext(Node newNext) {
            next = newNext;
        }
    }
}
