namespace Supermarket_Trinh
{
	partial class CategoryFrom
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.CatDGV = new Guna.UI.WinForms.GunaDataGridView();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.CatDescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.CatNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label3 = new System.Windows.Forms.Label();
			this.CatIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOrange;
			this.panel1.Controls.Add(this.CatDGV);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.CatDescTb);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.CatNameTb);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.CatIdTb);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(170, 37);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1373, 802);
			this.panel1.TabIndex = 2;
			// 
			// CatDGV
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.CatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CatDGV.BackgroundColor = System.Drawing.Color.White;
			this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CatDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.CatDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Chocolate;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.CatDGV.ColumnHeadersHeight = 30;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CatDGV.DefaultCellStyle = dataGridViewCellStyle9;
			this.CatDGV.EnableHeadersVisualStyles = false;
			this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CatDGV.Location = new System.Drawing.Point(364, 141);
			this.CatDGV.Name = "CatDGV";
			this.CatDGV.RowHeadersVisible = false;
			this.CatDGV.RowTemplate.Height = 28;
			this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CatDGV.Size = new System.Drawing.Size(993, 646);
			this.CatDGV.TabIndex = 13;
			this.CatDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.CatDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.CatDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.CatDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.CatDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.CatDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CatDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
			this.CatDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.CatDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.CatDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.CatDGV.ThemeStyle.HeaderStyle.Height = 30;
			this.CatDGV.ThemeStyle.ReadOnly = false;
			this.CatDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.CatDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.CatDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CatDGV.ThemeStyle.RowsStyle.Height = 28;
			this.CatDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CatDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.White;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.DarkOrange;
			this.button7.Location = new System.Drawing.Point(233, 335);
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
			this.button6.Location = new System.Drawing.Point(123, 335);
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
			this.button4.Location = new System.Drawing.Point(10, 335);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 38);
			this.button4.TabIndex = 4;
			this.button4.Text = "ADD";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// CatDescTb
			// 
			this.CatDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CatDescTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatDescTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CatDescTb.HintForeColor = System.Drawing.Color.Empty;
			this.CatDescTb.HintText = "";
			this.CatDescTb.isPassword = false;
			this.CatDescTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.CatDescTb.LineIdleColor = System.Drawing.Color.White;
			this.CatDescTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.CatDescTb.LineThickness = 3;
			this.CatDescTb.Location = new System.Drawing.Point(158, 242);
			this.CatDescTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.CatDescTb.Name = "CatDescTb";
			this.CatDescTb.Size = new System.Drawing.Size(186, 30);
			this.CatDescTb.TabIndex = 6;
			this.CatDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(4, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "DESCRIPTION";
			// 
			// CatNameTb
			// 
			this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CatNameTb.HintForeColor = System.Drawing.Color.Empty;
			this.CatNameTb.HintText = "";
			this.CatNameTb.isPassword = false;
			this.CatNameTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.CatNameTb.LineIdleColor = System.Drawing.Color.White;
			this.CatNameTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.CatNameTb.LineThickness = 3;
			this.CatNameTb.Location = new System.Drawing.Point(158, 178);
			this.CatNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.CatNameTb.Name = "CatNameTb";
			this.CatNameTb.Size = new System.Drawing.Size(186, 30);
			this.CatNameTb.TabIndex = 4;
			this.CatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(4, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "NAME";
			// 
			// CatIdTb
			// 
			this.CatIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CatIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CatIdTb.HintForeColor = System.Drawing.Color.Empty;
			this.CatIdTb.HintText = "";
			this.CatIdTb.isPassword = false;
			this.CatIdTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
			this.CatIdTb.LineIdleColor = System.Drawing.Color.White;
			this.CatIdTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
			this.CatIdTb.LineThickness = 3;
			this.CatIdTb.Location = new System.Drawing.Point(158, 117);
			this.CatIdTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.CatIdTb.Name = "CatIdTb";
			this.CatIdTb.Size = new System.Drawing.Size(186, 30);
			this.CatIdTb.TabIndex = 2;
			this.CatIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(4, 124);
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
			this.label1.Location = new System.Drawing.Point(525, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(322, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "MANAGE CATEGORIES";
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.DarkOrange;
			this.button2.Location = new System.Drawing.Point(12, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 38);
			this.button2.TabIndex = 4;
			this.button2.Text = "Products";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.DarkOrange;
			this.button1.Location = new System.Drawing.Point(12, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 38);
			this.button1.TabIndex = 3;
			this.button1.Text = "Seller";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkOrange;
			this.label7.Location = new System.Drawing.Point(44, 816);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "Logout";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// CategoryFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1578, 851);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CategoryFrom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CategoryFrom";
			this.Load += new System.EventHandler(this.CategoryFrom_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaDataGridView CatDGV;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox CatDescTb;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox CatNameTb;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox CatIdTb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
	}
}