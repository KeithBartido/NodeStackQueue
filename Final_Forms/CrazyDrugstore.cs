using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Forms
{

    class CrazyDrugstore
    {
        System.Windows.Forms.RichTextBox yrichie;
        System.Windows.Forms.RichTextBox orichie;
        System.Windows.Forms.RichTextBox dyr;
        System.Windows.Forms.RichTextBox dor;
        System.Windows.Forms.RichTextBox sb;
        List<Customers> cList = new List<Customers>();
        NodeQueue cQueue;
      //  NodeQueue yblood;
        PriorityQueue ogs;
        public CrazyDrugstore(System.Windows.Forms.RichTextBox nrtb, System.Windows.Forms.RichTextBox srtb, System.Windows.Forms.RichTextBox fullnrtb, System.Windows.Forms.RichTextBox fullsrtb, System.Windows.Forms.RichTextBox served) {
            cQueue = new NodeQueue();
            yrichie = nrtb;
            orichie = srtb;
            dyr = fullnrtb;
            dor = fullsrtb;
            sb = served;
        //    yblood = new NodeQueue();
            ogs = new PriorityQueue(srtb, fullsrtb);

        }

        public void EQCQ(string name, int age) {
            if (age >= 65) {
                ogs.Enqueue(FindCustomer(name));
                orichie.AppendText(name.ToUpper() + ", " + FindCustomer(name).GetAge() + " years old, is in the Priority Line. \n");
            }
            else {
                cQueue.Enqueue(FindCustomer(name));
                yrichie.AppendText(name.ToUpper() + ", " + FindCustomer(name).GetAge() + " years old, is now in line. \n");
            }
        }
    

        public Customers FindCustomer(string name) {
            foreach (var customer in cList) {
                if (customer.GetName() == name) {
                    return customer;
                }
            }
            return null;
        }
        public bool checkQueueOld(string name)
        {

            int sQueueS = ogs.Count(); //BIG BOSS //arrify
            Customers[] questomerSen = new Customers[sQueueS];
            if (sQueueS != 0)
            {
                for (int i = 0; i < sQueueS; i++)
                {
                    questomerSen[i] = (Customers)ogs.Dequeue();
                }
                for (int i = 0; i < sQueueS; i++)
                {
                    ogs.HeapHop(FindCustomer(questomerSen[i].GetName()));
                }
                for (int i = 0; i < sQueueS; i++)
                {
                    if (questomerSen[i].GetName() == name)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
            public bool checkQueueYoung(string name)
            {
            int cQueueC = cQueue.Count(); //BIG BOSS //arrify
            Customers[] questomer = new Customers[cQueueC];
            if (cQueueC != 0) {

                for (int i = 0; i < cQueueC; i++) {
                    questomer[i] = (Customers)cQueue.Dequeue();
                }
                for (int i = 0; i < cQueueC; i++) {
                    cQueue.Enqueue(FindCustomer(questomer[i].GetName()));
                }
                for (int i = 0; i < cQueueC; i++) {
                    if (questomer[i].GetName() == name) {
                        return true;
                    }
                }
            }
            return false;
        }

        public void LineUp (string name, int age)
        {
            if (FindCustomer(name) == null) {
                cList.Add(new Customers(name, age));
                EQCQ(name, age);
            }
            else {
               if(checkQueueYoung(name) == true) {
                   yrichie.AppendText("----------------------------------------------Sorry, name is already in our queue. Please input another name.\n");
               }
               else if (checkQueueOld(name) == true) { 
                    orichie.AppendText("----------------------------------------------Sorry, name is already in our queue. Please input another name.\n");
                }
                else {
                    EQCQ(name, age);
                }

            }
            
        }

        public void Display()
        {
            ogs.outputSeniorQueue();
            int cQueueC = cQueue.Count(); //BIG BOSS //arrify
            Customers[] questomer = new Customers[cQueueC];
            //dyr.AppendText("Current List: \n");
            if (cQueueC != 0)
            {
                for (int i = 0; i < cQueueC; i++)
                {
                    questomer[i] = (Customers)cQueue.Dequeue();
                }
                
                for (int i = 0; i < cQueueC; i++)
                {
                    cQueue.Enqueue(FindCustomer(questomer[i].GetName()));
                    dyr.AppendText(questomer[i].GetName() + "\n");
                }
            }
            dyr.AppendText("------------------------------- \n");
        }

        public void Serve() {
            if(ogs.Count() != 0) {
                Customers ogFront = (Customers)ogs.Peek();
                ogFront.Serve(true);
                dor.AppendText(ogFront.GetName() + " served\n");
                ogs.Dequeue();
            }
            else { 
                if (cQueue.Count() != 0) {
                    Customers ybFront = (Customers)cQueue.Peek();
                    ybFront.Serve(true);
                    dyr.AppendText(ybFront.GetName() + " served\n");
                    cQueue.Dequeue();
                }
                else {
                    dyr.AppendText("There is no one in line\n");
                    dor.AppendText("There is no one in line\n");
}
            }
        }
        public void DisplayServed() {
            foreach (var servee in cList) { 
                if (servee.AlreadyServed() == true) {
                    sb.AppendText(servee.GetName() + " has been served.\n");
                }
}
        }

        public void SortTheDouggie()
        {
            ogs.sortPriorityqueue();
        }

        public void Rotate() {

            ogs.Rotate();
            int normalLineSize = cQueue.Count();
            Customers[] normalLine = new Customers[normalLineSize];
            for (int i = 0; i < normalLineSize; i++) {
                normalLine[i] = (Customers)cQueue.Dequeue();
            }
            for (int i = normalLineSize - 1; i >= 0; i--) {
                cQueue.Enqueue(FindCustomer(normalLine[i].GetName()));
            }

        }

        public void Snap()
        {
            ogs.Clear(); cQueue.Clear(); cList.Clear();
        }
        public void EasyInputter() {
            LineUp("A", 16);
            LineUp("B", 8);
            LineUp("C", 31);
            LineUp("D", 1);
            LineUp("E", 400);
            LineUp("G", 700);
            LineUp("F", 800);
            LineUp("H", 300);
            LineUp("I", 200);
            LineUp("J", 600);
            LineUp("K", 500);
        }
    }
}
