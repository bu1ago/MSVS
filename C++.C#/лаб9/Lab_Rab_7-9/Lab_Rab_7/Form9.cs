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
    public partial class Form9 : Form
    {
        private static Form9_1 form91 = null;
        private static Form9_2 form92 = null;
        private static Form9_3 form93 = null;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_Rab_9DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.lab_Rab_9DataSet.Таблица1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_Rab_9DataSet.Таблица2". При необходимости она может быть перемещена или удалена.
            this.таблица2TableAdapter.Fill(this.lab_Rab_9DataSet.Таблица2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form91 == null || form91.IsDisposed)
            {
                form91 = new Form9_1();
                form91.MdiParent = this.MdiParent;
            }
            form91.Show();
            form91.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (form92 == null || form92.IsDisposed)
                {
                    form92 = new Form9_2();
                    form92.MdiParent = this.MdiParent;
                }
                form92.Show();
                form92.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (form93 == null || form93.IsDisposed)
                {
                    form93 = new Form9_3();
                    form93.MdiParent = this.MdiParent;
                }
                form93.Show();
                form93.Focus();
            }
        }
    }
}
