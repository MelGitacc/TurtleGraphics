﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TurtleGraphics
{
	/// <summary> 
	/// this class is for the circle shape which will be called if user wants to draw circle
	/// </summary>
	class Circle : Shape
	{
		int radius;

		public Circle() : base()
		{

		}

		public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
		{

			this.radius = radius; //the only thing that is different from shape
		}

		public override void set(Color colour, params int[] list)
		{
			//list[0] is x, list[1] is y, list[2] is radius
			base.set(colour, list[0], list[1]);
			this.radius = list[2];
		}

		//this is to draw the circle and fill it with colour
		public override void draw(Graphics g)
		{

			Pen p = new Pen(Color.Black, 2);
			SolidBrush b = new SolidBrush(colour);
			//g.FillEllipse(b, x, y, radius * 2, radius * 2);
			g.DrawEllipse(p, x, y, radius * 2, radius * 2);

		}
	}
}
