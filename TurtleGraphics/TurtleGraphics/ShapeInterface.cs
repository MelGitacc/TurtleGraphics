using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
	
	/// <summary> 
	/// this class is for the polygon shape which will be called if user wants to draw polygon
	/// this interface will be used for the shapes classes to set colour and draw shape
	/// you can add method here and use it for the shapes classes 
	/// </summary>

	interface Shapes
	{
		
			void set(Color c, params int[] list);
			void draw(Graphics g);
			

	}
}
