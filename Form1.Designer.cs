namespace DrawingPad
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
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.fuchsiaBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.cyanBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.purpleBox = new System.Windows.Forms.PictureBox();
            this.brownBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.canvas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuchsiaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Controls.Add(this.panel1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1049, 614);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.yellowBox);
            this.panel1.Controls.Add(this.greenBox);
            this.panel1.Controls.Add(this.orangeBox);
            this.panel1.Controls.Add(this.brownBox);
            this.panel1.Controls.Add(this.cyanBox);
            this.panel1.Controls.Add(this.blueBox);
            this.panel1.Controls.Add(this.purpleBox);
            this.panel1.Controls.Add(this.blackBox);
            this.panel1.Controls.Add(this.fuchsiaBox);
            this.panel1.Controls.Add(this.redBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 72);
            this.panel1.TabIndex = 0;
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(3, 3);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(31, 29);
            this.redBox.TabIndex = 1;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // fuchsiaBox
            // 
            this.fuchsiaBox.BackColor = System.Drawing.Color.Fuchsia;
            this.fuchsiaBox.Location = new System.Drawing.Point(40, 3);
            this.fuchsiaBox.Name = "fuchsiaBox";
            this.fuchsiaBox.Size = new System.Drawing.Size(31, 29);
            this.fuchsiaBox.TabIndex = 1;
            this.fuchsiaBox.TabStop = false;
            this.fuchsiaBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Location = new System.Drawing.Point(77, 3);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(31, 29);
            this.blueBox.TabIndex = 1;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // cyanBox
            // 
            this.cyanBox.BackColor = System.Drawing.Color.Cyan;
            this.cyanBox.Location = new System.Drawing.Point(114, 3);
            this.cyanBox.Name = "cyanBox";
            this.cyanBox.Size = new System.Drawing.Size(31, 29);
            this.cyanBox.TabIndex = 1;
            this.cyanBox.TabStop = false;
            this.cyanBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Lime;
            this.greenBox.Location = new System.Drawing.Point(151, 3);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(31, 29);
            this.greenBox.TabIndex = 1;
            this.greenBox.TabStop = false;
            this.greenBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blackBox
            // 
            this.blackBox.BackColor = System.Drawing.Color.Black;
            this.blackBox.Location = new System.Drawing.Point(3, 38);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(31, 29);
            this.blackBox.TabIndex = 1;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // yellowBox
            // 
            this.yellowBox.BackColor = System.Drawing.Color.Yellow;
            this.yellowBox.Location = new System.Drawing.Point(151, 38);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(31, 29);
            this.yellowBox.TabIndex = 1;
            this.yellowBox.TabStop = false;
            this.yellowBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // purpleBox
            // 
            this.purpleBox.BackColor = System.Drawing.Color.Purple;
            this.purpleBox.Location = new System.Drawing.Point(40, 38);
            this.purpleBox.Name = "purpleBox";
            this.purpleBox.Size = new System.Drawing.Size(31, 29);
            this.purpleBox.TabIndex = 1;
            this.purpleBox.TabStop = false;
            this.purpleBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // brownBox
            // 
            this.brownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brownBox.Location = new System.Drawing.Point(77, 38);
            this.brownBox.Name = "brownBox";
            this.brownBox.Size = new System.Drawing.Size(31, 29);
            this.brownBox.TabIndex = 1;
            this.brownBox.TabStop = false;
            this.brownBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeBox.Location = new System.Drawing.Point(114, 38);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(31, 29);
            this.orangeBox.TabIndex = 1;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 614);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.canvas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuchsiaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yellowBox;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox brownBox;
        private System.Windows.Forms.PictureBox cyanBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.PictureBox purpleBox;
        private System.Windows.Forms.PictureBox blackBox;
        private System.Windows.Forms.PictureBox fuchsiaBox;
        private System.Windows.Forms.PictureBox redBox;
    }
}

