namespace Bel_Prog
{
    partial class ClavierSouris
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
            panel = new Panel();
            clavierListBox = new ListBox();
            interceptionLabel = new Label();
            clicGaucheLabel = new Label();
            clicDroitLabel = new Label();
            positionXLabel = new Label();
            positionYLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(237, 106);
            panel.Name = "panel";
            panel.Size = new Size(466, 321);
            panel.TabIndex = 0;
            // 
            // clavierListBox
            // 
            clavierListBox.FormattingEnabled = true;
            clavierListBox.Location = new Point(12, 27);
            clavierListBox.Name = "clavierListBox";
            clavierListBox.Size = new Size(191, 364);
            clavierListBox.TabIndex = 1;
            // 
            // interceptionLabel
            // 
            interceptionLabel.AutoSize = true;
            interceptionLabel.Location = new Point(79, 9);
            interceptionLabel.Name = "interceptionLabel";
            interceptionLabel.Size = new Size(71, 15);
            interceptionLabel.TabIndex = 2;
            interceptionLabel.Text = "Interception";
            // 
            // clicGaucheLabel
            // 
            clicGaucheLabel.AutoSize = true;
            clicGaucheLabel.Location = new Point(237, 27);
            clicGaucheLabel.Name = "clicGaucheLabel";
            clicGaucheLabel.Size = new Size(69, 15);
            clicGaucheLabel.TabIndex = 3;
            clicGaucheLabel.Text = "Clic gauche";
            // 
            // clicDroitLabel
            // 
            clicDroitLabel.AutoSize = true;
            clicDroitLabel.Location = new Point(325, 27);
            clicDroitLabel.Name = "clicDroitLabel";
            clicDroitLabel.Size = new Size(56, 15);
            clicDroitLabel.TabIndex = 4;
            clicDroitLabel.Text = "Clic Droit";
            // 
            // positionXLabel
            // 
            positionXLabel.AutoSize = true;
            positionXLabel.Location = new Point(414, 27);
            positionXLabel.Name = "positionXLabel";
            positionXLabel.Size = new Size(60, 15);
            positionXLabel.TabIndex = 5;
            positionXLabel.Text = "Position X";
            // 
            // positionYLabel
            // 
            positionYLabel.AutoSize = true;
            positionYLabel.Location = new Point(508, 27);
            positionYLabel.Name = "positionYLabel";
            positionYLabel.Size = new Size(60, 15);
            positionYLabel.TabIndex = 6;
            positionYLabel.Text = "Position Y";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(325, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(414, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(69, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(508, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(69, 23);
            textBox4.TabIndex = 10;
            // 
            // ClavierSouris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(positionYLabel);
            Controls.Add(positionXLabel);
            Controls.Add(clicDroitLabel);
            Controls.Add(clicGaucheLabel);
            Controls.Add(interceptionLabel);
            Controls.Add(clavierListBox);
            Controls.Add(panel);
            Name = "ClavierSouris";
            Text = "ClavierSouris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private ListBox clavierListBox;
        private Label interceptionLabel;
        private Label clicGaucheLabel;
        private Label clicDroitLabel;
        private Label positionXLabel;
        private Label positionYLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}