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

namespace Bilan
{
	public partial class SuppForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=AMINE-LAPTOP\SQLEXPRESS;Initial Catalog=Bilan;Integrated Security=True");
		DataTable dt = new DataTable();
		public SuppForm()
		{
			InitializeComponent();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "SELECT * FROM Supplier";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				
				cmd.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
		}
		
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string cell1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			string cell2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			string cell3 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Supplier(pseudo,name,last_name) VALUES ('" + cell1 + "','"+ cell2 + "','"+ cell3 + "')";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				cmd.SelectCommand.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Supplier ADDED successfully !!");
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string cell1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			string cell2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			string cell3 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "UPDATE Supplier SET pseudo='"+cell1+"',name='"+cell2+"',last_name='"+cell3+"' WHERE pseudo ='"+cell1+"';";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				cmd.SelectCommand.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Supplier UPDATED successfully !!");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string cell1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				if(MessageBox.Show("Are you sure you want to delete <"+cell1+"> from the list ?","Confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					string query = "DELETE FROM SUPPLIER WHERE pseudo ='" + cell1 + "';";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					cmd.SelectCommand.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Supplier DELETED successfully !!");
				}
			}
		}

		private void searchBar_TextChanged(object sender, EventArgs e)
		{
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "SELECT * FROM Supplier WHERE pseudo LIKE('%"+searchBar.Text+ "%') OR last_name LIKE('%" + searchBar.Text + "%') OR name LIKE('%" + searchBar.Text + "%')";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				dt.Clear();
				cmd.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				if (MessageBox.Show("Are you sure you want to clear the list ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					string query = "DELETE FROM Supplier ;";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					cmd.SelectCommand.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("List CLEARED successfully !!");
				}
			}
		}
	}
}
