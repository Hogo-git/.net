namespace Supermarket_Trinh
{
	partial class SellingFrom
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingFrom));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.ORDERDGV = new Guna.UI.WinForms.GunaDataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amtlbl = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SellerNamelbl = new System.Windows.Forms.Label();
			this.ProdPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label8 = new System.Windows.Forms.Label();
			this.ProdDGV1 = new Guna.UI.WinForms.GunaDataGridView();
			this.Datelbl = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.SearchCb = new System.Windows.Forms.ComboBox();
			this.BillsDGV = new Guna.UI.WinForms.GunaDataGridView();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.ProdQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.ProdName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label3 = new System.Windows.Forms.Label();
			this.BillID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOrange;
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.ORDERDGV);
			this.panel1.Controls.Add(this.Amtlbl);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.SellerNamelbl);
			this.panel1.Controls.Add(this.ProdPrice);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.ProdDGV1);
			this.panel1.Controls.Add(this.Datelbl);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.SearchCb);
			this.panel1.Controls.Add(this.BillsDGV);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.ProdQty);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ProdName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.BillID);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(170, 11);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1373, 802);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(819, 419);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 34);
			this.label7.TabIndex = 25;
			this.label7.Text = "SELLS LIST";
			// 
			// ORDERDGV
			// 
			dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
			this.ORDERDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ORDERDGV.BackgroundColor = System.Drawing.Color.White;
			this.ORDERDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ORDERDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ORDERDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ORDERDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
			this.ORDERDGV.ColumnHeadersHeight = 30;
			this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
			dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ORDERDGV.DefaultCellStyle = dataGridViewCellStyle30;
			this.ORDERDGV.EnableHeadersVisualStyles = false;
			this.ORDERDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ORDERDGV.Location = new System.Drawing.Point(461, 103);
			this.ORDERDGV.Name = "ORDERDGV";
			this.ORDERDGV.RowHeadersVisible = false;
			this.ORDERDGV.RowTemplate.Height = 24;
			this.ORDERDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ORDERDGV.Size = new System.Drawing.Size(896, 237);
			this.ORDERDGV.TabIndex = 24;
			this.ORDERDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ORDERDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ORDERDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ORDERDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ORDERDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.ORDERDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ORDERDGV.ThemeStyle.HeaderStyle.Height = 30;
			this.ORDERDGV.ThemeStyle.ReadOnly = false;
			this.ORDERDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ORDERDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.ORDERDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ORDERDGV.ThemeStyle.RowsStyle.Height = 24;
			this.ORDERDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ORDERDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// id
			// 
			this.id.HeaderText = "ProdId";
			this.id.Name = "id";
			// 
			// PName
			// 
			this.PName.HeaderText = "ProdName";
			this.PName.Name = "PName";
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			// 
			// Amtlbl
			// 
			this.Amtlbl.AutoSize = true;
			this.Amtlbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
			this.Amtlbl.ForeColor = System.Drawing.Color.White;
			this.Amtlbl.Location = new System.Drawing.Point(969, 355);
			this.Amtlbl.Name = "Amtlbl";
			this.Amtlbl.Size = new System.Drawing.Size(43, 34);
			this.Amtlbl.TabIndex = 23;
			this.Amtlbl.Text = "Rs";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(775, 355);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 34);
			this.label5.TabIndex = 22;
			this.label5.Text = "Amount Rs";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.DarkOrange;
			this.button1.Location = new System.Drawing.Point(126, 291);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 35);
			this.button1.TabIndex = 21;
			this.button1.Text = "Add Product";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SellerNamelbl
			// 
			this.SellerNamelbl.AutoSize = true;
			this.SellerNamelbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SellerNamelbl.ForeColor = System.Drawing.Color.White;
			this.SellerNamelbl.Location = new System.Drawing.Point(75, 20);
			this.SellerNamelbl.Name = "SellerNamelbl";
			this.SellerNamelbl.Size = new System.Drawing.Size(74, 28);
			this.SellerNamelbl.TabIndex = 20;
			this.SellerNamelbl.Text = "Seller";
			// 
			// ProdPrice
			// 
			this.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdPrice.Enabled = false;
			this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdPrice.HintForeColor = System.Drawing.Color.Empty;
			this.ProdPrice.HintText = "";
			this.ProdPrice.isPassword = false;
			this.ProdPrice.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPrice.LineIdleColor = System.Drawing.Color.White;
			this.ProdPrice.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPrice.LineThickness = 3;
			this.ProdPrice.Location = new System.Drawing.Point(126, 193);
			this.ProdPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdPrice.Name = "ProdPrice";
			this.ProdPrice.Size = new System.Drawing.Size(202, 30);
			this.ProdPrice.TabIndex = 19;
			this.ProdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(6, 200);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Price";
			// 
			// ProdDGV1
			// 
			dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
			this.ProdDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ProdDGV1.BackgroundColor = System.Drawing.Color.White;
			this.ProdDGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ProdDGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ProdDGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle32.BackColor = System.Drawing.Color.OrangeRed;
			dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProdDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
			this.ProdDGV1.ColumnHeadersHeight = 30;
			dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProdDGV1.DefaultCellStyle = dataGridViewCellStyle33;
			this.ProdDGV1.EnableHeadersVisualStyles = false;
			this.ProdDGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV1.Location = new System.Drawing.Point(10, 381);
			this.ProdDGV1.Name = "ProdDGV1";
			this.ProdDGV1.RowHeadersVisible = false;
			this.ProdDGV1.RowTemplate.Height = 24;
			this.ProdDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProdDGV1.Size = new System.Drawing.Size(320, 404);
			this.ProdDGV1.TabIndex = 17;
			this.ProdDGV1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ProdDGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ProdDGV1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
			this.ProdDGV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ProdDGV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.ProdDGV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ProdDGV1.ThemeStyle.HeaderStyle.Height = 30;
			this.ProdDGV1.ThemeStyle.ReadOnly = false;
			this.ProdDGV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ProdDGV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdDGV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV1.ThemeStyle.RowsStyle.Height = 24;
			this.ProdDGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
			// 
			// Datelbl
			// 
			this.Datelbl.AutoSize = true;
			this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Datelbl.ForeColor = System.Drawing.Color.White;
			this.Datelbl.Location = new System.Drawing.Point(1209, 27);
			this.Datelbl.Name = "Datelbl";
			this.Datelbl.Size = new System.Drawing.Size(67, 28);
			this.Datelbl.TabIndex = 16;
			this.Datelbl.Text = "Date";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.White;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.DarkOrange;
			this.button8.Location = new System.Drawing.Point(226, 332);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(104, 35);
			this.button8.TabIndex = 15;
			this.button8.Text = "Refresh";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// SearchCb
			// 
			this.SearchCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchCb.ForeColor = System.Drawing.Color.DarkOrange;
			this.SearchCb.FormattingEnabled = true;
			this.SearchCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.SearchCb.Location = new System.Drawing.Point(10, 332);
			this.SearchCb.Name = "SearchCb";
			this.SearchCb.Size = new System.Drawing.Size(210, 31);
			this.SearchCb.TabIndex = 14;
			this.SearchCb.Text = "Select Category";
			this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.SearchCb_SelectionChangeCommitted);
			// 
			// BillsDGV
			// 
			dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
			this.BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
			this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
			this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.BillsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
			this.BillsDGV.ColumnHeadersHeight = 30;
			dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle36;
			this.BillsDGV.EnableHeadersVisualStyles = false;
			this.BillsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.BillsDGV.Location = new System.Drawing.Point(377, 462);
			this.BillsDGV.Name = "BillsDGV";
			this.BillsDGV.RowHeadersVisible = false;
			this.BillsDGV.RowTemplate.Height = 24;
			this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.BillsDGV.Size = new System.Drawing.Size(980, 264);
			this.BillsDGV.TabIndex = 13;
			this.BillsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.BillsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.BillsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.BillsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.BillsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.BillsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.BillsDGV.ThemeStyle.HeaderStyle.Height = 30;
			this.BillsDGV.ThemeStyle.ReadOnly = false;
			this.BillsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.BillsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.BillsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.BillsDGV.ThemeStyle.RowsStyle.Height = 24;
			this.BillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.BillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.White;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.DarkOrange;
			this.button6.Location = new System.Drawing.Point(966, 747);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(100, 38);
			this.button6.TabIndex = 11;
			this.button6.Text = "PRINT";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.DarkOrange;
			this.button4.Location = new System.Drawing.Point(747, 747);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 38);
			this.button4.TabIndex = 4;
			this.button4.Text = "ADD";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// ProdQty
			// 
			this.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdQty.HintForeColor = System.Drawing.Color.Empty;
			this.ProdQty.HintText = "";
			this.ProdQty.isPassword = false;
			this.ProdQty.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdQty.LineIdleColor = System.Drawing.Color.White;
			this.ProdQty.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdQty.LineThickness = 3;
			this.ProdQty.Location = new System.Drawing.Point(126, 240);
			this.ProdQty.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdQty.Name = "ProdQty";
			this.ProdQty.Size = new System.Drawing.Size(204, 30);
			this.ProdQty.TabIndex = 6;
			this.ProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(3, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "QUANTITY";
			// 
			// ProdName
			// 
			this.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdName.Enabled = false;
			this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdName.HintForeColor = System.Drawing.Color.Empty;
			this.ProdName.HintText = "";
			this.ProdName.isPassword = false;
			this.ProdName.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdName.LineIdleColor = System.Drawing.Color.White;
			this.ProdName.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdName.LineThickness = 3;
			this.ProdName.Location = new System.Drawing.Point(126, 143);
			this.ProdName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdName.Name = "ProdName";
			this.ProdName.Size = new System.Drawing.Size(202, 30);
			this.ProdName.TabIndex = 4;
			this.ProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(3, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "ProdName";
			// 
			// BillID
			// 
			this.BillID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.BillID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BillID.HintForeColor = System.Drawing.Color.Empty;
			this.BillID.HintText = "";
			this.BillID.isPassword = false;
			this.BillID.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.BillID.LineIdleColor = System.Drawing.Color.White;
			this.BillID.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.BillID.LineThickness = 3;
			this.BillID.Location = new System.Drawing.Point(126, 96);
			this.BillID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.BillID.Name = "BillID";
			this.BillID.Size = new System.Drawing.Size(204, 30);
			this.BillID.TabIndex = 2;
			this.BillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(6, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "BILLID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(620, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "SELLING";
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkOrange;
			this.label6.Location = new System.Drawing.Point(42, 790);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Logout";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.DarkOrange;
			this.button2.Location = new System.Drawing.Point(5, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(155, 38);
			this.button2.TabIndex = 28;
			this.button2.Text = "Categories";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.DarkOrange;
			this.button3.Location = new System.Drawing.Point(12, 107);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(108, 38);
			this.button3.TabIndex = 27;
			this.button3.Text = "Products";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// SellingFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1578, 823);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SellingFrom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SellingFrom";
			this.Load += new System.EventHandler(this.SellingFrom_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ComboBox SearchCb;
		private Guna.UI.WinForms.GunaDataGridView BillsDGV;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQty;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdName;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox BillID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPrice;
		private System.Windows.Forms.Label label8;
		private Guna.UI.WinForms.GunaDataGridView ProdDGV1;
		private System.Windows.Forms.Label Datelbl;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label SellerNamelbl;
		private Guna.UI.WinForms.GunaDataGridView ORDERDGV;
		private System.Windows.Forms.Label Amtlbl;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn PName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}