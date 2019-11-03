namespace BallGame
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ballBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.generate = new System.Windows.Forms.Button();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(630, 111);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(86, 29);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paddle);
            this.panel1.Controls.Add(this.ballBox);
            this.panel1.Location = new System.Drawing.Point(13, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 418);
            this.panel1.TabIndex = 1;
            // 
            // ballBox
            // 
            this.ballBox.Image = global::BallGame.Properties.Resources.ball;
            this.ballBox.Location = new System.Drawing.Point(33, 24);
            this.ballBox.Name = "ballBox";
            this.ballBox.Size = new System.Drawing.Size(61, 55);
            this.ballBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballBox.TabIndex = 0;
            this.ballBox.TabStop = false;
            this.ballBox.Click += new System.EventHandler(this.ballBox_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(634, 168);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(81, 29);
            this.generate.TabIndex = 2;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.paddle.Location = new System.Drawing.Point(165, 383);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(138, 18);
            this.paddle.TabIndex = 1;
            this.paddle.TabStop = false;
            this.paddle.Click += new System.EventHandler(this.paddle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ballBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.PictureBox paddle;
    }
}

