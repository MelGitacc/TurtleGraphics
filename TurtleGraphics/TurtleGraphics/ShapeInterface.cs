using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TurtleGraphics
{
	/// <summary>
	/// this class inherits the shape interface class which needs to be implemented here
	/// </summary>

	interface Shapes
	{

		void set(Color c, params int[] list);
		void draw(Graphics g);


	}
}
