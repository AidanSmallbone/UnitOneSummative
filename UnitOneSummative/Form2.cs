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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image doneHero = Image.FromFile(@".\hero.png"); //loads the saved image in as a new image object so it's easier to work with
            heroDonePictureBox.Image = doneHero; //sets a picturebox backround image to the image object we just created
        }
    }
}
