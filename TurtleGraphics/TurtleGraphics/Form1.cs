
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleGraphics
{
	public partial class Form1 : Form
	{
		
		ArrayList shapes = new ArrayList();
		int numLines = 0;
		bool penDown = true;

		Color newColour = Color.LightBlue;//initialising new colour
		int x ;//starting point 
		int y;//starting point 
		int radius;//set new radius for user to use
		String MultiLine;//this is for the string array line
		int width;//for rectangle
		int height;//for rectangle
		Image file;

		public Form1()
		{
			InitializeComponent();
		}


		private void RunButton_Click(object sender, EventArgs e)
		{
			pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
			//calls the shape factory
			ShapeFactory factory = new ShapeFactory();
				Shape shp;
				String text = txtBox.Text;
			x = 0;
			y = 0;

			//this is going to split the lines in text box when useer type series of shapes
			String[] cmdList = text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

			//this allow the shpaes to be display in picture box
			using (var g = Graphics.FromImage(pictureBox.Image))
			{
				for (int i = 0; i < cmdList.Length; i++)
				{
					MultiLine = cmdList[i];//store the current line in text box (for loop)
					//split line using space for user to input value of x and y
					String[] line = MultiLine.Split(new string[] { " ", " " }, StringSplitOptions.RemoveEmptyEntries);

					if (line[0].Equals("circle"))
					{
						//draw circle
						
						shp = factory.getShape("circle");
						radius = int.Parse(line[1]);// 
						shp.set(newColour, x, y, radius);//this is the bit where it is different for other shapes
						shp.draw(g);
						y = y + (radius * 2);//this will dertermine the next position of x
						x = x + (radius * 2);
						pictureBox.Refresh();//clears the picture box if user delete the shape from the text box

					}
					else if (line[0].Equals("rectangle")) 
					{
					
						//darw rectangle
						shp = factory.getShape("rectangle");
						width = int.Parse(line[1]);//
						height = int.Parse(line[2]);
						shp.set(Color.Violet,x, y,width,height);
						shp.draw(g);
						
						y = y + (width * 2);//this will dertermine the next position of x
						x = x + (height * 2);
						pictureBox.Refresh();

					}
					else if (line[0].Equals("triangle"))
					{
						int point0x, point0y, point1X, point1Y, point2X, point2Y;
						//draw a triangle
						shp = factory.getShape("triangle");
						point0x = int.Parse(line[1]);//
						point0y = int.Parse(line[2]);//
						point1X = int.Parse(line[3]);
						point1Y = int.Parse(line[4]);
						point2X = int.Parse(line[5]);
						point2Y = int.Parse(line[6]);
						shp.set(Color.YellowGreen, x, y, point0x, point0y, point1X, point1Y, point2X, point2Y);
						
						shp.draw(g);
						y = y + (width * 2);//this will dertermine the next position of x
						x = x + (height * 2);
						pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
					}
					else if (line[0].Equals("square"))
					{
						//int size = 0 ;
											 //draw a square
						shp = factory.getShape("square");
						width = int.Parse(line[1]);//
						height = int.Parse(line[2]);
						shp.set(Color.LightSteelBlue, x, y, width,height);
						
						shp.draw(g);
						y = y + (width * 2);//this will dertermine the next position of x
						x = x + (height * 2);
						pictureBox.Refresh();// clears the picture box if user delete the shape from the text box
					}
					else if (line[0].Equals("drawto"))//completed
					{
					
						Pen myPen = new Pen(Color.Black);
						try
						{
							g.DrawLine(myPen, x, y, int.Parse(line[1]), int.Parse(line[2]));
							//clears the picture box if user delete the shape from the text box
							pictureBox.Refresh();
						}
						catch (Exception)
						{

						}
					}
					
					else if (line[0].Equals("moveto"))
					{
						//this will allow user to input integer alongside the moveTo word
						
						x = int.Parse(line[1]);
						y = int.Parse(line[2]);	
						
					}
					else if (line[0].Equals("penup"))
					{
						penDown = false; //this is for penup command

					}
					else if (line[0].Equals("pendown"))
					{
						penDown = true; ////this is for pendown command
					}

					else if (line[0].Equals("polygon"))
					{
						int point0x, point0y, point1X, point1Y, point2X, point2Y;
						//draw a triangle
						shp = factory.getShape("polygon");
						point0x = int.Parse(line[1]);
						point0y = int.Parse(line[2]);
						point1X = int.Parse(line[3]);
						point1Y = int.Parse(line[4]);
						point2X = int.Parse(line[5]);
						point2Y = int.Parse(line[6]);
						shp.set(Color.YellowGreen, x, y, point0x, point0y, point1X, point1Y, point2X, point2Y);

						shp.draw(g);
						y = y + (width * 2);//this will dertermine the next position of x
						x = x + (height * 2);
						pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
					}
				}

				}
				
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//exit the program
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//allows user to open an image file 
		private void menuOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Image Files (*.jpg; *.bmp; *.png)|*.jpg;*.bmp; *.png";

			if (open.ShowDialog() == DialogResult.OK)
			{
				txtBox.Text = open.FileName;
				pictureBox.Image = new Bitmap(open.FileName);
			}
		}

		private void pictureBox_Click(object sender, EventArgs e)
			{

		
			
		}
		//allows user to save drawing to Images folder 
		private void menuSave_Click(object sender, EventArgs e)
		{
			
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.jpg*";
			if (save.ShowDialog() == DialogResult.OK)
			{
				pictureBox.Image.Save(save.FileName,System.Drawing.Imaging.ImageFormat.Bmp);
			
				label2.Text = "Saved Successfully!";
			}
			
		}
	}
}
