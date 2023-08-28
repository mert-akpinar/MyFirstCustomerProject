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

namespace MyFirstCustomerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-R9DVO40; Initial catalog=MyDbCustomer; integrated Security=true");
        private void BtnDepartmentList_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TblDepartment", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDepartmentSave_Click(object sender, EventArgs e)
        {
            if (rdbActive.Checked || rdbPassive.Checked)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into TblDepartment(DepartmentName,DepartmentStatus) Values(@p1,@p2)", connection);
                command.Parameters.AddWithValue("@p1", txtDepartmentName.Text);
                if (rdbActive.Checked)
                {
                    command.Parameters.AddWithValue("@p2", "True");
                }
                if (rdbPassive.Checked)
                {
                    command.Parameters.AddWithValue("@p2", "False");
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Departman başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir durum seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDepartmentDelete_Click(object sender, EventArgs e)
        {
            if(txtDepartmentID.Text != "")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from TblDepartment where DepartmentID = @p1",connection);
                command.Parameters.AddWithValue("@p1",txtDepartmentID.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Departman başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                connection.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Id alanını boş geçmeyiniz","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnDepartmentUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblDepartment set DepartmentName=@p1 where DepartmentID=@p2",connection);
            command.Parameters.AddWithValue("@p1", txtDepartmentName.Text);
            command.Parameters.AddWithValue("@p2", txtDepartmentID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Departman başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            connection.Close();
        }
    }
}
