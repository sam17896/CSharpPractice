using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace CSharpPractice
{
    public partial class DataGridView : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataTable dt;
        public DataGridView()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\AHSAN\\Documents\\Database1.accdb;Persist Security Info=True";
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from users";
            cmd.CommandTimeout = 15;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();

            dt = new DataTable();
            dt = ds.Tables[0];

            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            da.Update(dt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString(); 
        }
    }
}
