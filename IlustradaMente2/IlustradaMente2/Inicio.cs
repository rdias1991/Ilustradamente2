using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlustradaMente2
{
    public partial class Inicio : Form
    {
       
        public Inicio()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
     
        private void Inicio_Load(object sender, EventArgs e)
        {
            button7.Hide();
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            label8.Hide();
            textBox5.Hide();
            label1.Hide();
            label6.Hide();
            label7.Hide();
            textBox4.Hide();
            label4.Hide();
            textBox3.Hide();
            button1.Hide();
            

            textBox4.Enabled = false;
            textBox5.Enabled = false;
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
          
            button5.Enabled = true;
            Som telassom = new Som();
            telassom.Show();
            textBox4.Enabled = true;
            textBox5.Enabled = true;

            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            label4.Hide();
            textBox3.Hide();
            label2.Show();
           textBox1.Show();
            label8.Hide();
            textBox5.Hide();
            label3.Hide();
            textBox2.Hide();
            label1.Hide();
            label6.Hide();
            label7.Hide();
            textBox4.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            
            label3.Show();
            textBox2.Show();
            label2.Hide();
            textBox1.Hide();
            label8.Hide();
            textBox5.Hide();
            label1.Hide();
            label6.Hide();
            label7.Hide();
            textBox4.Hide();
            button1.Hide();
            label4.Hide();
            textBox3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Show();
            label4.Show();
            textBox3.Show();
            label3.Hide();
            textBox2.Hide();
            label2.Hide();
            textBox1.Hide();
            label8.Hide();
            textBox5.Hide();
            label1.Hide();
            label6.Hide();
            label7.Hide();
            textBox4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            button6.Enabled = true;
            label1.Show();
            label6.Show();
            label7.Show();
            textBox4.Show();
            label4.Hide();
            textBox3.Hide();
            label3.Hide();
            textBox2.Hide();
            label2.Hide();
            textBox1.Hide();
            label8.Hide();
            textBox5.Hide();
            button1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Show();
            label8.Show();
            textBox5.Show();
            label1.Hide();
            label6.Hide();
            label7.Hide();
            textBox4.Hide();
            label4.Hide();
            textBox3.Hide();
            label3.Hide();
            textBox2.Hide();
            label2.Hide();
            textBox1.Hide();
            button1.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabens! você concluiu seu estudo sobre: " + textBox1.Text);
        }
    }
    }

