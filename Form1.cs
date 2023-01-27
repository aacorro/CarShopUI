﻿using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopUI
{
	public partial class Form1 : Form
	{
		Store myStore = new Store();
		BindingSource carInventoryBindingSource = new BindingSource();
		BindingSource cartBindingSource = new BindingSource();

		public Form1()
		{
			InitializeComponent();
		}

		private void btn_create_car_Click(object sender, EventArgs e)
		{
			Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
			
			myStore.CarList.Add(c);
			carInventoryBindingSource.ResetBindings(false);
			txt_make.ResetText();
			txt_model.ResetText();
			txt_price.ResetText();

		}

		private void btn_addtocart_Click(object sender, EventArgs e)
		{
			//get the selected item from inventory
			Car selected = lst_inventory.SelectedItem as Car;

			//add that item to the cart
			myStore.ShoppingList.Add(selected);

			//update the list box control
			cartBindingSource.ResetBindings(false);
		}

		private void btn_checkout_Click(object sender, EventArgs e)
		{
			decimal total = myStore.Checkout();
			lbl_total.Text = "$" + total.ToString();

			cartBindingSource.ResetBindings(false);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			carInventoryBindingSource.DataSource = myStore.CarList;
			cartBindingSource.DataSource = myStore.ShoppingList;


			lst_inventory.DataSource = carInventoryBindingSource;
			lst_inventory.DisplayMember = ToString();

			lst_cart.DataSource = cartBindingSource;
			lst_cart.DisplayMember = ToString();
		}

		private void lbl_total_Click(object sender, EventArgs e)
		{

		}

		private void btn_reset_Click(object sender, EventArgs e)
		{
			txt_make.ResetText();
			txt_price.ResetText();
			txt_model.ResetText();

			
			lbl_total.ResetText();
		}
	}
}
