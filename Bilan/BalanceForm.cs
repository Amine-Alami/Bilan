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
	public partial class BalanceForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bilan_local;Integrated Security=True");
		DataTable dtTake = new DataTable();
		DataTable dtBuy = new DataTable();
		public BalanceForm()
		{
			InitializeComponent();
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				///////////// Get the values ///////////////////////
				string queryTake = "SELECT amount FROM TakeMoney";
				SqlDataAdapter cmdTake = new SqlDataAdapter(queryTake, con);
				cmdTake.Fill(dtTake);
				

				string queryBuy = "SELECT price FROM Buy";
				SqlDataAdapter cmdBuy = new SqlDataAdapter(queryBuy, con);
				cmdBuy.Fill(dtBuy);
				///////////// Count ///////////////////////////////
				float IN = 0;
				float OUT = 0;

				for (int i = 0; i < dtTake.Rows.Count; i++)
				{
					IN = IN+ float.Parse(dtTake.Rows[i][0].ToString());
				}
				for (int i = 0; i < dtBuy.Rows.Count; i++)
				{
					OUT = OUT+float.Parse(dtBuy.Rows[i][0].ToString());
				}

				//foreach(DataRow dr in dtTake.Rows)
				//{
				//	IN =+ (float)dr["amount"];
				//}
				//foreach (DataRow dr in dtBuy.Rows)
				//{
				//	OUT =+ (float)dr["price"];
				//}
				///////////// Show ////////////////////////////////
				txtIN.Text = IN.ToString()+" DH";
				txtOut.Text = OUT.ToString() + " DH";
				txtReste.Text = (IN - OUT).ToString() + " DH";
			}
			con.Close();
		}
	}
}
