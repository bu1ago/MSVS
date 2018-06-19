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
    public partial class Form1 : Form
    {      
        private static Form9 form9 = null;
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
        }      

        private void задача9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form9 == null || form9.IsDisposed)
            {
                form9 = new Form9();
                form9.MdiParent = this;
            }
            form9.Show();
            form9.Focus();
        }
    }
}
