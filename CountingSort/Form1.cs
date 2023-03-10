using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountingSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        

        private void button1_Click(object sender, EventArgs e)
        {

            int[] numbers = new int[6];
             //for kullanabilirsin
            numbers[0] = Convert.ToInt32(textBox1.Text);
            numbers[1] = Convert.ToInt32(textBox2.Text);
            numbers[2] = Convert.ToInt32(textBox3.Text);
            numbers[3] = Convert.ToInt32(textBox4.Text);
            numbers[4] = Convert.ToInt32(textBox5.Text);
            numbers[5] = Convert.ToInt32(textBox6.Text);

            if(textBox1.Text== null || textBox2.Text == null || textBox3.Text == null
               || textBox4.Text == null || textBox5.Text == null || textBox6.Text == null)
            {
                MessageBox.Show("Please enter value!");
            }


            int[] sortedArray = new int[6];

            //smallest and biggest number finder
            int minimum = numbers[0];
            int maximum = numbers[0];
            for (int i = 1; i < 6; i++)
            {
                if (numbers[i] < minimum) 
                    minimum = numbers[i];

                else if (numbers[i] > maximum)
                    maximum = numbers[i];
            }
            
            int[] counts = new int[maximum - minimum + 1];


            for (int i = 0; i < 6; i++)
            {
                counts[numbers[i] - minimum]++;
            }

            counts[0]--;

            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = 5; i >= 0; i--)
            {
                sortedArray[counts[numbers[i] - minimum]--] = numbers[i];
            }

            label4.Text = Convert.ToString(sortedArray[0]);
            label5.Text = Convert.ToString(sortedArray[1]);
            label6.Text = Convert.ToString(sortedArray[2]);
            label7.Text = Convert.ToString(sortedArray[3]);
            label8.Text = Convert.ToString(sortedArray[4]);
            label9.Text = Convert.ToString(sortedArray[5]);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;

        }
    }
}
