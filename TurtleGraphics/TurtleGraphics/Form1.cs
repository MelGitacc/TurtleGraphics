
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleGraphics
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			Graphics g = DrawingArea.CreateGraphics();
		}

		private void RunBtn_Click(object sender, EventArgs e)
		{
		

		}

		//this is for picture box code
		private void DrawingArea_Click(object sender, EventArgs e)
		{

		}

		private void txtBoxCmd_TextChanged(object sender, EventArgs e)
		{

		}


	}
}
