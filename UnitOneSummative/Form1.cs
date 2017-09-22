using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitOneSummative
{
    public partial class Form1 : Form

    {

        Point lastPoint = Point.Empty; //creats a point variable to keep track of our mose position, and sets it to have no value
        bool isMouseDown = new Boolean(); //creates a boolean to track is the mouse is pressed
        string penColor = "Black"; //this sets the default pen color and allows us to keep track of the pen color
        float penSize = 2;



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

                            g.DrawLine(new Pen(Color.FromName(penColor), width: penSize), lastPoint, e.Location); //create a pen tool
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //makes the line a little smoother
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
            if (drawHeroPictureBox.Image != null) //checks to see that the image isn't already cleared
            {
                drawHeroPictureBox.Image = null; //clears the image
                Invalidate(); //refreshes the picture box
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            drawHeroPictureBox.Image.Save(@".\hero.png", ImageFormat.Png); //saves the generated image to the root folder of the program
            Image doneHero = Image.FromFile(@".\hero.png"); //loads the saved image in as a new image object so it's easier to work with
            drawHeroPictureBox.Dispose(); //all of these dispose of the stuff we used to draw our hero
            drawHereLabel.Dispose();
            heroLabel.Dispose();
            clearButton.Dispose();
            doneButton.Dispose();
            blackButton.Dispose();
            whiteButton.Dispose();
            redButton.Dispose();
            orangeButton.Dispose();
            greenButton.Dispose();
            blueButton.Dispose();
            purpleButton.Dispose();
            pinkButton.Dispose();
            penSizeSelector.Dispose();
            heroDonePictureBox.BackgroundImage = doneHero; //sets the background of our new picturebox to the image object we created
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            penColor = "Black"; //sets the pen color to black
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            penColor = "White"; //sets the pen color to white
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            penColor = "Brown"; //sets the pen color to red
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            penColor = "Coral"; //sets the pen color to orange
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            penColor = "SpringGreen"; //sets pen color to green
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            penColor = "SteelBlue"; //sets pen color to blue
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            penColor = "MediumPurple"; //sets pen color to purple
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            penColor = "LightPink"; //sets pen color to pink
        }

        private void penSizeSelector_ValueChanged(object sender, EventArgs e)
        {
            penSize = Convert.ToSingle(penSizeSelector.Value); //converts the input of the pen size box to a float point value so the pen thing can understand it
            penSizeLabel.Dispose();

        }
    }
}
