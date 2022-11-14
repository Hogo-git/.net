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

namespace Supermarket_Trinh
{
	public partial class CategoryFrom : Form
	{
		public CategoryFrom()
		{
			InitializeComponent();
		}


		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programming\C#\C#_winform\project\Supermarket_Trinh\Supermarket_Trinh\Supmarketdb.mdf;Integrated Security=True");
		//add
		private void button4_Click(object sender, EventArgs e)

		{
			try
			{
				Con.Open();
				string query = "insert into CategoryTbl values (" + CatIdTb.Text + ", '" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Category Added Successfully");
				Con.Close();
				populate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);				
			}
		}

		//cho du lieu Datagrid view
		private void populate()
		{
			Con.Open();
			string query = "select *  from CategoryTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			CatDGV.DataSource = ds.Tables[0];
			Con.Close();
		}
		private void CategoryFrom_Load(object sender, EventArgs e)
		{
			populate();
		}
		// Material Textbox
		private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
			CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
			CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
		}

		//Delete
		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				if(CatIdTb.Text == "")
				{
					MessageBox.Show("Select the Category to Delete");
				}
				else
				{
					Con.Open();
					string query = "delete from CategoryTbl where Catd =" + CatIdTb.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Category Deleted Successfully");
					Con.Close();
					populate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		//Edit
		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				if(CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "update CategoryTbl set CatName='"+CatNameTb.Text+"', CatDesc='"+CatDescTb.Text+"' where Catd="+CatIdTb.Text+";";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Category Successfully Updated");
					Con.Close();
					populate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// hien thi from
		private void button2_Click(object sender, EventArgs e)
		{
			ProductForm  prod= new ProductForm();
			prod.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			SellerFrom seller = new SellerFrom();
			seller.Show();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 login = new Form1();
			login.Show();
		}	
	}
}
