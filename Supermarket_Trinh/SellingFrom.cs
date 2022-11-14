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
	public partial class SellingFrom : Form
	{
		public SellingFrom()
		{
			InitializeComponent();
		}

		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programming\C#\C#_winform\project\Supermarket_Trinh\Supermarket_Trinh\Supmarketdb.mdf;Integrated Security=True");

		private void populate()
		{
			Con.Open();
			string query = "select ProdName, ProdQty  from ProductTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV1.DataSource = ds.Tables[0];
			Con.Close();
		}
		private void populatebills()
		{
			Con.Open();
			string query = "select * from BillTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			BillsDGV.DataSource = ds.Tables[0];
			Con.Close();
		}
		private void SellingFrom_Load(object sender, EventArgs e)
		{
			populate();
			populatebills();
			fillcombo();
			SellerNamelbl.Text = Form1.Sellername;
		}

		
		private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
			ProdPrice.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() ;
		}

		int Grdtoral = 0, n = 0;

		private void button4_Click(object sender, EventArgs e)
		{
			if(BillID.Text == "")
			{
				MessageBox.Show("Missing Bill Id");
			}
			else
			{
				try
				{
					Con.Open();
					string query = "insert into BillTbl values (" + BillID.Text + ", '" + SellerNamelbl.Text + "','" + Datelbl.Text + "'," + Amtlbl.Text + ")";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Oder Added Successfully");
					Con.Close();
					populatebills();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("FAMILYSUPERMAKET", new Font("Century Gothic",25, FontStyle.Bold),Brushes.Red, new Point(230));
			e.Graphics.DrawString("Bill ID:"+BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic",20, FontStyle.Bold),Brushes.Blue, new Point(100, 70));
			e.Graphics.DrawString("Seller Name:"+BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic",20, FontStyle.Bold),Brushes.Blue, new Point(100, 110));
			e.Graphics.DrawString("Date:"+BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic",20, FontStyle.Bold),Brushes.Blue, new Point(100, 150));
			e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 190));
			e.Graphics.DrawString("TRÌNH DZ", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(360, 230));

		}

		private void button8_Click(object sender, EventArgs e)
		{
			populate();
		}

		private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Con.Open();
			string query = "select ProdName, ProdQty  from ProductTbl where ProdCat ='" + SearchCb.SelectedValue.ToString() + "'";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV1.DataSource = ds.Tables[0];
			Con.Close();
		}

		private void fillcombo()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
			SqlDataReader rdr;
			rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("CatName", typeof(string));
			dt.Load(rdr);
			//CatCb.ValueMember = "catName";
			//CatCb.DataSource = dt;
			SearchCb.ValueMember = "catName";
			SearchCb.DataSource = dt;
			Con.Close();

		}

		private void label6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 login = new Form1();
			login.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ProductForm product = new ProductForm();
			product.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CategoryFrom cat = new CategoryFrom();
			cat.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(ProdName.Text == "" || ProdQty.Text == "")
			{
				MessageBox.Show("Missing Data");
			}
			else
			{
				int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text); ;
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(ORDERDGV);
				newRow.Cells[0].Value = n + 1;
				newRow.Cells[1].Value = ProdName.Text;
				newRow.Cells[2].Value = ProdPrice.Text;
				newRow.Cells[3].Value = ProdQty.Text;
				newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
				ORDERDGV.Rows.Add(newRow);
				n++;
				Grdtoral = Grdtoral + total;
				Amtlbl.Text = " " + Grdtoral;
			}
		}
	}
}
