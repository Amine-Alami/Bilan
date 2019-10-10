﻿using System;
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
	public partial class BuyListForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=AMINE-LAPTOP\SQLEXPRESS;Initial Catalog=Bilan;Integrated Security=True");
		DataTable dt = new DataTable();
		public BuyListForm()
		{
			InitializeComponent();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "SELECT * FROM Buy";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);

				cmd.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
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
				string query = "UPDATE Buy SET product='" + cell2 + "',price='" + cell3 + "',date_pr='" + cell4 + "' WHERE id ='" + cell1 + "';";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				cmd.SelectCommand.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Operation UPDATED successfully !!");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string cell1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				if (MessageBox.Show("Are you sure you want to delete <" + cell1 + "> from the list ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					string query = "DELETE FROM Buy WHERE id ='" + cell1 + "';";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					cmd.SelectCommand.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Operation DELETED successfully !!");
				}
			}
		}

		private void searchBar_TextChanged(object sender, EventArgs e)
		{
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "SELECT * FROM buy WHERE product LIKE('%" + searchBar.Text + "%') OR price LIKE('%" + searchBar.Text + "%') OR date_pr LIKE('%" + searchBar.Text + "%')";
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
					string query = "DELETE FROM Buy ;";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					cmd.SelectCommand.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("List CLEARED successfully !!");
				}
			}
		}
	}
}
