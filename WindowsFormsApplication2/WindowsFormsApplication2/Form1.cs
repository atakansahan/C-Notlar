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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Server=ALS-YG39104-J09;Database=Bilet;UID=sa;PWD=123456789?");

            //SqlCommand cmd = new SqlCommand("INSERT INTO Categories(CategoryName, Description VALUES ('Yeni Kategori', 'Açıklama')", baglan);

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Table_1", baglan);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
