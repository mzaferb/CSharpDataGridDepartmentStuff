using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffSaitOrhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.MdiParent = this;
            departments.Show();
        }

        private void stuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStuffs formStuffs = new FormStuffs();
            formStuffs.MdiParent = this;
            formStuffs.Show();
        }
    }
}
