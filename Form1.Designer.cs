﻿namespace CarShopUI
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_make = new System.Windows.Forms.TextBox();
			this.txt_model = new System.Windows.Forms.TextBox();
			this.txt_price = new System.Windows.Forms.TextBox();
			this.btn_create_car = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lst_inventory = new System.Windows.Forms.ListBox();
			this.btn_addtocart = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lst_cart = new System.Windows.Forms.ListBox();
			this.btn_checkout = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_total = new System.Windows.Forms.Label();
			this.btn_reset = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_reset);
			this.groupBox1.Controls.Add(this.btn_create_car);
			this.groupBox1.Controls.Add(this.txt_price);
			this.groupBox1.Controls.Add(this.txt_model);
			this.groupBox1.Controls.Add(this.txt_make);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 287);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Create a Car:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Make:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Model:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price:";
			// 
			// txt_make
			// 
			this.txt_make.Location = new System.Drawing.Point(53, 40);
			this.txt_make.Name = "txt_make";
			this.txt_make.Size = new System.Drawing.Size(125, 20);
			this.txt_make.TabIndex = 3;
			// 
			// txt_model
			// 
			this.txt_model.Location = new System.Drawing.Point(53, 84);
			this.txt_model.Name = "txt_model";
			this.txt_model.Size = new System.Drawing.Size(125, 20);
			this.txt_model.TabIndex = 4;
			// 
			// txt_price
			// 
			this.txt_price.Location = new System.Drawing.Point(53, 130);
			this.txt_price.Name = "txt_price";
			this.txt_price.Size = new System.Drawing.Size(125, 20);
			this.txt_price.TabIndex = 5;
			// 
			// btn_create_car
			// 
			this.btn_create_car.Location = new System.Drawing.Point(84, 169);
			this.btn_create_car.Name = "btn_create_car";
			this.btn_create_car.Size = new System.Drawing.Size(75, 31);
			this.btn_create_car.TabIndex = 6;
			this.btn_create_car.Text = "Create a car";
			this.btn_create_car.UseVisualStyleBackColor = true;
			this.btn_create_car.Click += new System.EventHandler(this.btn_create_car_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lst_inventory);
			this.groupBox2.Location = new System.Drawing.Point(264, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 382);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Car Inventory:";
			// 
			// lst_inventory
			// 
			this.lst_inventory.FormattingEnabled = true;
			this.lst_inventory.Location = new System.Drawing.Point(7, 17);
			this.lst_inventory.Name = "lst_inventory";
			this.lst_inventory.Size = new System.Drawing.Size(187, 355);
			this.lst_inventory.TabIndex = 0;
			// 
			// btn_addtocart
			// 
			this.btn_addtocart.Location = new System.Drawing.Point(470, 140);
			this.btn_addtocart.Name = "btn_addtocart";
			this.btn_addtocart.Size = new System.Drawing.Size(100, 34);
			this.btn_addtocart.TabIndex = 2;
			this.btn_addtocart.Text = "Add to cart ->";
			this.btn_addtocart.UseVisualStyleBackColor = true;
			this.btn_addtocart.Click += new System.EventHandler(this.btn_addtocart_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lst_cart);
			this.groupBox3.Location = new System.Drawing.Point(576, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 287);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Shopping Cart:";
			// 
			// lst_cart
			// 
			this.lst_cart.FormattingEnabled = true;
			this.lst_cart.Location = new System.Drawing.Point(6, 19);
			this.lst_cart.Name = "lst_cart";
			this.lst_cart.Size = new System.Drawing.Size(188, 264);
			this.lst_cart.TabIndex = 0;
			// 
			// btn_checkout
			// 
			this.btn_checkout.Location = new System.Drawing.Point(639, 317);
			this.btn_checkout.Name = "btn_checkout";
			this.btn_checkout.Size = new System.Drawing.Size(75, 33);
			this.btn_checkout.TabIndex = 4;
			this.btn_checkout.Text = "Checkout";
			this.btn_checkout.UseVisualStyleBackColor = true;
			this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(576, 377);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Total Cost:";
			// 
			// lbl_total
			// 
			this.lbl_total.AutoSize = true;
			this.lbl_total.Location = new System.Drawing.Point(639, 376);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(28, 13);
			this.lbl_total.TabIndex = 6;
			this.lbl_total.Text = "0.00";
			this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Location = new System.Drawing.Point(84, 222);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(75, 23);
			this.btn_reset.TabIndex = 7;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbl_total);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_checkout);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btn_addtocart);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_create_car;
		private System.Windows.Forms.TextBox txt_price;
		private System.Windows.Forms.TextBox txt_model;
		private System.Windows.Forms.TextBox txt_make;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox lst_inventory;
		private System.Windows.Forms.Button btn_addtocart;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox lst_cart;
		private System.Windows.Forms.Button btn_checkout;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_total;
		private System.Windows.Forms.Button btn_reset;
	}
}

