namespace UnitOneSummative
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.heroDonePictureBox = new System.Windows.Forms.PictureBox();
            this.sceneOneLabelOne = new System.Windows.Forms.Label();
            this.sceneOneLabelTwo = new System.Windows.Forms.Label();
            this.sceneOneLabelThree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDonePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heroDonePictureBox
            // 
            this.heroDonePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.heroDonePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroDonePictureBox.Location = new System.Drawing.Point(164, 52);
            this.heroDonePictureBox.Name = "heroDonePictureBox";
            this.heroDonePictureBox.Size = new System.Drawing.Size(256, 256);
            this.heroDonePictureBox.TabIndex = 0;
            this.heroDonePictureBox.TabStop = false;
            // 
            // sceneOneLabelOne
            // 
            this.sceneOneLabelOne.AutoSize = true;
            this.sceneOneLabelOne.BackColor = System.Drawing.Color.Black;
            this.sceneOneLabelOne.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneOneLabelOne.ForeColor = System.Drawing.Color.LightGreen;
            this.sceneOneLabelOne.Location = new System.Drawing.Point(143, 138);
            this.sceneOneLabelOne.Name = "sceneOneLabelOne";
            this.sceneOneLabelOne.Size = new System.Drawing.Size(299, 28);
            this.sceneOneLabelOne.TabIndex = 1;
            this.sceneOneLabelOne.Text = "YOU MADE YOUR HERO!";
            this.sceneOneLabelOne.Visible = false;
            // 
            // sceneOneLabelTwo
            // 
            this.sceneOneLabelTwo.AutoSize = true;
            this.sceneOneLabelTwo.BackColor = System.Drawing.Color.Black;
            this.sceneOneLabelTwo.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneOneLabelTwo.ForeColor = System.Drawing.Color.LightGreen;
            this.sceneOneLabelTwo.Location = new System.Drawing.Point(17, 166);
            this.sceneOneLabelTwo.Name = "sceneOneLabelTwo";
            this.sceneOneLabelTwo.Size = new System.Drawing.Size(550, 28);
            this.sceneOneLabelTwo.TabIndex = 2;
            this.sceneOneLabelTwo.Text = "IT\'S KINDA LAME, BUT I GUESS IT WILL WORK";
            this.sceneOneLabelTwo.Visible = false;
            // 
            // sceneOneLabelThree
            // 
            this.sceneOneLabelThree.AutoSize = true;
            this.sceneOneLabelThree.BackColor = System.Drawing.Color.Black;
            this.sceneOneLabelThree.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneOneLabelThree.ForeColor = System.Drawing.Color.LightGreen;
            this.sceneOneLabelThree.Location = new System.Drawing.Point(129, 194);
            this.sceneOneLabelThree.Name = "sceneOneLabelThree";
            this.sceneOneLabelThree.Size = new System.Drawing.Size(327, 28);
            this.sceneOneLabelThree.TabIndex = 3;
            this.sceneOneLabelThree.Text = "LET\'S PUT IT TO THE TEST";
            this.sceneOneLabelThree.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.sceneOneLabelThree);
            this.Controls.Add(this.sceneOneLabelTwo);
            this.Controls.Add(this.sceneOneLabelOne);
            this.Controls.Add(this.heroDonePictureBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heroDonePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox heroDonePictureBox;
        private System.Windows.Forms.Label sceneOneLabelOne;
        private System.Windows.Forms.Label sceneOneLabelTwo;
        private System.Windows.Forms.Label sceneOneLabelThree;
    }
}