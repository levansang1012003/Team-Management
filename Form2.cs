using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeamManagament_Test
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        public Form2()
        {
        
            InitializeComponent();
           conn = new SqlConnection(@"Data Source=LAPTOP-SPDRSA1L\SQLEXPRESS;Initial Catalog=Managament_Team;Integrated Security=True;");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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
        public void btn_update_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIdTeam.Text) || string.IsNullOrEmpty(txtNameTeam.Text) || cbBP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin các trường bắt buộc.");
                return; 
            }

            try
            {
               
                SqlCommand cmdUpdate = new SqlCommand("UPDATE Department SET department_name = @department_name, descriptions = @descriptions WHERE department_id = @department_id", conn);
                cmdUpdate.Parameters.AddWithValue("@department_name", txtNameTeam.Text);
                cmdUpdate.Parameters.AddWithValue("@descriptions", cbBP.SelectedItem.ToString());
                cmdUpdate.Parameters.AddWithValue("@department_id", txtIdTeam.Text);
                cmdUpdate.ExecuteNonQuery();

                // Update data grid view (assuming it's in the same form)
                int selectedRowIndex = dtgv.SelectedRows[0].Index;
                dtgv.Rows[selectedRowIndex].Cells["department_name"].Value = txtNameTeam.Text;
                dtgv.Rows[selectedRowIndex].Cells["descriptions"].Value = cbBP.SelectedItem.ToString();

                MessageBox.Show("Cập nhật thông tin bộ phận thành công!");
                this.Close(); //
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cập nhật thông tin bộ phận: " + ex.Message);
            }
            SqlCommand cmd = new SqlCommand("UPDATE Department SET  department_name = @department_name, descriptions = @descriptions WHERE department_id = @department_id", conn);
            cmd.Parameters.AddWithValue("@department_name", txtNameTeam.Text);
            cmd.Parameters.AddWithValue("@descriptions", cbBP.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@department_id", txtIdTeam.Text);
            Loadf();

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
