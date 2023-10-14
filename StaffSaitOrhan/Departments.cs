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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StaffSaitOrhan
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDepartment formDepartment = new FormDepartment();
            formDepartment.ShowDialog();
            renewData();
        }

        void renewData()
        {
            SqlConnection sqlConn = Definitions.sqlConn;
            SqlCommand cmd = new SqlCommand("Select * from Departments", sqlConn);

            try
            {
                sqlConn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            renewData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow dataGridViewCell = dataGridView1.SelectedRows[0];
            int id = (int)dataGridViewCell.Cells[0].Value;

            string dep = dataGridViewCell.Cells[1].Value.ToString();
            FormDepartment formDeoartment = new FormDepartment(id, dep);
            formDeoartment.ShowDialog();
            renewData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            int id = (int)dataGridViewRow.Cells[0].Value;

            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            SqlConnection sqlConn = Definitions.sqlConn;
            SqlCommand cmd = new SqlCommand("Delete Departments Where Id = @id", sqlConn);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                sqlConn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    renewData();
                }
                else
                {
                    MessageBox.Show("Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
