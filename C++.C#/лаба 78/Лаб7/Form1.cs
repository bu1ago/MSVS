using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лаб7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tabsDataSet.Table2". При необходимости она может быть перемещена или удалена.
            this.table2TableAdapter.Fill(this.tabsDataSet.Table2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tabsDataSet.Table1". При необходимости она может быть перемещена или удалена.
            this.table1TableAdapter.Fill(this.tabsDataSet.Table1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tabsDataSet.Table1". При необходимости она может быть перемещена или удалена.
            this.table1TableAdapter.Fill(this.tabsDataSet.Table1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tabsDataSet.Table2". При необходимости она может быть перемещена или удалена.
            this.table2TableAdapter.Fill(this.tabsDataSet.Table2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tabsDataSet.Table1". При необходимости она может быть перемещена или удалена.
            this.table1TableAdapter.Fill(this.tabsDataSet.Table1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] numbers = textBox1.Text.Split(new char[] { ' ' });
            int kol = numbers.Length, kol2 = 0;
            int[] mas = new int[kol];

            for (int i = 0; i < kol; i++)
                if (!String.IsNullOrWhiteSpace(numbers[i]))
                {
                    mas[kol2] = Convert.ToInt32(numbers[i]);
                    kol2++;
                }

            int[] mas1 = new int[kol2];
            Array.Copy(mas, 0, mas1, 0, kol2); 
            Array.Sort(mas1);
            Array.Reverse(mas1);

            for (int j = 0; j < kol2; j++)
            {
                for (int jj = 0; jj < kol2; jj++)
                {
                    if (mas1[j] == mas[jj])
                    {
                        listBox1.Items.Add(jj + 1);
                    }
                }
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void IzmText_TextChanged(object sender, EventArgs e)
        {

        }

        private void KolIzm_TextChanged(object sender, EventArgs e)
        {

        }

        private void Izm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(KolIzm.Text))
                KolIzm.Clear();
            if (!String.IsNullOrWhiteSpace(IzmText.Text))
                IzmText.Clear();
            if (!String.IsNullOrWhiteSpace(InputText.Text))
            {
                string[] text = InputText.Text.Split(new char[] { ' ' });
                int kol = text.Length, kol2 = 0;
                string[] izm = new string[InputText.TextLength];


                int ii = 0;
                for (int i = 0; i < kol; i++)
                {
                    izm[ii] = text[i].Substring(0, 1);
                    if (!String.IsNullOrWhiteSpace(text[i]))
                    {
                        for (int j = 1; j < text[i].Length; j++)
                        {
                            if (!(String.Equals(text[i].Substring(j, 1), text[i].Substring(j - 1, 1))))
                            {
                                izm[ii + 1] = text[i].Substring(j, 1);
                                ii++;
                            }
                            else
                                kol2++;
                        }
                        izm[ii+1] = " ";
                        ii = ii+2;
                    }
                }
                for (int i = 0; i < izm.Length; i++)
                  IzmText.Text += izm[i];
                                
                KolIzm.Text += kol2;
            }
        }


        private void table1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void table2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabsDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
