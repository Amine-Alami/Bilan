namespace Bilan
{
	partial class BuyNewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyNewForm));
			this.btnClear = new System.Windows.Forms.Button();
			this.btnBuy = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
			this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(404, 482);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(61, 65);
			this.btnClear.TabIndex = 21;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnBuy
			// 
			this.btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
			this.btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnBuy.FlatAppearance.BorderSize = 0;
			this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuy.Location = new System.Drawing.Point(484, 482);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(72, 65);
			this.btnBuy.TabIndex = 20;
			this.btnBuy.UseVisualStyleBackColor = true;
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(281, 368);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(271, 35);
			this.dateTimePicker1.TabIndex = 19;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(166, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(246, 105);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(285, 174);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(271, 35);
			this.textBox1.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 376);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(213, 25);
			this.label3.TabIndex = 14;
			this.label3.Text = "Date of the operation";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 282);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 25);
			this.label1.TabIndex = 15;
			this.label1.Text = "Price";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(285, 272);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(271, 35);
			this.textBox2.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(206, 25);
			this.label4.TabIndex = 22;
			this.label4.Text = "Name of the product";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// BuyNewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 559);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnBuy);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BuyNewForm";
			this.Text = "BuyNewForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnBuy;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
	}
}