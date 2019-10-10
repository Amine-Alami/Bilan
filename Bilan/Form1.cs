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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			costumizeDesign();
			MaximizeBox = false;
		}

		private void costumizeDesign()
		{
			//panelSupp.Visible = false;
			panelTake.Visible = false;
			panelBuy.Visible = false;
		}

		private void hideSubMenu()
		{
			//if(panelSupp.Visible == true)
			//	panelSupp.Visible = false;
			if(panelTake.Visible == true)
				panelTake.Visible = false;
			if(panelBuy.Visible == true)
				panelBuy.Visible = false;
		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
				
		}

		////////////////////////////////// Button Supplier /////////////////////////////////////
		private void btnSupplier_Click(object sender, EventArgs e)
		{
			openChildForm(new SuppForm());
			hideSubMenu();
		}

		////////////////////////////////// Button Take ////////////////////////////////////////
		private void btnTake_Click(object sender, EventArgs e)
		{
			showSubMenu(panelTake);
		}
		#region Panel Take

		private void btnNewTake_Click(object sender, EventArgs e)
		{
			openChildForm(new TakeNewForm());
			// write your code above
			hideSubMenu();
		}

		private void btnListTake_Click(object sender, EventArgs e)
		{

			openChildForm(new TakeListForm());
			// write your code above
			hideSubMenu();
		}
		#endregion

		////////////////////////////////// Button Buy /////////////////////////////////////////
		private void btnBuy_Click(object sender, EventArgs e)
		{
			showSubMenu(panelBuy);
		}
		#region Panel Buy

		private void btnNewBuy_Click(object sender, EventArgs e)
		{

			openChildForm(new BuyNewForm());
			// write your code above
			hideSubMenu();
		}

		private void btnListBuy_Click(object sender, EventArgs e)
		{

			openChildForm(new BuyListForm());
			// write your code above
			hideSubMenu();
		}
		#endregion

		////////////////////////////////// Button Balance /////////////////////////////////////
		private void btnbalance_Click(object sender, EventArgs e)
		{
			openChildForm(new BalanceForm());
			hideSubMenu();
		}
		private void Form1_Load(object sender, EventArgs e){}

		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelMain.Controls.Add(childForm);
			panelMain.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		
	}
}
