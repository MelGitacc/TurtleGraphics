using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
	class ShapeFactory
	{
		public Shape getShape(String shapeType)
		{
			//this is to allow user for any case combination
			shapeType = shapeType.ToUpper().Trim();

			if (shapeType.Equals("CIRCLE"))
			{
				return new Circle();

			}
			else if (shapeType.Equals("RECTANGLE"))
			{
				return new Rectangle();

			}
			else if (shapeType.Equals("SQUARE"))
			{
				return new Square();
			}
			
			else
			{
				//if we get here then what has been passed in is inkown so throw an appropriate exception
				System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
				throw argEx;
			}
		}
	}
}
