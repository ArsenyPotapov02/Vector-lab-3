using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = Properties.Settings.Default.x.ToString();
            textBox3.Text = Properties.Settings.Default.y.ToString();
            textBox4.Text = Properties.Settings.Default.z.ToString();
            textBox5.Text = Properties.Settings.Default.x.ToString();
            textBox6.Text = Properties.Settings.Default.y.ToString();
            textBox7.Text = Properties.Settings.Default.z.ToString();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            Vectors sub1 = new Vectors();

            Vectors sub2 = new Vectors();


          
            try
            {
                sub1.x = double.Parse(this.textBox2.Text);
                sub1.y = double.Parse(this.textBox3.Text);
                sub1.z = double.Parse(this.textBox4.Text);
                sub2.x = double.Parse(this.textBox5.Text);
                sub2.y = double.Parse(this.textBox6.Text);
                sub2.z = double.Parse(this.textBox7.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                return;
            }



            textBox1.Text = sub1.GetLenght().ToString();
            textBox8.Text = sub2.GetLenght().ToString();
            textBox9.Text = (sub1 + sub2).ToString();
            textBox10.Text =(sub1-sub2).ToString();
            textBox11.Text = sub1.GetScalar(sub2).ToString();
            textBox12.Text = (sub1*sub2).ToString();


        }
    }
}
