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
    public partial class Form1 : Form
    {

     SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-SPDRSA1L\SQLEXPRESS;Initial Catalog=Managament_Team;Integrated Security=True;");
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if ( conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            Loadf();
            dtgv.Columns[0].HeaderText = "Mã Team";
            dtgv.Columns[1].HeaderText = "Tên Team";
            dtgv.Columns[2].HeaderText = "Tên Bộ Phận";
            dtgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
         

        }
    
        public void Loadf()
        {
            SqlCommand cmd = new SqlCommand("select * from Department ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtgv.DataSource = dtb;
            dtgv.RowHeadersVisible = false;
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dtgv.AllowUserToAddRows = false;

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SortColumn(int columnIndex)
        {
            // Lấy DataTable từ DataGridView
            DataTable dt = (DataTable)dtgv.DataSource;

            // Sắp xếp dữ liệu theo cột theo thứ tự từ A đến Z
            dt.DefaultView.Sort = dtgv.Columns[columnIndex].HeaderText + " ASC";
            dtgv.DataSource = dt.DefaultView;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();// tạo 1 winform sửa 
            form3.ShowDialog();// show nó lên 
            form3 = null;
            this.Show();
            Loadf();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private  void Form1_Click(object sender, EventArgs e)
        {

        }
        private void btn_fixitem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2 = null;
            this.Show();
            Loadf();
        }
      
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dtgv.SelectedRows.Count > 0)
            {
                // Lấy  vaf chọn từ DataGridView
                DataGridViewRow selectedRow = dtgv.SelectedRows[0];
                // Lấy mã bộ phận từ hàng được chọn
                string id = selectedRow.Cells["department_id"].Value.ToString();

               
                DialogResult result = MessageBox.Show("Bạn muốn thực hiện hành động này không ?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Kiểm tra kkets quả sau khii dungf
                if (result == DialogResult.OK)
                {
                    // Nếu người dùng chấp nhận xóa, thực hiện xóa dữ liệu khỏi database
                    SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE department_id = @department_id", conn);
                    cmd.Parameters.AddWithValue("@department_id", id);
                    cmd.ExecuteNonQuery();

                    // Xóa hàng khỏi DataGridView
                    dtgv.Rows.Remove(selectedRow);

                    // Xóa dữ liệu từ các điều khiển nhập liệu khác
                    txtIdTeam.Clear();
                    txtNameTeam.Clear();
                    cbBP.SelectedIndex = -1;
                }
                // Ngược lại, nếu người dùng chọn Cancel, không thực hiện xóa
                else if (result == DialogResult.Cancel)
                {
                  
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
      
        private void btn_search_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4 = null;
            this.Show();
            Loadf();
        }
    }
}
