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
	public partial class BuyNewForm : Form
	{
		
		SqlConnection con = new SqlConnection(@"Data Source=AMINE-LAPTOP\SQLEXPRESS;Initial Catalog=Bilan;Integrated Security=True"); DataTable dt = new DataTable();
		public BuyNewForm()
		{
			InitializeComponent();
		}

		//////////////////////// random ID /////////////////////////////
		private static Random random = new Random();
		public static string RandomString1(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}
		public static string RandomString2(int length)
		{
			const string chars = "0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}
		///////////////////////////////////////////////////////////////

		private void label4_Click(object sender, EventArgs e){}

		private void btnBuy_Click(object sender, EventArgs e)
		{
			string rn = RandomString1(3) + "_" + RandomString2(4);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Buy(id,product,price,date_pr) VALUES ('" + rn + "','" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				cmd.SelectCommand.ExecuteNonQuery();
				
				MessageBox.Show("Product BOUGHT successfully !!");
				btnClear_Click(sender, e);
			}
			con.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			dateTimePicker1.Value = DateTime.Now;
		}
	}
}
