namespace calc1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bres = new Button();
            Bplus = new Button();
            Bminus = new Button();
            Bmult = new Button();
            Bdiv = new Button();
            tB = new TextBox();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            action = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Bres
            // 
            Bres.Location = new Point(639, 373);
            Bres.Name = "Bres";
            Bres.Size = new Size(149, 65);
            Bres.TabIndex = 0;
            Bres.Text = "=";
            Bres.UseVisualStyleBackColor = true;
            Bres.Click += button1_Click;
            // 
            // Bplus
            // 
            Bplus.Location = new Point(639, 302);
            Bplus.Name = "Bplus";
            Bplus.Size = new Size(149, 65);
            Bplus.TabIndex = 1;
            Bplus.Text = "+";
            Bplus.UseVisualStyleBackColor = true;
            Bplus.Click += button2_Click_1;
            // 
            // Bminus
            // 
            Bminus.Location = new Point(639, 231);
            Bminus.Name = "Bminus";
            Bminus.Size = new Size(149, 65);
            Bminus.TabIndex = 2;
            Bminus.Text = "-";
            Bminus.UseVisualStyleBackColor = true;
            Bminus.Click += button3_Click;
            // 
            // Bmult
            // 
            Bmult.Location = new Point(639, 160);
            Bmult.Name = "Bmult";
            Bmult.Size = new Size(149, 65);
            Bmult.TabIndex = 3;
            Bmult.Text = "x";
            Bmult.UseVisualStyleBackColor = true;
            Bmult.Click += button4_Click;
            // 
            // Bdiv
            // 
            Bdiv.Location = new Point(639, 89);
            Bdiv.Name = "Bdiv";
            Bdiv.Size = new Size(149, 65);
            Bdiv.TabIndex = 4;
            Bdiv.Text = ":";
            Bdiv.UseVisualStyleBackColor = true;
            Bdiv.Click += button5_Click;
            // 
            // tB
            // 
            tB.Location = new Point(12, 60);
            tB.Name = "tB";
            tB.RightToLeft = RightToLeft.Yes;
            tB.Size = new Size(776, 23);
            tB.TabIndex = 5;
            // 
            // B1
            // 
            B1.Location = new Point(12, 89);
            B1.Name = "B1";
            B1.Size = new Size(75, 65);
            B1.TabIndex = 1;
            B1.Text = "1";
            B1.UseVisualStyleBackColor = true;
            B1.Click += button6_Click;
            // 
            // B2
            // 
            B2.Location = new Point(93, 89);
            B2.Name = "B2";
            B2.Size = new Size(75, 65);
            B2.TabIndex = 6;
            B2.Text = "2";
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            // 
            // B3
            // 
            B3.Location = new Point(174, 89);
            B3.Name = "B3";
            B3.Size = new Size(75, 65);
            B3.TabIndex = 7;
            B3.Text = "3";
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 171);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(688, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // action
            // 
            action.Location = new Point(659, 31);
            action.Name = "action";
            action.Size = new Size(23, 23);
            action.TabIndex = 10;
            action.TextChanged += action_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(action);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(tB);
            Controls.Add(Bdiv);
            Controls.Add(Bmult);
            Controls.Add(Bminus);
            Controls.Add(Bplus);
            Controls.Add(Bres);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bres;
        private Button Bplus;
        private Button Bminus;
        private Button Bmult;
        private Button Bdiv;
        private TextBox tB;
        private Button B1;
        private Button B2;
        private Button B3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox action;
    }
}