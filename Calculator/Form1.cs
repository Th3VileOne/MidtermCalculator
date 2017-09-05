using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static double result=0, value=0;
        public static char currenttask = '+';
        public static String conversion;
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("THB -> USD");
            listBox1.Items.Add("USD -> THB");
        }
        private void num_click(object sender, EventArgs e)
        {
            Button num = sender as Button;

            if (value == 0)
            { maintextbox.Text = ""; }
            maintextbox.Text += num.Text;
            value = Convert.ToDouble(maintextbox.Text);
            if (currenttask == '=')
            {
                result = Convert.ToDouble(maintextbox.Text);
            }
        }
        
        private void operationclick(object sender, EventArgs e)
        {
            Button ope = sender as Button;
            char b = ' ';
            //operator with text longer than 1
            if (ope.Text.Length > 1)
            {
                if (ope.Text.Equals("Mod"))
                {
                    b = '%';
                }
            }
            else
            {
                 b = Convert.ToChar(ope.Text);
            }
            //if (currenttask == ' ')
            //currenttask = b;
            switch (currenttask)
            {
                case '+':
                    result += value;
                    value = 0;
                    //maintextbox.Text = Convert.ToString(result);
                    break;
                case '-':
                    result -= value;
                    value = 0;
                    //maintextbox.Text = Convert.ToString(result);
                    break;
                case 'x':
                    result *= value;
                    value = 0;
                    //maintextbox.Text = Convert.ToString(result);
                    break;
                case '/':
                    result /= value;
                    value = 0;
                    //maintextbox.Text = Convert.ToString(result);
                    break;
                case '%':
                    result %= value;
                    value = 0;
                    //maintextbox.Text = Convert.ToString(result);
                    break;
                case '^':
                    result = Math.Pow(result,value);
                    value = 0;
                    //maintextbox.Text = Convert.ToString(result);
                    break;                

                default:
                   
                    //result = value;
                    value = 0;
                    maintextbox.Text = Convert.ToString(result);
                    break;
            }
            currenttask = b;
            CurOp.Text = Convert.ToString(currenttask);
            
        }
        // Working with memory
        private void Memory(object sender, EventArgs e)
        {
            Button ope = sender as Button;
            
            char mem = ope.Text.ElementAt(1);

            // if it is clear
            if (mem == 'C')
                MemStore.Text = "0";

            else
            {
                if (!maintextbox.Text.Equals(""))
                {
                    switch (mem)
                    {
                        case '+':
                            MemStore.Text = Convert.ToString(Convert.ToDouble(MemStore.Text) + Convert.ToDouble(maintextbox.Text));

                            break;
                        case '-':
                            MemStore.Text = Convert.ToString(Convert.ToDouble(MemStore.Text) - Convert.ToDouble(maintextbox.Text));

                            break;
                    }
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            result = 0;
            value = 0;
            maintextbox.Text = "";
            currenttask = '=';
            CurOp.Text = "";
    }

        private void percentage_Click(object sender, EventArgs e)
        {
            value = result*(value/100);
            buttonresult.PerformClick();
            buttonresult.PerformClick();
            
        }

        private void converter_Click(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex){
                case 0:
                    {
                        result /= 30.3;
                        buttonresult.PerformClick();
                        buttonresult.PerformClick();
                        CurOp.Text = "$";
                        break;
                    }
                case 1: {
                        result *= 30.3;
                        buttonresult.PerformClick();
                        buttonresult.PerformClick();
                        CurOp.Text = ("B");
                        break;
                    }
                    


            }
        }

        void onetimeoperation(object sender, EventArgs e)
        {
            Button ope = sender as Button;
            if (currenttask != '=')
            {
                operationclick(sender, e);
            }
            if (maintextbox.Text.Length > 0)
            {
                if (ope.Text.Equals("^2"))
                {
                    result = Math.Pow(Convert.ToDouble(maintextbox.Text), 2);
                    value = 0;
                    maintextbox.Text = Convert.ToString(result);
                }
                else if (ope.Text.Equals("^3"))
                {
                    result = Math.Pow(Convert.ToDouble(maintextbox.Text), 3);
                    value = 0;
                    maintextbox.Text = Convert.ToString(result);
                }
                else if (ope.Text.Equals("10^"))
                {
                    result = Math.Pow(10, Convert.ToDouble(maintextbox.Text));
                    value = 0;
                    maintextbox.Text = Convert.ToString(result);
                }
                else if (ope.Text.Equals("Exp"))
                {
                    result = Math.Exp(Convert.ToDouble(maintextbox.Text));
                    value = 0;
                    maintextbox.Text = Convert.ToString(result);
                }
                currenttask = '=';
            }
            CurOp.Text = Convert.ToString(currenttask);

        }
        
    }
}
