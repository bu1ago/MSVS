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
    public partial class Form9_1 : Form
    {
        public Form9_1()
        {
            InitializeComponent();
        }

        private void Form9_1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_Rab_9DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.lab_Rab_9DataSet.Таблица1);

            int k = 0;
            foreach (DataRow i in lab_Rab_9DataSet.Таблица1.Rows)
            {
                if (i[2].ToString() == "Настойка")
                {
                    Grid1.Rows.Add();
                    Grid1[0, k].Value = i[1].ToString();
                    Grid1[1, k].Value = i[0].ToString();
                    Grid1[2, k].Value = i[3].ToString();
                    k++;
                }
            }

        }
    }
}
