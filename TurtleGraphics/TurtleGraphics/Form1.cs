
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
	/// <summary>
	/// This is the main class for execution of the code for shapes
	/// allowing user to perform commands for shapes
	/// </summary>
	public partial class Form1 : Form
	{
		/// <summary> 
		/// this variables will used for user inputs
		/// <summary> 
		bool penDown = true;
		Color newColour = Color.LightBlue;//initialising new colour
		int x ;//starting point 
		int y;//starting point 
		int radius;//set new radius for user to use
		String MultiLine;//this is for the string array line
		int width;//for rectangle
		int height;//for rectangle
		int size;
		int point0x, point0y, point1X, point1Y, point2X, point2Y;
		
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary> 
		/// this button method performs an important function for drawing shapes and lines
		/// </summary>
		private void RunButton_Click(object sender, EventArgs e)
		{
			//sets picturebox as drawing area
			pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

			//calls the shape factory
			ShapeFactory factory = new ShapeFactory();
			Shape shp;
			String text = txtBox.Text;
			x = 0;
			y = 0;
			point0x = 0; point0y = 0; point1X = 0; point1Y = 0; point2X = 0; point2Y = 0; 

			//this is going to split the lines in text box when useer type series of shapes
			String[] cmdList = text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

			//this allow the shapes to be display in picture box
			using (var g = Graphics.FromImage(pictureBox.Image))
			{
				
				for (int i = 0; i < cmdList.Length; i++)
				{
					MultiLine = cmdList[i];//store the current line in text box (for loop)

					/// <summary> 
					/// splits line using space and comma for user to input the value of x and y
					/// checks and catch exceptions
					/// </summary>
					String[] line = MultiLine.Split(new string[] { " ", " , " }, StringSplitOptions.RemoveEmptyEntries);
					try
					{
						if (line[0].Length >= 1)
						{
							if (line[0].ToLower().Equals("circle"))
							{
								//draw circle

								shp = factory.getShape("circle");
								radius = int.Parse(line[1]);
								shp.set(newColour, x, y, radius);//this is the bit where it is different for other shapes
								shp.draw(g);
								x = x + (radius * 2);//this will dertermine the next position of x
								y = y + (radius * 2);
								pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
							}

							else if (line[0].ToLower().Equals("rectangle"))
							{

								//darw rectangle
								shp = factory.getShape("rectangle");
								width = int.Parse(line[1]);//
								height = int.Parse(line[2]);
								shp.set(Color.Purple, x, y, width, height);
								shp.draw(g);
								x = x + (width * 2);
								y = y + (height * 2);//this will dertermine the next position of x
								pictureBox.Refresh();

							}
							else if (line[0].ToLower().Equals("triangle"))
							{
								//int point0x, point0y, point1X, point1Y, point2X, point2Y;
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
								x = x + (point0x * 2);//this will dertermine the next position of x
								y = y + (point0y * 2);
								pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
							}
							else if (line[0].ToLower().Equals("square"))
							{
								//draw a square
								shp = factory.getShape("square");
								width = int.Parse(line[1]);
								height = int.Parse(line[2]);
								shp.set(Color.Brown, x, y, width, height);

								shp.draw(g);
								x = y + (point0x * 2);//this will dertermine the next position of x
								y = y + (point0y * 2);
								pictureBox.Refresh();// clears the picture box if user delete the shape from the text box
							}
							else if (line[0].ToLower().Equals("polygon"))
							{
								//	int point0x, point0y, point1X, point1Y, point2X, point2Y;
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
								x = x + (width * 2);//this will dertermine the next position of x
								y = y + (height * 2);
								pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
							}
							else if (line[0].ToLower().Equals("drawto"))//completed
							{
								Pen myPen = new Pen(Color.Black, 5);
								try
								{
									g.DrawLine(myPen, x, y, int.Parse(line[1]), int.Parse(line[2]));

									x = x + (width * 2);//this will dertermine the next position of x
									y = y + (height * 2);
									pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
								}
								catch (Exception ex)
								{
									Console.WriteLine("An error occurred: '{0}'", ex);
								}
							}

							else if (line[0].ToLower().Equals("moveto"))
							{
								//this will allow user to input integer alongside the moveTo word

								x = int.Parse(line[1]);
								y = int.Parse(line[2]);

							}
							else if (line[0].ToLower().Equals("penup"))
							{
								penDown = false; //this is for penup command

							}
							else if (line[0].ToLower().Equals("pendown"))
							{
								penDown = true; ////this is for pendown command
							}


							///<summary>
							/// this method will be called when user input repeat command
							/// the repeat have length of 5 for example (repeat 4 circle + 10) 
							/// </summary>

							else if (line[0].ToLower().Equals("repeat"))
							{
								if (line[0].Length >= 5)
								{
									if (line[2].ToLower().Equals("circle"))
									{
										int rd = int.Parse(line[1]);//this is the value in whihch user will input
										int radius2;//store the ravalue of radius

										if (line[4].ToLower().Equals("radius"))
										{
											radius2 = radius;
										}
										else
										{
											radius2 = int.Parse(line[4]);
										}
										for (int v = 0; v < rd; v++) //repeat loop to draw circle
										{
											//draw circle
											shp = factory.getShape("circle");
											if (line[3][0] == '+')
											{

												shp.set(newColour, x, y, radius + (v * 5));//this is the bit where it is different for other shapes
											}
											else
											{
												shp.set(newColour, x, y, radius - (v * 5));//this is the bit where it is different for other shapes
											}

											shp.draw(g);

											pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
										}//end of for loop
									}

								}
							}//end of else if of repeat
							 /*	 //for rectangle repeat

								 else if (line[0].Length == 6)
									 {
										 if (line[2].ToLower().Equals("rectangle"))
										 {
											 int rd = int.Parse(line[1]);//this is the value in whihch user will input
											 int wd2;//store the value of width
											 int ht2;//height

											 if (line[4].ToLower().Equals("width"))
											 {
												 wd2 = width;
												 ht2 = height;
											 }
											 else
											 {
												 wd2 = int.Parse(line[4]);
												 ht2 = int.Parse(line[5]);
											 }
											 if (line[6].ToLower().Equals("height"))
											 {
												 ht2 = height;
											 }
											 else
											 {
												 ht2 = int.Parse(line[5]);
											 }

											 for (int v = 0; v < rd; v++) //repeat loop to draw circle
											 {
												 //draw circle
												 shp = factory.getShape("rectangle");
												 if (line[3][5] == '+')
												 {

													 shp.set(newColour, x, y, width, height + (v * 5));//this is the bit where it is different for other shapes
												 }
												 else
												 {
													 shp.set(newColour, x, y, width, height - (v * 5));//this is the bit where it is different for other shapes
												 }

												 shp.draw(g);

												 pictureBox.Refresh();//clears the picture box if user delete the shape from the text box
											 }//end of for loop
										 }

									 }

								 }//end of else if statement for rectangle*/

						}
					} catch(System.IndexOutOfRangeException ex)
					{
						Console.WriteLine("An error occurred: '{0}'", ex);

					}
				
				}	

				}
				
		}

		/// <summary> 
		/// this method displays the list of command when user click the "about" in menu bar 
		/// </summary>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			String title = "About";
			MessageBox.Show("Command lists\n\n penup \n pendown \n drawto x,y \n moveto x,y \n circle radius \n rectangle w,h \n square w,h \n triangle point1...point6 \n polygon point1..point6", title);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		/// <summary> 
		///exits the program
		/// </summary> 
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary> 
		///this will allow user to open an image file and displays it to the picturebox
		/// </summary> 
		private void menuOpen_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog open = new OpenFileDialog();
				open.Filter = "Image Files (*.jpg; *.bmp; *.png)|*.jpg;*.bmp; *.png";

				if (open.ShowDialog() == DialogResult.OK)
				{
					txtBox.Text = open.FileName;
					pictureBox.Image = new Bitmap(open.FileName);
				}
			}
			catch (IOException ex)
			{
				Console.WriteLine("An error occurred: '{0}'", ex);
			}
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{			
		}
		/// <summary> 
		/// this will allow user to save drawings
		/// </summary> 
		private void menuSave_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog save = new SaveFileDialog();
				save.Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.jpg*";
				if (save.ShowDialog() == DialogResult.OK)
				{
					pictureBox.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);

					//display the message when image file is saved successfully
					label2.Text = "Saved Successfully!";
				}
			}
			catch (IOException ex)
			{
				Console.WriteLine("An error occurred: '{0}'", ex);
			}
		}
	}
}
