namespace Bilan
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnSupplier = new System.Windows.Forms.Button();
			this.panelSupp = new System.Windows.Forms.Panel();
			this.btnListSupp = new System.Windows.Forms.Button();
			this.btnNewSupp = new System.Windows.Forms.Button();
			this.btnbalance = new System.Windows.Forms.Button();
			this.panelBuy = new System.Windows.Forms.Panel();
			this.btnListBuy = new System.Windows.Forms.Button();
			this.btnNewBuy = new System.Windows.Forms.Button();
			this.btnBuy = new System.Windows.Forms.Button();
			this.panelTake = new System.Windows.Forms.Panel();
			this.btnListTake = new System.Windows.Forms.Button();
			this.btnNewTake = new System.Windows.Forms.Button();
			this.btnTake = new System.Windows.Forms.Button();
			this.panelMenu.SuspendLayout();
			this.panelSupp.SuspendLayout();
			this.panelBuy.SuspendLayout();
			this.panelTake.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.AutoScroll = true;
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
			this.panelMenu.Controls.Add(this.btnbalance);
			this.panelMenu.Controls.Add(this.panelBuy);
			this.panelMenu.Controls.Add(this.btnBuy);
			this.panelMenu.Controls.Add(this.panelTake);
			this.panelMenu.Controls.Add(this.btnTake);
			this.panelMenu.Controls.Add(this.panelSupp);
			this.panelMenu.Controls.Add(this.btnSupplier);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(200, 559);
			this.panelMenu.TabIndex = 0;
			// 
			// panelLogo
			// 
			this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
			this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(200, 100);
			this.panelLogo.TabIndex = 0;
			this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
			this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
			// 
			// panelMain
			// 
			this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
			this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(200, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(604, 559);
			this.panelMain.TabIndex = 1;
			// 
			// btnSupplier
			// 
			this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSupplier.FlatAppearance.BorderSize = 0;
			this.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
			this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSupplier.Location = new System.Drawing.Point(0, 100);
			this.btnSupplier.Name = "btnSupplier";
			this.btnSupplier.Size = new System.Drawing.Size(200, 45);
			this.btnSupplier.TabIndex = 1;
			this.btnSupplier.Text = "          Suppliers";
			this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSupplier.UseVisualStyleBackColor = true;
			this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
			// 
			// panelSupp
			// 
			this.panelSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
			this.panelSupp.Controls.Add(this.btnListSupp);
			this.panelSupp.Controls.Add(this.btnNewSupp);
			this.panelSupp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSupp.Location = new System.Drawing.Point(0, 145);
			this.panelSupp.Name = "panelSupp";
			this.panelSupp.Size = new System.Drawing.Size(200, 73);
			this.panelSupp.TabIndex = 5;
			// 
			// btnListSupp
			// 
			this.btnListSupp.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListSupp.FlatAppearance.BorderSize = 0;
			this.btnListSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnListSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnListSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnListSupp.Image")));
			this.btnListSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListSupp.Location = new System.Drawing.Point(0, 36);
			this.btnListSupp.Name = "btnListSupp";
			this.btnListSupp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnListSupp.Size = new System.Drawing.Size(200, 36);
			this.btnListSupp.TabIndex = 5;
			this.btnListSupp.Text = "      List";
			this.btnListSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListSupp.UseVisualStyleBackColor = true;
			this.btnListSupp.Click += new System.EventHandler(this.btnListSupp_Click);
			// 
			// btnNewSupp
			// 
			this.btnNewSupp.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNewSupp.FlatAppearance.BorderSize = 0;
			this.btnNewSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnNewSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnNewSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSupp.Image")));
			this.btnNewSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNewSupp.Location = new System.Drawing.Point(0, 0);
			this.btnNewSupp.Name = "btnNewSupp";
			this.btnNewSupp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this.btnNewSupp.Size = new System.Drawing.Size(200, 36);
			this.btnNewSupp.TabIndex = 2;
			this.btnNewSupp.Text = "       New";
			this.btnNewSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNewSupp.UseVisualStyleBackColor = true;
			this.btnNewSupp.Click += new System.EventHandler(this.btnNewSupp_Click);
			// 
			// btnbalance
			// 
			this.btnbalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnbalance.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnbalance.FlatAppearance.BorderSize = 0;
			this.btnbalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnbalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnbalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnbalance.Image = ((System.Drawing.Image)(resources.GetObject("btnbalance.Image")));
			this.btnbalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnbalance.Location = new System.Drawing.Point(0, 452);
			this.btnbalance.Name = "btnbalance";
			this.btnbalance.Size = new System.Drawing.Size(200, 45);
			this.btnbalance.TabIndex = 12;
			this.btnbalance.Text = "         Balance";
			this.btnbalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnbalance.UseVisualStyleBackColor = true;
			this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
			// 
			// panelBuy
			// 
			this.panelBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
			this.panelBuy.Controls.Add(this.btnListBuy);
			this.panelBuy.Controls.Add(this.btnNewBuy);
			this.panelBuy.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBuy.Location = new System.Drawing.Point(0, 381);
			this.panelBuy.Name = "panelBuy";
			this.panelBuy.Size = new System.Drawing.Size(200, 71);
			this.panelBuy.TabIndex = 11;
			this.panelBuy.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBuy_Paint);
			// 
			// btnListBuy
			// 
			this.btnListBuy.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListBuy.FlatAppearance.BorderSize = 0;
			this.btnListBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnListBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnListBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnListBuy.Image")));
			this.btnListBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListBuy.Location = new System.Drawing.Point(0, 36);
			this.btnListBuy.Name = "btnListBuy";
			this.btnListBuy.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnListBuy.Size = new System.Drawing.Size(200, 36);
			this.btnListBuy.TabIndex = 5;
			this.btnListBuy.Text = "      List";
			this.btnListBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListBuy.UseVisualStyleBackColor = true;
			this.btnListBuy.Click += new System.EventHandler(this.btnListBuy_Click);
			// 
			// btnNewBuy
			// 
			this.btnNewBuy.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNewBuy.FlatAppearance.BorderSize = 0;
			this.btnNewBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnNewBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnNewBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBuy.Image")));
			this.btnNewBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNewBuy.Location = new System.Drawing.Point(0, 0);
			this.btnNewBuy.Name = "btnNewBuy";
			this.btnNewBuy.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this.btnNewBuy.Size = new System.Drawing.Size(200, 36);
			this.btnNewBuy.TabIndex = 2;
			this.btnNewBuy.Text = "       New";
			this.btnNewBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNewBuy.UseVisualStyleBackColor = true;
			this.btnNewBuy.Click += new System.EventHandler(this.btnNewBuy_Click);
			// 
			// btnBuy
			// 
			this.btnBuy.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBuy.FlatAppearance.BorderSize = 0;
			this.btnBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnBuy.Image")));
			this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuy.Location = new System.Drawing.Point(0, 336);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(200, 45);
			this.btnBuy.TabIndex = 10;
			this.btnBuy.Text = "          Buy";
			this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuy.UseVisualStyleBackColor = true;
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// panelTake
			// 
			this.panelTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
			this.panelTake.Controls.Add(this.btnListTake);
			this.panelTake.Controls.Add(this.btnNewTake);
			this.panelTake.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTake.Location = new System.Drawing.Point(0, 263);
			this.panelTake.Name = "panelTake";
			this.panelTake.Size = new System.Drawing.Size(200, 73);
			this.panelTake.TabIndex = 9;
			this.panelTake.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTake_Paint);
			// 
			// btnListTake
			// 
			this.btnListTake.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListTake.FlatAppearance.BorderSize = 0;
			this.btnListTake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnListTake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnListTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListTake.Image = ((System.Drawing.Image)(resources.GetObject("btnListTake.Image")));
			this.btnListTake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListTake.Location = new System.Drawing.Point(0, 36);
			this.btnListTake.Name = "btnListTake";
			this.btnListTake.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnListTake.Size = new System.Drawing.Size(200, 36);
			this.btnListTake.TabIndex = 5;
			this.btnListTake.Text = "      List";
			this.btnListTake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListTake.UseVisualStyleBackColor = true;
			this.btnListTake.Click += new System.EventHandler(this.btnListTake_Click);
			// 
			// btnNewTake
			// 
			this.btnNewTake.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNewTake.FlatAppearance.BorderSize = 0;
			this.btnNewTake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnNewTake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnNewTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewTake.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTake.Image")));
			this.btnNewTake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNewTake.Location = new System.Drawing.Point(0, 0);
			this.btnNewTake.Name = "btnNewTake";
			this.btnNewTake.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this.btnNewTake.Size = new System.Drawing.Size(200, 36);
			this.btnNewTake.TabIndex = 2;
			this.btnNewTake.Text = "       New";
			this.btnNewTake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNewTake.UseVisualStyleBackColor = true;
			this.btnNewTake.Click += new System.EventHandler(this.btnNewTake_Click);
			// 
			// btnTake
			// 
			this.btnTake.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTake.FlatAppearance.BorderSize = 0;
			this.btnTake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.btnTake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTake.Image = ((System.Drawing.Image)(resources.GetObject("btnTake.Image")));
			this.btnTake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTake.Location = new System.Drawing.Point(0, 218);
			this.btnTake.Name = "btnTake";
			this.btnTake.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnTake.Size = new System.Drawing.Size(200, 45);
			this.btnTake.TabIndex = 8;
			this.btnTake.Text = "         Take";
			this.btnTake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTake.UseVisualStyleBackColor = true;
			this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 559);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(820, 598);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Welcome To Your Balance Sheet";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelSupp.ResumeLayout(false);
			this.panelBuy.ResumeLayout(false);
			this.panelTake.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button btnSupplier;
		private System.Windows.Forms.Button btnbalance;
		private System.Windows.Forms.Panel panelBuy;
		private System.Windows.Forms.Button btnListBuy;
		private System.Windows.Forms.Button btnNewBuy;
		private System.Windows.Forms.Button btnBuy;
		private System.Windows.Forms.Panel panelTake;
		private System.Windows.Forms.Button btnListTake;
		private System.Windows.Forms.Button btnNewTake;
		private System.Windows.Forms.Button btnTake;
		private System.Windows.Forms.Panel panelSupp;
		private System.Windows.Forms.Button btnListSupp;
		private System.Windows.Forms.Button btnNewSupp;
	}
}

