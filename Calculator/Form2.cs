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
    public partial class Form2 : Form
    {
        public static double result = 0, value = 0;
        public static char currenttask = '=';
        public Form2()
        {
            InitializeComponent();
        }


        private void num_click(object sender, EventArgs e)
        {
            Button num = sender as Button;
            maintextbox.Text += num.Text;
            maintextbox.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maintextbox.Text = "";
            maintextbox.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            maintextbox.Focus();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            maintextbox.Focus();
        }

        private void maintextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check for key type
            if (e.KeyChar >=40 && e.KeyChar <= 57)
            {
                if(e.KeyChar==42)
                    maintextbox.Text += 'x';
                else
                    maintextbox.Text += e.KeyChar;
            }
            else if (e.KeyChar == '\b' && maintextbox.Text.Length > 0)
            {
                maintextbox.Text = maintextbox.Text.Substring(0, maintextbox.Text.Length - 1);
            }
            else if (e.KeyChar == '\r')
            {
                Calculate(sender, e);
            }
        }
        String Calculates(String text)
        {
            // check parenthesis
            int openPar = text.IndexOf("(");
            int closePar = text.Length;
            //if there is parenthesis
            if (openPar != -1){
                String newtext = "";
                //if parenthesis is not in the first location
                if (openPar > 0)
                {
                    //add string before the parenthesis
                    newtext += text.Substring(0, openPar);
                }
                    //count to find the ending of the first parenthesis
                int next_parenthesis = 1;
                for (int i = openPar+1;i < text.Length; i ++)
                {
                    switch (text.ElementAt(i)) {
                        // find the ending then -1 to get 0 parenthesis
                        case ')':
                        next_parenthesis--;
                            break;
                        case '(':
                        // add extra parenthesis if there are more patenthesis
                            next_parenthesis++;
                            break;
                    }
                    //when parenthesis reach 0 break the loop and identify the ending parenthesis location
                    if (next_parenthesis == 0)
                    {
                        closePar = i;
                        break;
                    }
                }
                //if there is parenthesis
                if (text.Length-closePar != 0)
                {   
                    //calculate the substring and add into the text
                    newtext += Calculates(text.Substring(openPar + 1, closePar - openPar - 1));
                    // get the rest of the information after ending parenthesis
                    newtext += text.Substring(closePar +1, text.Length - closePar-1);
                }
                else
                {
                    //add the text if there is no more parenthesis
                    newtext += text.Substring(closePar + 1, text.Length);
                }

                //calculate the the last parenthesis if any
                String a = newtext;
                text = Calculates(newtext);
            }
            //put the text into array
            String[] num = text.Split(new char[] { '+', '-', 'x', '/'});
            String[] ope = text.Split(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
            
            //take out the blank or null space
            ope = ope.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //run the array to find / or x

            
            for (int i = 0; i < ope.Length; i++)
            {
                if (ope[i].Equals("/") || ope[i].Equals("x"))
                {
                    double num1 = Convert.ToDouble(num[i]);
                    double num2 = Convert.ToDouble(num[i + 1]);
                    if (ope[i].Equals("/"))
                    {
                        num[i] = Convert.ToString(num1 / num2);
                    }
                    else
                    {
                        num[i] = Convert.ToString(num1 * num2);
                    }
                    num[i + 1] = "";
                    ope[i] = "";
                    ope = ope.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    num = num.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    //go back one space because we take out the empty array
                    i--;
                }
            }
            //same with above just to work on + and - operation
            for (int i = 0; i < ope.Length; i++)
            {

                if (ope[i].Equals("+") || ope[i].Equals("-"))
                {
                    double num1 = Convert.ToDouble(num[i]);
                    double num2 = Convert.ToDouble(num[i + 1]);
                    if (ope[i].Equals("+"))
                    {
                        num[i] = Convert.ToString(num1 + num2);
                    }
                    else
                    {
                        num[i] = Convert.ToString(num1 - num2);
                    }
                    num[i + 1] = "";
                    ope[i] = "";
                    ope = ope.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    num = num.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    i--;
                }
            }
            
            return num[0];
        }
        private void Calculate(object sender, EventArgs e)
        {

            maintextbox.Text = Calculates(maintextbox.Text);
            
            maintextbox.Focus();
        }
    }
}
