using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Forms
{
    public partial class Form1 : Form
    {
        CrazyDrugstore drugs;
        PriorityQueue seniors;
        Customers[] bois;
        int size;
        public Form1()
        {
            InitializeComponent();
            drugs = new CrazyDrugstore(nrtb, srtb, fullnrtb, fullsrtb, served);
            seniors = new PriorityQueue(srtb, fullsrtb);
            bois = new Customers[0];//(nameBox.Text, int.Parse(ageBox.Text));
            drugs.EasyInputter();   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int parseCheck = 0;
            string name = nameBox.Text;
            name = name.ToUpper();
            name = name.Replace(" ", "-");
            if (name == string.Empty || ageBox.Text == string.Empty)
            {
                MessageBox.Show("Invalid Values, please try again ");
                return;
            }
            else if (!int.TryParse(ageBox.Text, out parseCheck)) {
                MessageBox.Show("Please input an integer on the age box");
                return;
            }
            else 
            {
                int age = int.Parse(ageBox.Text);
                drugs.LineUp(name, age);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dq_Click(object sender, EventArgs e)
        {
            drugs.Display();
            //seniors.outputSeniorQueue();
        }

        private void ssq_Click(object sender, EventArgs e)
        {
            drugs.SortTheDouggie();
        }

        private void serve_Click(object sender, EventArgs e)
        {
            try
            {
                drugs.Serve();
            }

            catch {
                MessageBox.Show("Invalid Values, please try again ");
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye bitch");
            this.Close();
        }

        private void ds_Click(object sender, EventArgs e)
        {
            drugs.DisplayServed();
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            try
            {
                drugs.Rotate();
            }
            catch
            {
                MessageBox.Show("Invalid Values, please try again ");
                return;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            drugs.Snap();
        }
    }
}
