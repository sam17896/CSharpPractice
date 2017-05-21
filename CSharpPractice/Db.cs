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
    public partial class Db : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter da;

        public Db()
        {
            InitializeComponent();
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\AHSAN\\Documents\\Database1.accdb;Persist Security Info=True";
            cmd = new OleDbCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                cmd.CommandText = textBox1.Text;
                cmd.CommandTimeout = 15;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                
                da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    listView2.Items.Add(row["name"].ToString());
                }

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listView1.Items.Add(dr[1].ToString());
                }
                dr.Close();
                conn.Close();
            }
        }

        


    }
}
