using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Forms
{
    class NodeQueue
    {
        Node front = null;
        Node rear = null;
        int size = 0;

        public NodeQueue() {

        }
        public void Enqueue(object olement) {
            if (size == 0)
            {
                Node n = new Node(olement, front);
                front = n;
                rear = n;
                size++;
            }
            else {
                Node n = new Node(olement, null);
                rear.SetNext(n);
                rear = n;
                size++;
            }
        }
        public object Dequeue() {
            if (size > 1) {
                object temp = front.GetElement();
                front = front.GetNext();
                size--;
                return temp;
            }
            else if (size == 1) {
                
                object temp = front.GetElement();
                size--;
                front = null;
                rear = null;
                return temp;
            }
            else {
                return null;
            }
        }
        public int Count() {
            return size;
        }
        public object Peek() {
            return front.GetElement();
        }
        public void Clear() {
            front = null;
            rear = null;
            size = 0;
        }
    }
}
