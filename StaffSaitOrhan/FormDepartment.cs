using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffSaitOrhan
{
    public partial class FormDepartment : Form
    {
        private int Id;
        public FormDepartment()
        {
            InitializeComponent();
        }
        public FormDepartment(int id, string dep)
        {
            InitializeComponent();
            this.Id = id;
            textBox1.Text = dep;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = Definitions.sqlConn;
            SqlCommand cmd;
            if (Id > 0)
            {
                cmd = new SqlCommand("Update Departments set Department = @dep Where Id = @id",sqlConn);
                cmd.Parameters.AddWithValue("@id", Id);
            }
            else
            {
                cmd = new SqlCommand("Insert Into Departments Values (@dep)", sqlConn);
            }
            cmd.Parameters.AddWithValue("@dep", textBox1.Text);

            try
            {
                sqlConn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConn.Close();
                }
                else
                {
                    MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
            textBox1.Clear();
        }
    }
}
