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

namespace Project_4
{
    public partial class Form1 : Form
    {
        SqlConnection conn=new SqlConnection("Server=DESKTOP-S869J6M\\SQLEXPRESS;Database=VSandSQL;Trusted_Connection=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_emb_dpt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from City_1";
            SqlDataAdapter da=new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo_address.DataSource = dt;
            combo_address.DisplayMember = "City_Name";
            combo_address.ValueMember = "City_ID";

            sql = "select * from Department_1";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            combo_emb_dpt.DataSource = dt;
            combo_emb_dpt.DisplayMember = "Dept_Name";
            combo_emb_dpt.ValueMember = "Dept_ID";

            Dictionary<string,string> emp_state = new Dictionary<string,string>();
            emp_state.Add("0", "Active");
            emp_state.Add("1", "UnActive");
            combo_status.DataSource = new BindingSource(emp_state, null);
            combo_status.DisplayMember = "Value";
            combo_status.ValueMember = "key";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "insert into Employee_1 values (@id,name,@dept,@city,@dbirth,@salary,@status)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txt_emp_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_emp_name.Text);
            cmd.Parameters.AddWithValue("@dept", combo_emb_dpt.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@city", combo_address.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@dbirth", date_emp.Value.ToString("yyyy/mm/dd 00:00:00"));
            cmd.Parameters.AddWithValue("@salary", Convert.ToString (txt_emp_sal).Text);
            cmd.Parameters.AddWithValue("@status", combo_status.SelectedValue.ToString());
        }
    }
}
