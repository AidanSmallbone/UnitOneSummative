using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitOneSummative
{
    public partial class Form2 : Form
    {
        public Form2()

        {
            InitializeComponent();
            Shown += Form2_Shown; //creates an event that is triggered when the user sees the form so that ui can render and shit doesn't break when we use thread.sleep
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image doneHero = Image.FromFile(@".\hero.png"); //loads the saved image in as a new image object so it's easier to work with
            heroDonePictureBox.Image = doneHero; //sets a picturebox backround image to the image object we just created
            SetStyle(ControlStyles.DoubleBuffer, true); //this is an attempt to combat flickering. it doesn't work that well
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            ///this part of the program is in charge of the first scene when the user clicks done
            ///adding in text and then removing it (it's the intro, basically)

            Application.DoEvents(); //tells the program to render anything it hasn't yet
            Thread.Sleep(1000); //waits for a second
            sceneOneLabelOne.Visible = true; //sets first label to visible
            Refresh(); //refreshes
            Thread.Sleep(500); //waits for half a second
            sceneOneLabelTwo.Visible = true; //sets second label to visible
            Refresh(); //refreshes
            Thread.Sleep(500); //waits half a second
            sceneOneLabelThree.Visible = true; //sets third label to visible
            Refresh(); //refreshes
            Thread.Sleep(2000); //waits 2 seconds
            sceneOneLabelOne.Dispose(); //kills all the labels
            sceneOneLabelTwo.Dispose();
            sceneOneLabelThree.Dispose();
            Refresh(); //refreshes

            ///this part of the program deals with the second scene, our character shrinks down and then starts moving
            ///i'll probably end up using methods within methods so i can be lazy and write all of my repetetive code only once

        }
    }
}
