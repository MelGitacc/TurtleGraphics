using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TurtleGraphics
{/// <summary> 
 /// this class is for the triangle shape which will be called if user wants to draw triangle
 /// </summary>
	class Triangle : Shape
	{
		Point[] points;

		public Triangle() : base()
		{
			//Draw a triangle on the form.
			//first have to define an array of points.
			points = new Point[3];

			points[0].X = 150;
			points[0].Y = 150;

			points[1].X = 100;
			points[1].Y = 10;

			points[2].X = 50;
			points[2].Y = 120;
		}
		public Triangle(Color colour, int point0X, int point0Y, int point1X, int point1Y, int point2X, int point2Y) : base(colour, point0X, point0Y)
		{
			this.points[0].X = point0X;
			this.points[0].Y = point0Y;

			this.points[1].X = point1X;
			this.points[1].X = point1Y;

			this.points[1].X = point2X;
			this.points[1].X = point2Y;

		}

		public override void set(Color colour, params int[] list)
		{
			//list[]... are the points of the traingle
		base.set(colour, list[0], list[1]);
		this.points[0].X = list[2];
		this.points[0].Y = list[3];
		this.points[1].X = list[4];
		this.points[1].Y = list[5];
		this.points[2].X = list[6];
		this.points[2].Y = list[7];

		}

		public override void draw(Graphics g)
		{
			Pen p = new Pen(Color.Red, 2);
			SolidBrush b = new SolidBrush(colour);
			g.FillPolygon(b, points);
			g.DrawPolygon(p,points);
		}
	}
}
