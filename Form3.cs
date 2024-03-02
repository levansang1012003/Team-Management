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

namespace TeamManagament_Test
{
    public partial class Form3 : Form
    {

        SqlConnection conn;
        public Form3()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-SPDRSA1L\SQLEXPRESS;Initial Catalog=Managament_Team;Integrated Security=True;");
        }


        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];
                txtIdTeam.Text = row.Cells[0].Value.ToString();
                txtNameTeam.Text = row.Cells[1].Value.ToString();
                cbBP.SelectedIndex = cbBP.FindStringExact(row.Cells[2].Value.ToString());
            }

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdTeam.Text) || string.IsNullOrEmpty(txtNameTeam.Text) || cbBP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin các trường bắt buộc.");
                return;
            }

            try
            {
                string departmentId = txtIdTeam.Text;
                string departmentName = txtNameTeam.Text;
                string description;
                if (cbBP.SelectedIndex != -1)
                {
                    description = cbBP.SelectedItem.ToString();
                }
                else
                {
                    description = "";
                }

                if (conn == null)
                {
                    MessageBox.Show("Error connecting to database.");
                    return; 
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Department (department_id, department_name, descriptions) VALUES (@department_id, @department_name, @descriptions)", conn);
                cmd.Parameters.AddWithValue("@department_id", departmentId);
                cmd.Parameters.AddWithValue("@department_name", departmentName);
                cmd.Parameters.AddWithValue("@descriptions", description);

                cmd.ExecuteNonQuery();
                 this.Close();
                MessageBox.Show("Thêm bộ phận thành công!");
                Loadf();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm bộ phận: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close(); 
                }
            }
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            Loadf();

            dtgv.Columns[0].HeaderText = "Mã Team";
            dtgv.Columns[1].HeaderText = "Tên Team";
            dtgv.Columns[2].HeaderText = "Bộ Phận";
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
        }
          public void Loadf()
        {
            SqlCommand cmd = new SqlCommand("select * from Department ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtgv.DataSource = dtb;
            dtgv.RowHeadersVisible = false; // xóa góc cột trái màn hình 
            dtgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
           
        }
        private void LoadData()
        {
         
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {

           this.Close ();
        }
    }
}
