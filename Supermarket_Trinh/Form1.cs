using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Trinh
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static string Sellername = "";
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programming\C#\C#_winform\project\Supermarket_Trinh\Supermarket_Trinh\Supmarketdb.mdf;Integrated Security=True");

		private void label8_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			UnameTb.Text = "";
			PassTb.Text = "";
		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			if(UnameTb.Text =="" || PassTb.Text == "")
			{
				MessageBox.Show("Enter the UserName and Password");
			}
			else
			{
				if (RoleCb.SelectedIndex > -1)
				{

					if (RoleCb.SelectedItem.ToString() == "ADMIN")
					{
						if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
						{
							ProductForm prod = new ProductForm();
							prod.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("If you are the Admin, Enter the correct Id and password");
						}
					}
					else
					{
						//MessageBox.Show("Your in the sller section");
						Con.Open();
						SqlDataAdapter sda = new SqlDataAdapter("select count(8) from SellerTbl where SellerName = '"+UnameTb.Text+"' and SellerPass='"+PassTb.Text+"'", Con);
						DataTable dt = new DataTable();
						sda.Fill(dt);
						if(dt.Rows[0][0].ToString() == "1")
						{
							Sellername = UnameTb.Text;
							SellingFrom sell = new SellingFrom();
							sell.Show();
							this.Hide();
							Con.Close();
						}
						else
						{
							MessageBox.Show("Wrong UserName or Password");
						}
						Con.Close();
					}
				}
				else
				{
					MessageBox.Show("Select a Role");
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}

