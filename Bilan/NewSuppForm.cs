using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bilan
{
	public partial class NewSuppForm : Form
	{
		
		SqlConnection con = new SqlConnection(@"Data Source=AMINE-LAPTOP\SQLEXPRESS;Initial Catalog=Bilan;Integrated Security=True"); DataTable dt = new DataTable();

		public NewSuppForm()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Supplier(pseudo,name,last_name) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				cmd.SelectCommand.ExecuteNonQuery();

				MessageBox.Show("Supplier ADDED successfully !!");
				btnClear_Click(sender, e);
			}
			con.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
	}
}
