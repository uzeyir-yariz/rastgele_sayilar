using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgele_dizi_deg
{
    public partial class Form1 : Form
    {
        int[] s = new int[100];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Visible = true;
            listBox1.Items.Clear();
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = rnd.Next(0, 500);  
            }

            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(i + 1 + ") " + s[i]);
            }

            for (int i = 0; i < s.Length; i++)
            {
                comboBox2.Items.Add(s[i]);
            }

            textBox1.Text = s.Max().ToString();
            textBox2.Text = s.Min().ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(s);
            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]);
            }

            button3.Visible = true;
            button2.Visible = false;
            textBox1.Text = s.Max().ToString();
            textBox2.Text = s.Min().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Reverse(s);
            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(i + 1 + ") " + s[i]);
            }

            button3.Visible = false;
            button2.Visible = true;
            textBox1.Text = s.Max().ToString();
            textBox2.Text = s.Min().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Visible = true;
        }
        
        private void tat()
        {
            listBox2.Items.Clear();
            if (comboBox1.Text == "")
            {

            }

            else
            {
                int tex = Convert.ToInt32(comboBox1.Text);

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] % tex == 0)
                    {
                        listBox2.Items.Add(i + 1 + ") " + s[i]);
                    }

                    else
                    {

                    }
                }

                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi;
            for (int i = 0; i < s.Length; i++)
            {
                if (comboBox2.Text == listBox1.Items[i])
                {
                    MessageBox.Show(comboBox2.Text + " belirlenen hedef bulundu ");                    
                }
            }
        }
    }
}
