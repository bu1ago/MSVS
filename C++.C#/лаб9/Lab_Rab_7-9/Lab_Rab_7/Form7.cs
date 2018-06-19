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
    public partial class Form7 : Form
    {
        Int32[] mas;
        Int32[] mas2;
        int size = 0;

        public Form7()
        {
            InitializeComponent();
            mas = new Int32[100];
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 1;
            button1.TabIndex = 2;
            textBox2.TabIndex = 3;
            button2.TabIndex = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    mas[size] = Convert.ToInt32(textBox1.Text);
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                    size++;
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода!");
                    textBox1.Text = "";
                }
            }
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    // Нашли максимальный элемент
                    Int32 K = Convert.ToInt32(textBox2.Text);
                    int size2, i_max = 0;
                    for (int i = 1; i < size; i++)
                    {
                        if (mas[i] > mas[i_max])
                            i_max = i;
                    }

                    // Если количество элементов больше К
                    if (K < size)
                    {
                        size2 = size;
                        mas2 = new Int32[size2];
                        for (int i = 0; i < size; i++)
                            mas2[i] = mas[(i + i_max) % size];
                    }
                    // Если меньше или равно
                    else
                    {
                        size2 = size + 1;
                        mas2 = new Int32[size2];
                        mas2[0] = K;
                        for (int i = 0; i < size; i++)
                            mas2[i + 1] = mas[i];
                    }
                    // Печать mas2 в listBox2
                    listBox2.Items.Clear();
                    for (int i = 0; i < size2; i++)
                        listBox2.Items.Add(mas2[i]);
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода!");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                button1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
