
using System;
using System.Collections;
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
		
		ArrayList shapes = new ArrayList();
		int numLines = 0;

		Color newColour = Color.Maroon;//initialising new colour
		int x = 0;//starting point for circle
		int y = 0;//starting point for circle
		int radius;//set new radius for user to use
		String MultiLine;//this is for the string array line
		int width;//for rectangle
		int height;//for rectangle
			
		public Form1()
		{
			InitializeComponent();

			//this sets the picture box as drawing area
			pictureBox.Image = new Bitmap(pictureBox.Width,pictureBox.Height);

			//this is getting the shape factory class
			ShapeFactory factory = new ShapeFactory();
		}
			
		/*private void Form1_Paint(object sender, PaintEventArgs e) //this can be used for the repeat mthoed for shapes
		{
			Console.WriteLine("paint called");
			Graphics g = e.Graphics;

			for (int i = 0; i < shapes.Count; i++)
			{
				Shape s;
				s = (Shape)shapes[i];
				if (s != null)
				{
					s.draw(g);
					Console.WriteLine(s.ToString());
				}
				else
					Console.WriteLine("invalid shape in array"); //shouldn't happen as factory does not produce rubbish
			
		}

	}*/

		private void RunButton_Click(object sender, EventArgs e)
		{

			//calls the shape factory
			ShapeFactory factory = new ShapeFactory();
				Shape shp;
				String text = txtBox.Text;

			//this is going to split the lines in text box when useer type series of shapes
			String[] cmdList = text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

			using (var g = Graphics.FromImage(pictureBox.Image))//this allow the shpaes to be display in picture box
			{
				for (int i = 0; i < cmdList.Length; i++)
				{
					MultiLine = cmdList[i];//store the current line in text box (for loop)
					String[] line = MultiLine.Split(new string[] { " ", " " }, StringSplitOptions.RemoveEmptyEntries);

					if (line[0].Equals("circle"))//working properly
					{
						//draw circle
						shp = factory.getShape("circle");
						radius = int.Parse(line[1]);// 
						shp.set(newColour, x, y, radius);//this is the bit where it is different for other shapes
						shp.draw(g);
						y = y + (radius * 4);//this will dertermine the next position of x
						x = x + (radius * 4);
						pictureBox.Refresh();//clears the picture box
						
					}
					else if (line[0].Equals("rectangle"))//working properly 
					{
						//darw rectangle
						shp = factory.getShape("rectangle");
						width = int.Parse(line[1]);//
						height = int.Parse(line[2]);
						shp.set(Color.Violet,x, y,width,height);
						shp.draw(g);
						y = y + (width * 4);//this will dertermine the next position of x
						x = x + (height * 2);
						pictureBox.Refresh();

					}
					else if (line[0].Equals("triangle"))// working fine
					{
						int point0x, point0y, point1X, point1Y, point2X, point2Y;
						//draw a triangle
						shp = factory.getShape("triangle");
						point0x = int.Parse(line[1]);//
						point0y = int.Parse(line[2]);//
						point1X = int.Parse(line[3]);
						point1Y = int.Parse(line[4]);
						point2X = int.Parse(line[5]);
						point2Y = int.Parse(line[6]);
						shp.set(Color.YellowGreen, x, y, point0x, point0y, point1X, point1Y, point2X, point2Y);
						shp.draw(g);
						y = y + (width * 2);//this will dertermine the next position of x
						x = x + (height * 4);
						pictureBox.Refresh();// clears the picture box
					}
					else if (line[0].Equals("square"))// working fine
					{

						//draw a square
						shp = factory.getShape("square");
						width = int.Parse(line[1]);//
						height = int.Parse(line[2]);
						shp.set(Color.LightSteelBlue, x, y, width, height);
						shp.draw(g);
						//y = y + (width * 2);//this will dertermine the next position of x
						x = x + (height * 4);
						pictureBox.Refresh();// clears the picture box
					}
					else if (line[0].Equals("drawTo"))
					{
						// draw a line

						//DrawLine(Color.MidnightBlue, 10, 50, 30, 50);
					}
					else if (line[0].Equals("moveTo"))
					{

					}
					else if (line[0].Equals("penUp"))
					{
						

					}
					else if (line[0].Equals("penDown"))
					{
						

					}

				}

				}
				
		}
	}
}
