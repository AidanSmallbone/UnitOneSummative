using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitOneSummative
{
    public partial class Form1 : Form

    {

        Point lastPoint = Point.Empty; //creates a variable to track our mouse point
        bool isMouseDown = new Boolean(); //creates a boolean to track is the mouse is pressed

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawHeroPictureBox_MouseDown(object sender, MouseEventArgs e) //when the user clicks on our box, we begin our drawing engine
        {
            {

                lastPoint = e.Location; //sets the point mousepos to current mouse position
                isMouseDown = true; //sets the bool ismouseclicked to true -- it is

            }




        }

        private void drawHeroPictureBox_MouseMove(object sender, MouseEventArgs e) //check to see if the user has moved the mouse
        {
            {
                if (isMouseDown == true) //checks to see if mouse1 is down

                {

                    if (lastPoint != null) //this checks to see if we've moved the mouse so we don't waste resources making a bitmap before needed

                    {

                        if (drawHeroPictureBox.Image == null) //this makes sure that we haven't already created a bitmap

                        {

                            Bitmap bmp = new Bitmap(drawHeroPictureBox.Width, drawHeroPictureBox.Height); //creates a bitmap to draw on at the size of our panel
                            drawHeroPictureBox.Image = bmp; //gives drawHeroPictureBox a value so that we don't keep making new bitmaps

                        }

                        using (Graphics g = Graphics.FromImage(drawHeroPictureBox.Image)) //this turns out new bitmap into a graphics object we can edit

                        {

                            g.DrawLine(new Pen(Color.Black, width: 2), lastPoint, e.Location); //create a pen tool

                        }

                        drawHeroPictureBox.Refresh(); //refreshes the picturebox once we're done making it into a graphics object
                        lastPoint = e.Location; //keeps setting the lastPoint var to current mouse position
                    }
                }
            }
        }

        private void drawHeroPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false; //if the user lets go of mouse1 it is no longer down
            lastPoint = Point.Empty; //stops keeping track of mouse position since we're not using it anymore
        }

        private void drawHeroPictureBox_Click(object sender, EventArgs e)
        {
            drawHereLabel.Visible = false; //when the user clicks on the picture box, we hide the label that tells the user what to do
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
         
        }
    }
}