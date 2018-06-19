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
    public partial class Form9_3 : Form
    {
        public Form9_3()
        {
            InitializeComponent();
        }

        private void Form9_3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_Rab_9DataSet.Таблица2". При необходимости она может быть перемещена или удалена.
            this.таблица2TableAdapter.Fill(this.lab_Rab_9DataSet.Таблица2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_Rab_9DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.lab_Rab_9DataSet.Таблица1);

            int k = 0;
            foreach (DataRow i in lab_Rab_9DataSet.Таблица1.Rows)
            {
                Grid1.Rows.Add();
                Grid1[0, k].Value = i[1].ToString();
                k++;
            }
            
            foreach (DataRow j in lab_Rab_9DataSet.Таблица2.Rows)
            {
                bool flag = false;
                foreach (DataGridViewColumn i in Grid1.Columns)
                    if (i.Name == j[0].ToString())
                        flag = true;
                if (!flag)
                    Grid1.Columns.Add(j[0].ToString(), j[0].ToString());
            }

            for (int y = 0; y < Grid1.RowCount; y++)
                for (int x = 1; x < Grid1.ColumnCount; x++)
                    foreach (DataRow i in lab_Rab_9DataSet.Таблица1.Rows)
                        if (i[1].ToString() == Grid1[0, y].Value.ToString()) {
                            string shifr = i[0].ToString();
                            foreach (DataRow j in lab_Rab_9DataSet.Таблица2.Rows)
                                if (j[2].ToString() == shifr && j[0].ToString()==Grid1.Columns[x].Name)
                                    Grid1[x, y].Value = j[3].ToString();
                                }
        }
    }
}
