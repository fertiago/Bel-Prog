namespace Bel_Prog
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BtnSwap = new Button();
            PictureRight = new PictureBox();
            PictureLeft = new PictureBox();
            BtnOpen = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureLeft).BeginInit();
            SuspendLayout();
            // 
            // BtnSwap
            // 
            BtnSwap.Location = new Point(327, 121);
            BtnSwap.Name = "BtnSwap";
            BtnSwap.Size = new Size(146, 73);
            BtnSwap.TabIndex = 0;
            BtnSwap.Text = "SWAP";
            BtnSwap.UseVisualStyleBackColor = true;
            BtnSwap.Click += BtnSwap_Click;
            // 
            // PictureRight
            // 
            PictureRight.Image = (Image)resources.GetObject("PictureRight.Image");
            PictureRight.Location = new Point(547, 12);
            PictureRight.Name = "PictureRight";
            PictureRight.Size = new Size(241, 456);
            PictureRight.SizeMode = PictureBoxSizeMode.Zoom;
            PictureRight.TabIndex = 1;
            PictureRight.TabStop = false;
            // 
            // PictureLeft
            // 
            PictureLeft.Image = (Image)resources.GetObject("PictureLeft.Image");
            PictureLeft.Location = new Point(12, 12);
            PictureLeft.Name = "PictureLeft";
            PictureLeft.Size = new Size(241, 456);
            PictureLeft.SizeMode = PictureBoxSizeMode.Zoom;
            PictureLeft.TabIndex = 2;
            PictureLeft.TabStop = false;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(327, 337);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(146, 75);
            BtnOpen.TabIndex = 3;
            BtnOpen.Text = "OPEN";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 480);
            Controls.Add(BtnOpen);
            Controls.Add(PictureLeft);
            Controls.Add(PictureRight);
            Controls.Add(BtnSwap);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.IndianRed;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Bel-Prog";
            ((System.ComponentModel.ISupportInitialize)PictureRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureLeft).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSwap;
        private PictureBox PictureRight;
        private PictureBox PictureLeft;
        private Button BtnOpen;
    }
}
