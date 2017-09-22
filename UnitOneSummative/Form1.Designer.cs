namespace UnitOneSummative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heroLabel = new System.Windows.Forms.Label();
            this.drawHeroPictureBox = new System.Windows.Forms.PictureBox();
            this.drawHereLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.heroDonePictureBox = new System.Windows.Forms.PictureBox();
            this.blackButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.penSizeSelector = new System.Windows.Forms.NumericUpDown();
            this.penSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawHeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroDonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // heroLabel
            // 
            this.heroLabel.AutoSize = true;
            this.heroLabel.BackColor = System.Drawing.Color.Transparent;
            this.heroLabel.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroLabel.ForeColor = System.Drawing.Color.White;
            this.heroLabel.Location = new System.Drawing.Point(143, 21);
            this.heroLabel.Name = "heroLabel";
            this.heroLabel.Size = new System.Drawing.Size(294, 32);
            this.heroLabel.TabIndex = 0;
            this.heroLabel.Text = "CREATE YOUR HERO";
            // 
            // drawHeroPictureBox
            // 
            this.drawHeroPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.drawHeroPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawHeroPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawHeroPictureBox.Location = new System.Drawing.Point(165, 75);
            this.drawHeroPictureBox.Name = "drawHeroPictureBox";
            this.drawHeroPictureBox.Size = new System.Drawing.Size(256, 256);
            this.drawHeroPictureBox.TabIndex = 1;
            this.drawHeroPictureBox.TabStop = false;
            this.drawHeroPictureBox.Click += new System.EventHandler(this.drawHeroPictureBox_Click);
            this.drawHeroPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawHeroPictureBox_MouseDown);
            this.drawHeroPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawHeroPictureBox_MouseMove);
            this.drawHeroPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawHeroPictureBox_MouseUp);
            // 
            // drawHereLabel
            // 
            this.drawHereLabel.AutoSize = true;
            this.drawHereLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawHereLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHereLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.drawHereLabel.Location = new System.Drawing.Point(226, 196);
            this.drawHereLabel.Name = "drawHereLabel";
            this.drawHereLabel.Size = new System.Drawing.Size(135, 22);
            this.drawHereLabel.TabIndex = 2;
            this.drawHereLabel.Text = "[DRAW HERE]";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(427, 149);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(427, 178);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // heroDonePictureBox
            // 
            this.heroDonePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.heroDonePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroDonePictureBox.Location = new System.Drawing.Point(443, 12);
            this.heroDonePictureBox.Name = "heroDonePictureBox";
            this.heroDonePictureBox.Size = new System.Drawing.Size(128, 128);
            this.heroDonePictureBox.TabIndex = 5;
            this.heroDonePictureBox.TabStop = false;
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.blackButton.Location = new System.Drawing.Point(84, 91);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(75, 23);
            this.blackButton.TabIndex = 6;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(84, 120);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(75, 23);
            this.whiteButton.TabIndex = 7;
            this.whiteButton.Text = "White";
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Brown;
            this.redButton.Location = new System.Drawing.Point(84, 149);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(75, 23);
            this.redButton.TabIndex = 8;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Coral;
            this.orangeButton.Location = new System.Drawing.Point(84, 178);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(75, 23);
            this.orangeButton.TabIndex = 9;
            this.orangeButton.Text = "Orange";
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.SpringGreen;
            this.greenButton.Location = new System.Drawing.Point(84, 207);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(75, 23);
            this.greenButton.TabIndex = 10;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.SteelBlue;
            this.blueButton.Location = new System.Drawing.Point(84, 236);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(75, 23);
            this.blueButton.TabIndex = 11;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.MediumPurple;
            this.purpleButton.Location = new System.Drawing.Point(84, 265);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(75, 23);
            this.purpleButton.TabIndex = 12;
            this.purpleButton.Text = "Purple";
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.LightPink;
            this.pinkButton.Location = new System.Drawing.Point(84, 294);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(75, 23);
            this.pinkButton.TabIndex = 13;
            this.pinkButton.Text = "Pink";
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // penSizeSelector
            // 
            this.penSizeSelector.Location = new System.Drawing.Point(427, 207);
            this.penSizeSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSizeSelector.Name = "penSizeSelector";
            this.penSizeSelector.Size = new System.Drawing.Size(75, 20);
            this.penSizeSelector.TabIndex = 15;
            this.penSizeSelector.Tag = "Pen Size";
            this.penSizeSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSizeSelector.ValueChanged += new System.EventHandler(this.penSizeSelector_ValueChanged);
            // 
            // penSizeLabel
            // 
            this.penSizeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.penSizeLabel.Location = new System.Drawing.Point(428, 209);
            this.penSizeLabel.Name = "penSizeLabel";
            this.penSizeLabel.Size = new System.Drawing.Size(57, 15);
            this.penSizeLabel.TabIndex = 16;
            this.penSizeLabel.Text = "Pen Size";
            this.penSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.penSizeLabel);
            this.Controls.Add(this.penSizeSelector);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.heroDonePictureBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawHereLabel);
            this.Controls.Add(this.drawHeroPictureBox);
            this.Controls.Add(this.heroLabel);
            this.Name = "Form1";
            this.Text = "Interactive Greeting Card";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawHeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroDonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroLabel;
        private System.Windows.Forms.PictureBox drawHeroPictureBox;
        private System.Windows.Forms.Label drawHereLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.PictureBox heroDonePictureBox;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.NumericUpDown penSizeSelector;
        private System.Windows.Forms.Label penSizeLabel;
    }
}

