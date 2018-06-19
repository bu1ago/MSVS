using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Rab_7
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            button1.TabIndex = 3;
            button2.TabIndex = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 1)
            {
                MessageBox.Show("Ошибка ввода символа.");
            }
            else
            {
                transformatio();
            }
        }

        void transformatio()
        {
            string s1 = textBox1.Text;
            string s2 = "";
            char symb = textBox2.Text[0];
            int sl_bilo = 0;
            int sl_stalo = 0;
            int symb_del = 0;
            string[] words = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string word in words)
            {
                sl_bilo++;
                int fSymb = word.IndexOf(symb);
                int lSymb = word.LastIndexOf(symb);
                if (fSymb != lSymb && fSymb != -1 && lSymb != -1)
                {
                    s2 += word.Remove(fSymb + 1, lSymb - fSymb - 1) + " ";
                    sl_stalo++;
                    symb_del += lSymb - fSymb - 1;
                }
            }
            textBox3.Text = s2;
            textBox4.Text = Convert.ToString(sl_bilo);
            textBox5.Text = Convert.ToString(sl_stalo);
            textBox6.Text = Convert.ToString(symb_del);
        }
    }
}
