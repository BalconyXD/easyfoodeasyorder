using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    
       
    public partial class Form1 : Form
    {
        string[] foodlist = { "Omelette rice", "American fried rice", "Fried pork with garlic", "Red pork over rice", "Congee with pork", "Fried rice with basil and pork", "Chicken with sauce over rice", "Rice with crispy pork" };
        int[] price = { 25, 50, 30, 40, 25, 35, 30, 40 };
        int[] sum = new int[8];
        NumericUpDown[] numarics = new NumericUpDown[8];
        int sumall = 0;
        int income = 0;
        int exchange;
        


        public Form1()
        {
            InitializeComponent();
            numarics[0] = numericUpDownfood1;
            numarics[1] = numericUpDownfood2;
            numarics[2] = numericUpDownfood3;
            numarics[3] = numericUpDownfood4;
            numarics[4] = numericUpDownfood5;
            numarics[5] = numericUpDownfood6;
            numarics[6] = numericUpDownfood7;
            numarics[7] = numericUpDownfood8;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void orderbt1_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 8; i++)
            {
                sum[i] = Convert.ToInt32(numarics[i].Value) * price[i];
                if (numarics[i].Value > 0)
                {
                    
                    listBox1.Items.Add(foodlist[i] + " Amount " + numarics[i].Value + " Per Price " + price[i] + "  Total Price " + (price[i] * numarics[i].Value));
                }
                
            }
            

            for (int i = 0; i < 8; i++)
            {
                sumall = sumall + sum[i];
            }
            sumbox1.Text = sumall.ToString();

            numericUpDownfood1.Value = 0;
            numericUpDownfood2.Value = 0;
            numericUpDownfood3.Value = 0;
            numericUpDownfood4.Value = 0;
            numericUpDownfood5.Value = 0;
            numericUpDownfood6.Value = 0;
            numericUpDownfood7.Value = 0;
            numericUpDownfood8.Value = 0;


        }

        private void clearbt1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            sumall = 0;
            for (int i = 0; i < 8; i++)
            {
                sum[i] = 0;
            }
            sumbox1.Clear();
            sumbox2.Clear();
            sumbox3.Clear();

        }

        private void sumbt1_Click(object sender, EventArgs e)
        {
      
            
         
            

           
            
                int.TryParse(sumbox2.Text, out income);
                exchange = income - sumall;
                sumbox3.Text = exchange.ToString();
            if(income > 0)
            {
                MessageBox.Show(" The total amount is " + sumall.ToString() + "\n The total payment is " + income + "\n The total balance is " +exchange);
               
            }
            else
            {
                sumbox3.Clear();
                MessageBox.Show(" Can't  CheckBill , Please insert the payment  ");
            }

                
            





        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:\\" + DateTime.Now.ToString("ddmmyyHHmmss") + (".txt"));
            for (int i = 0;i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i]);
            }
            sw.WriteLine(" Total " + sumall + "  baht ");
            sw.WriteLine(" Pay " + income + "  Baht ");
            sw.WriteLine(" Change " + exchange + "  Baht ");
            sw.Close();
            MessageBox.Show("Print Bill");




        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void sumbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sumbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonnnnnnn_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
