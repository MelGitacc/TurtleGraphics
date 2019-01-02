using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{

	//this interface will be used for the shapes classes to set, draw calArea etc
	//you can add method here and use it for the shapes classes 
	interface Shapes
	{
		
			void set(Color c, params int[] list);
			void draw(Graphics g);
			//double calcArea();
			//double calcPerimeter();

	}
}
