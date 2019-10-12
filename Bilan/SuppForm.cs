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
using Microsoft.VisualBasic;

namespace Bilan
{
	public partial class SuppForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bilan_local;Integrated Security=True");
		DataTable dt = new DataTable();
		public SuppForm()
		{
			try{ }catch{ MessageBox.Show(""); }
			InitializeComponent();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "SELECT * FROM Supplier";
				SqlDataAdapter cmd = new SqlDataAdapter(query, con);
				
				cmd.Fill(dt);
				dataGridView1.DataSource = dt;
				
			}
			con.Close();
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
				
				MessageBox.Show("Supplier ADDED successfully !!");
			}
			con.Close();
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
				
				MessageBox.Show("Supplier UPDATED successfully !!");
			}
			con.Close();
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
					
					MessageBox.Show("Supplier DELETED successfully !!");
				}
			}
			con.Close();
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
						string query = "DELETE FROM Supplier ;";
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
	}
}
