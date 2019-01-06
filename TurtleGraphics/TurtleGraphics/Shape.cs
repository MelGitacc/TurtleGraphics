using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary> 
/// this class inherits the shape interface class which needs to be implemented here
/// </summary> 

namespace TurtleGraphics
{
	abstract class Shape : Shapes
	{
		protected Color colour; //shape's colour
		protected int x, y; 

		public Shape()
		{
			colour = Color.Red;
			x = y = 100;
		}

		public Shape(Color colour, int x, int y)
		{

			this.colour = colour; //shapes colour
			this.x = x; // x position
			this.y = y; // y position
						
		}
		/// <summary> 
		/// the method below is from the ShapesInterface 
		//draw method is declared as an abstract which must be implemented
		///any derrived class must implement this method
		/// /<summary> 
		public abstract void draw(Graphics g); 

		/// <summary> 
		///set is declared as virtual so it can be overridden by a more specific child version
		///the use of the param keyword is to provide a variable parameter list to handle 
		///some shapes which have more setup information than others
		/// </summary> 
		public virtual void set(Color colour, params int[] list)
		{
			this.colour = colour;
			this.x = list[0];
			this.y = list[1];
		}
	}

	}
