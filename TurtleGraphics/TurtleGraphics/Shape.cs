using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
	abstract class Shape : Shapes
	{
		protected Color colour; //shape's colour
		protected int x, y; //not I could use c# properties for this

		public Shape()
		{
			colour = Color.Red;
			x = y = 100;
		}

		public Shape(Color colour, int x, int y)
		{

			this.colour = colour; //shapes colour
			this.x = x; //its x pos
			this.y = y; //its y pos
						
		}

		// the method below is from the ShapesInterface 
		//draw method is declared as an abstract which  must be implemented
		public abstract void draw(Graphics g); //any derrived class must implement this method


		//set is declared as virtual so it can be overridden by a more specific child version
		//but is here so it can be called by that child version to do the generic stuff
		//note the use of the param keyword to provide a variable parameter list to cope 
		//with some shapes having more setup information than others
		public virtual void set(Color colour, params int[] list)
		{
			this.colour = colour;
			this.x = list[0];
			this.y = list[1];
		}
	}

	}
