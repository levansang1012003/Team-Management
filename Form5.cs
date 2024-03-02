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
    public partial class Form5 : Form
    {
        SqlConnection conn;
        public Form5()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-SPDRSA1L\SQLEXPRESS;Initial Catalog=Managament_Team;Integrated Security=True;");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

    }
}
