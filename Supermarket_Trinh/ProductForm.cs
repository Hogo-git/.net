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
	public partial class ProductForm : Form
	{
		public ProductForm()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programming\C#\C#_winform\project\Supermarket_Trinh\Supermarket_Trinh\Supmarketdb.mdf;Integrated Security=True");

		// exit from
		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// this method will bind the combobox with the databases
		//Combobox
		private void fillcombo()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
			SqlDataReader rdr;
			rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("CatName", typeof(string));
			dt.Load(rdr);
			CatCb.ValueMember = "catName";
			CatCb.DataSource = dt;
			SearchCb.ValueMember = "catName";
			SearchCb.DataSource = dt;
			Con.Close();

		}

		private void ProductForm_Load(object sender, EventArgs e)
		{
			fillcombo();
			populate();
		}

		// hiển thị from 
		private void button2_Click(object sender, EventArgs e)
		{
			CategoryFrom cat = new CategoryFrom();
			cat.Show();
			this.Hide();
		}

		private void populate()
		{
			Con.Open();
			string query = "select *  from ProductTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV.DataSource = ds.Tables[0];
			Con.Close();
		}

		//add
		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				string query = "insert into ProductTbl values (" + ProdId.Text + ", '" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPice.Text + ",'" + CatCb.SelectedValue.ToString() + "')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Product Added Successfully");
				Con.Close();
				populate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
			ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
			ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
			ProdPice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
			CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
		}

		//delete
		private void button7_Click(object sender, EventArgs e)
		{

			try
			{
				if (ProdId.Text == "")
				{
					MessageBox.Show("Select the Product to Delete");
				}
				else
				{
					Con.Open();
					string query = "delete from ProductTbl where ProdId =" + ProdId.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Product Deleted Successfully");
					Con.Close();
					populate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			populate();
		}

		//Edit
		private void button6_Click(object sender, EventArgs e)
		{

			try
			{
				if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPice.Text == "")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "update ProductTbl set ProdName='" + ProdName.Text + "', ProdQty=" + ProdQty.Text + ", ProdPice=" + ProdPice.Text + " where ProdId=" + ProdId.Text + ";";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("ProductTbl Successfully Updated");
					Con.Close();
					populate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	SellerFrom Sel = new SellerFrom();
		//	Sel.Show();
		//	this.Hide();
		//}

		private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Con.Open();
			string query = "select * from ProductTbl where ProdCat ='" + SearchCb.SelectedValue.ToString() + "'";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV.DataSource = ds.Tables[0];		
			Con.Close();

		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 login = new Form1();
			login.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			SellerFrom seller = new SellerFrom();
			seller.Show();
		}
	}
}
