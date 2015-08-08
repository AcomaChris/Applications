using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2_Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;

            int count = 0;
            count++;
            count--;

            string result = "hello";
            result += " again " + result;
            //MessageBox.Show(result);
            result = "the value is: " + count;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;

            for (int i = 0; i < 16; i = i + 2)
            {
                int normalInt = i / 2;
                normalInt++;
                if (normalInt < 2)
                {
                    MessageBox.Show("Keith has " + normalInt + " finger");
                }
                else
                {
                    MessageBox.Show("Keith has " + normalInt + " fingers");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("x must be 10");
            }
            else
            {
                MessageBox.Show("x isn't 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 3;
            string name = "Bobbo Jr.";
            if ((someValue == 3) || (name == "Joe"))
            {
                MessageBox.Show("x is 3 and the name is Joe");
            }
            MessageBox.Show("this line runs no matter what");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            MessageBox.Show("The answer is " + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
            }
        }
    }
}
