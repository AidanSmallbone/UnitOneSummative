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
            this.h = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawHeroPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heroLabel
            // 
            this.heroLabel.AutoSize = true;
            this.heroLabel.BackColor = System.Drawing.Color.Transparent;
            this.heroLabel.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroLabel.ForeColor = System.Drawing.Color.White;
            this.heroLabel.Location = new System.Drawing.Point(143, 25);
            this.heroLabel.Name = "heroLabel";
            this.heroLabel.Size = new System.Drawing.Size(294, 32);
            this.heroLabel.TabIndex = 0;
            this.heroLabel.Text = "CREATE YOUR HERO";
            // 
            // drawHeroPictureBox
            // 
            this.drawHeroPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.drawHeroPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawHeroPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawHeroPictureBox.Location = new System.Drawing.Point(165, 79);
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
            this.clearButton.Location = new System.Drawing.Point(84, 195);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(427, 196);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(75, 23);
            this.h.TabIndex = 4;
            this.h.Text = "Done";
            this.h.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.h);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawHereLabel);
            this.Controls.Add(this.drawHeroPictureBox);
            this.Controls.Add(this.heroLabel);
            this.Name = "Form1";
            this.Text = "Interactive Greeting Card";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawHeroPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroLabel;
        private System.Windows.Forms.PictureBox drawHeroPictureBox;
        private System.Windows.Forms.Label drawHereLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button h;
    }
}

