namespace RougueLike
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
            panel1 = new Panel();
            ButtonLeft = new Button();
            ButtonRight = new Button();
            ButtonUp = new Button();
            ButtonDown = new Button();
            PlayerCat = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlayerCat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(PlayerCat);
            panel1.Location = new Point(174, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 246);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ButtonLeft
            // 
            ButtonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonLeft.Location = new Point(472, 377);
            ButtonLeft.Name = "ButtonLeft";
            ButtonLeft.Size = new Size(94, 29);
            ButtonLeft.TabIndex = 0;
            ButtonLeft.Text = "LEFT";
            ButtonLeft.UseVisualStyleBackColor = true;
            ButtonLeft.Click += ButtonLeft_Click;
            // 
            // ButtonRight
            // 
            ButtonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonRight.Location = new Point(662, 377);
            ButtonRight.Name = "ButtonRight";
            ButtonRight.Size = new Size(94, 29);
            ButtonRight.TabIndex = 1;
            ButtonRight.Text = "RIGHT";
            ButtonRight.UseVisualStyleBackColor = true;
            ButtonRight.Click += ButtonRight_Click;
            // 
            // ButtonUp
            // 
            ButtonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonUp.Location = new Point(568, 342);
            ButtonUp.Name = "ButtonUp";
            ButtonUp.Size = new Size(94, 29);
            ButtonUp.TabIndex = 2;
            ButtonUp.Text = "UP";
            ButtonUp.UseVisualStyleBackColor = true;
            ButtonUp.Click += ButtonUp_Click;
            // 
            // ButtonDown
            // 
            ButtonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonDown.Location = new Point(568, 377);
            ButtonDown.Name = "ButtonDown";
            ButtonDown.Size = new Size(94, 29);
            ButtonDown.TabIndex = 3;
            ButtonDown.Text = "DOWN";
            ButtonDown.UseVisualStyleBackColor = true;
            ButtonDown.Click += ButtonDown_Click;
            // 
            // PlayerCat
            // 
            PlayerCat.Image = Properties.Resources.cot;
            PlayerCat.Location = new Point(114, 39);
            PlayerCat.Name = "PlayerCat";
            PlayerCat.Size = new Size(226, 176);
            PlayerCat.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCat.TabIndex = 0;
            PlayerCat.TabStop = false;
            PlayerCat.Paint += PlayerCat_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonDown);
            Controls.Add(ButtonUp);
            Controls.Add(ButtonRight);
            Controls.Add(ButtonLeft);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlayerCat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ButtonLeft;
        private Button ButtonRight;
        private Button ButtonUp;
        private Button ButtonDown;
        private PictureBox PlayerCat;
    }
}