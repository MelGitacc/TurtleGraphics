using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TurtleGraphics
{/// <summary> 
 /// this class is for the rectangle shape which will be called if user wants to draw rectangle
 /// </summary>
	class Rectangle : Shape
	{
		//variables used to store value of width and height of rectangle
		int width, height;
		public Rectangle() : base()
		{
			width = 100;
			height = 100;
		}
		public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
		{

			this.width = width; //the only thing that is different from shape
			this.height = height;
		}

		public override void set(Color colour, params int[] list)
		{
			//list[0] is x, list[1] is y, list[2] is width, list[3] is height
			base.set(colour, list[0], list[1]);
			this.width = list[2];
			this.height = list[3];

		}
		//draw method for rectangle
		public override void draw(Graphics g)
		{
			Pen p = new Pen(Color.AliceBlue, 2);
			SolidBrush b = new SolidBrush(colour);
			g.FillRectangle(b, x, y, width, height);
			g.DrawRectangle(p, x, y, width, height);
		}

	}
}
