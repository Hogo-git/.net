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
	public partial class SellerFrom : Form
	{
		public SellerFrom()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programming\C#\C#_winform\project\Supermarket_Trinh\Supermarket_Trinh\Supmarketdb.mdf;Integrated Security=True");

		// ADD
		private void button4_Click_1(object sender, EventArgs e)
		{
				try
				{
					Con.Open();
					string query = "insert into SellerTbl values (" + Sid.Text + ", '" + Sname.Text + "'," + Sage.Text + ",'" + Sphone.Text + "','" + Spass.Text + "')";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Seller Added Successfully");
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
			string query = "select *  from SellerTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			SellerDGV.DataSource = ds.Tables[0];
			Con.Close();
		}
		// load data len from
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			populate();
		}

		// Material Textbox
		private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Sid.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
			Sname.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
			Sage.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
			Sphone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
			Spass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
		}

		// exit from
		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// delete
		private void button7_Click(object sender, EventArgs e)
		{

			try
			{
				if (Sid.Text == "")
				{
					MessageBox.Show("Select the Seller to Delete");
				}
				else
				{
					Con.Open();
					string query = "delete from SellerTbl where SellerId =" + Sid.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Seller Deleted Successfully");
					Con.Close();
					populate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Edit
		private void button6_Click(object sender, EventArgs e)
		{

			try
			{
				if (Sid.Text == "" || Sname.Text == "" || Sage.Text == "" || Sphone.Text == "" || Spass.Text == "")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "update SellerTbl set SellerName='" + Sname.Text + "', SellerAge=" + Sage.Text + ", SellerPhone='"+Sphone.Text+ "', SellerPass='"+Spass.Text+ "' where SellerId=" + Sid.Text + ";";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Seller Successfully Updated");
					Con.Close();
					populate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		// hiển thị from product
		private void button1_Click(object sender, EventArgs e)
		{
			ProductForm prod = new ProductForm();
			prod.Show();
			this.Hide();
		}

		// hiển thị from catgory
		private void button2_Click(object sender, EventArgs e)
		{
			CategoryFrom cat = new CategoryFrom();
			cat.Show();
			this.Hide();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			Form1 log = new Form1();
			log.Show();
			this.Hide();
		}
	}
}

