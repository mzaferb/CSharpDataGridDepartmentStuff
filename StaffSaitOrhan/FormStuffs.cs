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
    public partial class FormStuffs : Form
    {
        public FormStuffs()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        void renewData()
        {
            SqlConnection sqlConn = Definitions.sqlConn;
            SqlCommand cmd = new SqlCommand("Select w.Id, w.Name, w.Surname, w.BirthDate, w.Gender, w.TCNo, d.Department from Workers w join Departments d on w.Departmentid = d.Id", sqlConn);

            try
            {
                sqlConn.Open();
                dataGridView1.Rows.Clear();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3).ToString("dd.MM.yyyy"), reader.GetBoolean(4) ? "Erkek" : "Kadın", reader.GetString(5), reader.GetString(6));
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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
