﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Trinh
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
		}

		int startpoint = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			startpoint += 1;
			Myprogress.Value = startpoint;
			if(Myprogress.Value == 100)
			{
				Myprogress.Value = 0;
				timer1.Stop();
				Form1 log = new Form1();
				this.Hide();
				log.Show();
			}
		}

		private void Splash_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
