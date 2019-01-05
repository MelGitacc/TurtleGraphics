using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
	class Square :Rectangle
	{
		private int size;
		
		//constructor of square
		public Square() : base()
		{
			
		}
		public Square(Color colour, int x, int y, int size) : base(colour, x, y, size, size)
		{
			this.size = size;
		}
	
		//since we are using Rectangle class, no need to implement this section as the draw method for rectangle
		//will be inherited from here
		public override void draw(Graphics g)
		{
			base.draw(g);
		}

	}
}
