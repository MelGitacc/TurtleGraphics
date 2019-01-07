using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace TurtleGraphics
{
	/// <summary> 
	/// this class is for the square shape which will be called if user wants to draw square
	/// also, this class inherits the draw method for rectangle
	/// </summary>
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
		/// <summary>
		///since we are using Rectangle class, no need to implement this section as the draw method for rectangle
		///will be inherited from here
		/// </summary>
		/// <param name="g"></param>

		public override void draw(Graphics g)
		{
			base.draw(g);
		}

	}
}
