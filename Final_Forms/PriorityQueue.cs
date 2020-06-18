using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Forms
{
    class PriorityQueue {
        System.Windows.Forms.RichTextBox oldbois;
        System.Windows.Forms.RichTextBox dob;
        private Customers[] lowprio = new Customers[28679454];
        private int heapsize;
        int queueSize = 0;
        private int counter = 0;

        public PriorityQueue(System.Windows.Forms.RichTextBox srtb, System.Windows.Forms.RichTextBox fullsrtb) {
            oldbois = srtb;
            dob = fullsrtb;
        }

        private Customers[] HeapSort(Customers[] arr, int size) {
            heapsize = size - 1;
            WatchMeHeap(arr, size);
            for (int i = arr.Length - 1; i >=0 ; i--) {
                Switcherooo(arr, 0, 1);
                heapsize--;
                MaxHeapify(arr, 0);
            }
            return arr;
        }
        public void WatchMeHeap(Customers[] bois, int n) { //builder
            heapsize = n - 1;
            for (int i = heapsize / 2; i >= 0; i--) {
                MaxHeapify(bois, i);
            }
        }

        private void Switcherooo(Customers[] arr, int x, int y)
        {
            Customers temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void MaxHeapify (Customers[] maxbois, int m) {
            if(counter % 2 == 0)
            {
                int max = m;
                int left = 2 * m + 1;
                int right = 2 * m;

                if (left <= heapsize && maxbois[left].GetAge() > maxbois[m].GetAge())
                {
                    max = left;
                }
                if (right <= heapsize && maxbois[right].GetAge() > maxbois[m].GetAge())
                {
                    max = right;
                }

                if (max != m)
                {
                    Switcherooo(maxbois, m, max);
                    MaxHeapify(maxbois, max);
                }
            }
            else
            {
                int max = m;
                int left = 2 * m + 1;
                int right = 2 * m;

                if (left <= heapsize && maxbois[left].GetAge() < maxbois[m].GetAge())
                {
                    max = left;
                }
                if (right <= heapsize && maxbois[right].GetAge() < maxbois[m].GetAge())
                {
                    max = right;
                }

                if (max != m)
                {
                    Switcherooo(maxbois, m, max);
                    MaxHeapify(maxbois, max);
                }
            }
        }

        public int Count() {
            return queueSize;
        }

        public void Enqueue(Customers boi) {
            lowprio[queueSize] = boi;
            queueSize++;
            WatchMeHeap(lowprio, queueSize);
        }

        public void HeapHop(Customers seniorBoi) { //used for rotation, so that it doesnt return the same sort all the time
            lowprio[queueSize] = seniorBoi;
            queueSize++;
        }

        public Customers Dequeue() {
            /*Customers boi;
            HeapSort(lowprio, size);
            boi = lowprio[size - 1];
            lowprio[size - 1] = null;
            size--;
            HeapSort(lowprio, size);
            return boi;*/
            Customers nextboi = lowprio[0];
            for (int i = 1; i < queueSize; i++) {
                lowprio[i - 1] = lowprio[i];
                if (i == queueSize - 1) {
                    lowprio[i] = null;
                }
            }
            queueSize--;
            WatchMeHeap(lowprio, queueSize);
            return nextboi;
        }

        public void sortPriorityqueue() {
            int prioQueueSize = Count();
            Customers[] prioQueueArrayified = new Customers[prioQueueSize];
            for (int i = 0; i < prioQueueSize; i++) {
                prioQueueArrayified[i] = (Customers)Dequeue();
            }

            HeapSort(prioQueueArrayified, prioQueueSize);

            for (int i = 0; i < prioQueueSize; i++) {
                HeapHop(prioQueueArrayified[i]);
            }
        }

        public void Rotate() {
            counter++;
            WatchMeHeap(lowprio, Count());
        }

         public void outputSeniorQueue() {
            //dob.AppendText("Current List: \n");
            for (int i = 0; i < queueSize; i++) {
                if (lowprio[i] != null) {
                    dob.AppendText(lowprio[i].GetName() + ", " + lowprio[i].GetAge() + " years old. \n");
                }
            }
            dob.AppendText("------------------------------- \n");
        }
        public Customers Peek() {
            if (queueSize != 0) {
                return lowprio[0];
            }
            return null;
        }

        public void Clear()
        {
            for(int i = 0; i<lowprio.Length; i++)
            {
                lowprio[i] = null;
            }
        }
    }
}
