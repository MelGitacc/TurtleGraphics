using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
	class ShapeFactory
	{
		//if user type a shape, it will call its corresponding class and returns a new shape.
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
			else if (shapeType.Equals("TRIANGLE"))
			{
				return new Triangle();
			}
			else if (shapeType.Equals("POLYGON"))
			{
				return new Polygon();
			}
			else
			{
				//exception called argEx will be called if the shapetype that's been passed in is unkown
				System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
				throw argEx;
			}
		}
	}
}
