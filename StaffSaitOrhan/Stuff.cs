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
    public partial class Stuff : Form
    {
        public int Id { get; set; }

        public Stuff()
        {
            InitializeComponent();
            getDepartments();
            dateTimePicker1.MaxDate = DateTime.Today;
            cbGender.SelectedIndex = 0;
        }

        public Stuff(int id)
        {
            InitializeComponent();
            getDepartments();
            Id = id;
            dateTimePicker1.MaxDate = DateTime.Today;
            cbGender.SelectedIndex = 0;

            StuffToBeUpdated();
        }

        private void StuffToBeUpdated()
        {
            SqlConnection sqlConn = Definitions.sqlConn;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 [Id], [Name], [Surname], [BirthDate], [Gender], [TCNo], [Departmentid] from [SaitOrhan].[dbo].[Workers] where Id = @id", sqlConn);
            cmd.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textBoxName.Text = reader.GetString(1);
                    textBoxSurname.Text = reader.GetString(2);
                    dateTimePicker1.Value = reader.GetDateTime(3);
                    cbGender.SelectedIndex = Convert.ToInt32(reader.GetBoolean(4));
                    mtbTCNo.Text = reader.GetString(5);
                    int depId = reader.GetInt32(6);

                    foreach (SqlDepartment item in cbDepartments.Items)
                    {
                        if (item.Id == depId)
                        {
                            cbDepartments.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                sqlConn.Close();
            }
        }

        void getDepartments()
        {
            SqlConnection sqlConn = Definitions.sqlConn;
            SqlCommand cmd = new SqlCommand("Select * from Departments", sqlConn);

            try
            {
                sqlConn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SqlDepartment sqlDepartment = new SqlDepartment { Id = reader.GetInt32(0), Department = reader.GetString(1) };
                    cbDepartments.Items.Add(sqlDepartment);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = Definitions.sqlConn;
            SqlCommand cmd;

            if (Id > 0)
            {
                cmd = new SqlCommand("Update Workers set Name = @n, Surname = @s, BirthDate = @b, Gender = @g, TCNo = @t, Departmentid = @d where Id = @id", sqlConn);
                cmd.Parameters.AddWithValue("@id", Id);
            }
            else
            {
                cmd = new SqlCommand("Insert Into Workers Values (@n, @s, @b, @g, @t, @d)", sqlConn);
            }

            cmd.Parameters.AddWithValue("@n", textBoxName.Text);
            cmd.Parameters.AddWithValue("@s", textBoxSurname.Text);
            cmd.Parameters.AddWithValue("@b", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@g", Convert.ToBoolean(cbGender.SelectedIndex));
            cmd.Parameters.AddWithValue("@t", mtbTCNo.Text);
            cmd.Parameters.AddWithValue("@d", (cbDepartments.SelectedItem as SqlDepartment).Id);

            try
            {
                sqlConn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            cbDepartments.SelectedIndex = -1;
            textBoxName.Clear();
            textBoxSurname.Clear();
            cbGender.SelectedIndex = 0;
            mtbTCNo.Clear();
        }
    }
}
