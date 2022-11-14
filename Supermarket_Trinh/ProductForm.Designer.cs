namespace Supermarket_Trinh
{
	partial class ProductForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.SearchCb = new System.Windows.Forms.ComboBox();
			this.ProdDGV = new Guna.UI.WinForms.GunaDataGridView();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.CatCb = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ProdPice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label5 = new System.Windows.Forms.Label();
			this.ProdQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.ProdName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label3 = new System.Windows.Forms.Label();
			this.ProdId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOrange;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.SearchCb);
			this.panel1.Controls.Add(this.ProdDGV);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.CatCb);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.ProdPice);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.ProdQty);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ProdName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.ProdId);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(170, 37);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1373, 802);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.White;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.DarkOrange;
			this.button8.Location = new System.Drawing.Point(1081, 97);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(110, 34);
			this.button8.TabIndex = 15;
			this.button8.Text = "Refresh";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// SearchCb
			// 
			this.SearchCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchCb.ForeColor = System.Drawing.Color.DarkOrange;
			this.SearchCb.FormattingEnabled = true;
			this.SearchCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.SearchCb.Location = new System.Drawing.Point(865, 97);
			this.SearchCb.Name = "SearchCb";
			this.SearchCb.Size = new System.Drawing.Size(210, 31);
			this.SearchCb.TabIndex = 14;
			this.SearchCb.Text = "Select Category";
			this.SearchCb.SelectedIndexChanged += new System.EventHandler(this.SearchCb_SelectedIndexChanged);
			this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.SearchCb_SelectionChangeCommitted);
			// 
			// ProdDGV
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ProdDGV.BackgroundColor = System.Drawing.Color.White;
			this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ProdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ProdDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.ProdDGV.ColumnHeadersHeight = 30;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle12;
			this.ProdDGV.EnableHeadersVisualStyles = false;
			this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.Location = new System.Drawing.Point(363, 141);
			this.ProdDGV.Name = "ProdDGV";
			this.ProdDGV.RowHeadersVisible = false;
			this.ProdDGV.RowTemplate.Height = 24;
			this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProdDGV.Size = new System.Drawing.Size(993, 646);
			this.ProdDGV.TabIndex = 13;
			this.ProdDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ProdDGV.ThemeStyle.HeaderStyle.Height = 30;
			this.ProdDGV.ThemeStyle.ReadOnly = false;
			this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV.ThemeStyle.RowsStyle.Height = 24;
			this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.White;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.DarkOrange;
			this.button7.Location = new System.Drawing.Point(233, 447);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(100, 38);
			this.button7.TabIndex = 12;
			this.button7.Text = "DELETE";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.White;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.DarkOrange;
			this.button6.Location = new System.Drawing.Point(123, 447);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(100, 38);
			this.button6.TabIndex = 11;
			this.button6.Text = "EDIT";
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
			this.button4.Location = new System.Drawing.Point(10, 447);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 38);
			this.button4.TabIndex = 4;
			this.button4.Text = "ADD";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// CatCb
			// 
			this.CatCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatCb.ForeColor = System.Drawing.Color.DarkOrange;
			this.CatCb.FormattingEnabled = true;
			this.CatCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.CatCb.Location = new System.Drawing.Point(126, 367);
			this.CatCb.Name = "CatCb";
			this.CatCb.Size = new System.Drawing.Size(207, 31);
			this.CatCb.TabIndex = 10;
			this.CatCb.Text = "Select Category";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(3, 375);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "CATEGORY";
			// 
			// ProdPice
			// 
			this.ProdPice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdPice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdPice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdPice.HintForeColor = System.Drawing.Color.Empty;
			this.ProdPice.HintText = "";
			this.ProdPice.isPassword = false;
			this.ProdPice.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPice.LineIdleColor = System.Drawing.Color.White;
			this.ProdPice.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdPice.LineThickness = 3;
			this.ProdPice.Location = new System.Drawing.Point(129, 309);
			this.ProdPice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdPice.Name = "ProdPice";
			this.ProdPice.Size = new System.Drawing.Size(204, 30);
			this.ProdPice.TabIndex = 8;
			this.ProdPice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(6, 316);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "PICE";
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
			this.ProdQty.Location = new System.Drawing.Point(129, 242);
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
			this.label4.Location = new System.Drawing.Point(6, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "QUANTITY";
			// 
			// ProdName
			// 
			this.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdName.HintForeColor = System.Drawing.Color.Empty;
			this.ProdName.HintText = "";
			this.ProdName.isPassword = false;
			this.ProdName.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdName.LineIdleColor = System.Drawing.Color.White;
			this.ProdName.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdName.LineThickness = 3;
			this.ProdName.Location = new System.Drawing.Point(129, 178);
			this.ProdName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdName.Name = "ProdName";
			this.ProdName.Size = new System.Drawing.Size(204, 30);
			this.ProdName.TabIndex = 4;
			this.ProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(6, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "NAME";
			// 
			// ProdId
			// 
			this.ProdId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdId.HintForeColor = System.Drawing.Color.Empty;
			this.ProdId.HintText = "";
			this.ProdId.isPassword = false;
			this.ProdId.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.ProdId.LineIdleColor = System.Drawing.Color.White;
			this.ProdId.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.ProdId.LineThickness = 3;
			this.ProdId.Location = new System.Drawing.Point(129, 117);
			this.ProdId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.ProdId.Name = "ProdId";
			this.ProdId.Size = new System.Drawing.Size(204, 30);
			this.ProdId.TabIndex = 2;
			this.ProdId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(6, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(543, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(293, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "MANAGE PRODUCTS";
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.DarkOrange;
			this.button1.Location = new System.Drawing.Point(12, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "Seller";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.DarkOrange;
			this.button2.Location = new System.Drawing.Point(12, 198);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 38);
			this.button2.TabIndex = 1;
			this.button2.Text = "Category";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button5
			// 
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.DarkOrange;
			this.button5.Location = new System.Drawing.Point(1506, -2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(42, 33);
			this.button5.TabIndex = 3;
			this.button5.Text = "x";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkOrange;
			this.label7.Location = new System.Drawing.Point(44, 816);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 23);
			this.label7.TabIndex = 27;
			this.label7.Text = "Logout";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// ProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1578, 851);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProductForm";
			this.Load += new System.EventHandler(this.ProductForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdName;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdId;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQty;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox CatCb;
		private Guna.UI.WinForms.GunaDataGridView ProdDGV;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ComboBox SearchCb;
		private System.Windows.Forms.Label label7;
	}
}