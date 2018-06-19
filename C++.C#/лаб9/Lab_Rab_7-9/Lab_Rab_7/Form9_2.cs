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
    public partial class Form9_2 : Form
    {
        public Form9_2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String forma = textBox2.Text;
            int cost = Convert.ToInt32(textBox3.Text);
            int k = 0;
            Grid1.Rows.Clear();
            
            foreach (DataRow i in lab_Rab_9DataSet1.Таблица1.Rows)
            {
                if (name == i[1].ToString() && forma == i[2].ToString())
                    foreach (DataRow j in lab_Rab_9DataSet1.Таблица2.Rows)
                        if (i[0].ToString() == j[2].ToString() && Convert.ToInt32(j[3].ToString())<=cost)
                        {
                            Grid1.Rows.Add();
                            Grid1[0, k].Value = j[0].ToString();
                            Grid1[1, k].Value = j[3].ToString();
                            k++;
                        }
            }
        }

        private void Form9_2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_Rab_9DataSet1.Таблица2". При необходимости она может быть перемещена или удалена.
            this.таблица2TableAdapter1.Fill(this.lab_Rab_9DataSet1.Таблица2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_Rab_9DataSet1.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter1.Fill(this.lab_Rab_9DataSet1.Таблица1);

        }
    }
}
