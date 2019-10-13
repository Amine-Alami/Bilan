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
using Microsoft.VisualBasic;

namespace Bilan
{
	public partial class TakeListForm : Form
	{
		
		SqlConnection con = new SqlConnection(@"Data Source=AMINE-LAPTOP\SQLEXPRESS;Initial Catalog=Bilan;Integrated Security=True"); DataTable dt = new DataTable();
		public TakeListForm()
		{
			InitializeComponent();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "SELECT * FROM TakeMoney";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);

				cmd.Fill(dt);
				dataGridView1.DataSource = dt;
				dataGridView1.Columns[0].ReadOnly = true;
				dataGridView1.AllowUserToAddRows = false;
			}
			con.Close();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string cell1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			string cell2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			string cell3 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			string cell4 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "UPDATE TakeMoney SET pseudo='" + cell2 + "',amount='" + cell3 + "',date_Op='" + cell4 + "' WHERE id ='" + cell1 + "';";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				cmd.SelectCommand.ExecuteNonQuery();
				
				MessageBox.Show("Operation UPDATED successfully !!");
			}
			con.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string cell1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				if (MessageBox.Show("Are you sure you want to delete <" + cell1 + "> from the list ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					string query = "DELETE FROM TakeMoney WHERE id ='" + cell1 + "';";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					cmd.SelectCommand.ExecuteNonQuery();
					
					MessageBox.Show("Operation DELETED successfully !!");
				}
			}
			con.Close();
		}

		private void searchBar_TextChanged(object sender, EventArgs e)
		{
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				
				if (radioButton1.Checked)
				{
					string query = "SELECT * FROM TakeMoney WHERE pseudo LIKE('%" + searchBar.Text + "%')";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					dt.Clear();
					cmd.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				else if (radioButton2.Checked)
				{
					string query = "SELECT * FROM TakeMoney WHERE amount LIKE('%" + searchBar.Text + "%')";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					dt.Clear();
					cmd.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				else if (radioButton3.Checked)
				{
					string query = "SELECT * FROM TakeMoney WHERE date_Op LIKE('%" + searchBar.Text + "%')";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					dt.Clear();
					cmd.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				else
				{
					string query = "SELECT * FROM TakeMoney WHERE pseudo LIKE('%" + searchBar.Text + "%') OR amount LIKE('%" + searchBar.Text + "%') OR date_Op LIKE('%" + searchBar.Text + "%')";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					dt.Clear();
					cmd.Fill(dt);
					dataGridView1.DataSource = dt;
				}

			}
			con.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				if (MessageBox.Show("Are you sure you want to clear the list ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					string pass = Interaction.InputBox("Please confirm your password", "Confirmation", "", -1, -1);
					if(pass == "liberta007")
					{
						string query = "DELETE FROM TakeMoney ;";
						SqlDataAdapter cmd = new SqlDataAdapter(query, con);
						cmd.SelectCommand.ExecuteNonQuery();
						MessageBox.Show("List CLEARED successfully !!");
					}
				}
			}
			con.Close();
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (MessageBox.Show("Do you want to save those changes ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				btnEdit_Click(this, new EventArgs());
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			searchBar.Focus();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			searchBar.Focus();
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			searchBar.Focus();
		}
	}
}
