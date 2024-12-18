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

namespace Project_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=DESKTOP-S869J6M\\SQLEXPRESS;Database=VSandSQL;Trusted_Connection=True";
            conn.Open();
            MessageBox.Show(conn.State.ToString());
            conn.Close();
            MessageBox.Show(conn.State.ToString());
        }
    }
}
