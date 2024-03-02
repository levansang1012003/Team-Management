using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;




namespace TeamManagament_Test
{
    public partial class Form4 : Form
    {
        SqlConnection conn;
      
        public Form4()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-SPDRSA1L\SQLEXPRESS;Initial Catalog=Managament_Team;Integrated Security=True;");
        }
        private void ExportToExcel()
{

    // Creating a Excel object.
    Excel.Application excelApp = new Excel.Application();
    Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
    Excel.Worksheet worksheet = workbook.Sheets[1];

    // Adding column headers
    worksheet.Cells[1, 1] = "Mã Team";
    worksheet.Cells[1, 2] = "Tên Team";
    worksheet.Cells[1, 3] = "Bộ Phận";

    int row = 2; // Start row (in row 1 are headers)
    foreach (DataGridViewRow dgvRow in dtgv.Rows)
    {
        // Don't save the last empty row
        if (!dgvRow.IsNewRow)
        {
            for (int col = 0; col < dgvRow.Cells.Count; col++)
            {
                worksheet.Cells[row, col + 1] = dgvRow.Cells[col].Value.ToString();
            }
            row++;
        }
    }


    // Auto-fit columns
    worksheet.Columns.AutoFit();

    // Show save file dialog
    var saveFileDialog = new SaveFileDialog();
    saveFileDialog.FileName = "output";
    saveFileDialog.DefaultExt = ".xlsx";
    if (saveFileDialog.ShowDialog() == DialogResult.OK)
    {
        workbook.SaveAs(saveFileDialog.FileName);
        excelApp.Quit();
        MessageBox.Show("Export Successful", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else
    {
        excelApp.Quit();
    }
    
}


        private void Form4_Load(object sender, EventArgs e)
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
        public void LoadGridByKeyWord()
        {
            SqlCommand cmd = new SqlCommand("select * from Department where department_name like '%"+txtKeyword.Text+"%' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dtb = new System.Data.DataTable();
            da.Fill(dtb);
            dtgv.DataSource = dtb;
        }
        public void Loadf()
        {
            SqlCommand cmd = new SqlCommand("select * from Department ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dtb = new System.Data.DataTable();
            da.Fill(dtb);
            dtgv.DataSource = dtb;
            dtgv.RowHeadersVisible = false; // xóa góc cột trái màn hình 
            dtgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadGridByKeyWord();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadGridByKeyWord();
        }

        private void btnrefreshSearch_Click(object sender, EventArgs e)
        {
            Loadf();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Tạo tài liệu PDF
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("output.pdf", FileMode.Create));
                document.Open();

                // Tạo bảng PDF
                PdfPTable pdfTable = new PdfPTable(dtgv.Columns.Count);
                // Add tiêu đề từ DataGridView vào bảng PDF
                for (int i = 0; i < dtgv.Columns.Count; i++)
                {
                    pdfTable.AddCell(dtgv.Columns[i].HeaderText);
                }
                // Add dữ liệu từ DataGridView vào bảng PDF
                for (int row = 0; row < dtgv.Rows.Count; row++)
                {
                    for (int column = 0; column < dtgv.Columns.Count; column++)
                    {
                        if (dtgv.Rows[row].Cells[column].Value != null)
                        {
                            pdfTable.AddCell(dtgv.Rows[row].Cells[column].Value.ToString());
                        }
                    }
                }
                // Add bảng PDF vào tài liệu
                document.Add(pdfTable);

                // Đóng tài liệu
                document.Close();

                MessageBox.Show("Xuất PDF thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            Process.Start("output.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcel();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
