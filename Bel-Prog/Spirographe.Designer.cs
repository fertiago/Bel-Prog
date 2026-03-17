namespace Bel_Prog
{
    partial class Spirographe
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
            SpiroGroup = new GroupBox();
            sommetsLabel = new Label();
            densiteLabel = new Label();
            profondeurLabel = new Label();
            sommetsTrackBar = new TrackBar();
            densiteTrackBar = new TrackBar();
            profondeurTrackBar = new TrackBar();
            goButton = new Button();
            traitButton = new Button();
            fondButton = new Button();
            SpiroGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sommetsTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)densiteTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profondeurTrackBar).BeginInit();
            SuspendLayout();
            // 
            // SpiroGroup
            // 
            SpiroGroup.Controls.Add(fondButton);
            SpiroGroup.Controls.Add(traitButton);
            SpiroGroup.Controls.Add(goButton);
            SpiroGroup.Controls.Add(profondeurTrackBar);
            SpiroGroup.Controls.Add(densiteTrackBar);
            SpiroGroup.Controls.Add(sommetsTrackBar);
            SpiroGroup.Controls.Add(profondeurLabel);
            SpiroGroup.Controls.Add(densiteLabel);
            SpiroGroup.Controls.Add(sommetsLabel);
            SpiroGroup.Location = new Point(12, 12);
            SpiroGroup.Name = "SpiroGroup";
            SpiroGroup.Size = new Size(220, 327);
            SpiroGroup.TabIndex = 0;
            SpiroGroup.TabStop = false;
            SpiroGroup.Text = "Spirographe";
            // 
            // sommetsLabel
            // 
            sommetsLabel.AutoSize = true;
            sommetsLabel.Location = new Point(6, 19);
            sommetsLabel.Name = "sommetsLabel";
            sommetsLabel.Size = new Size(57, 15);
            sommetsLabel.TabIndex = 0;
            sommetsLabel.Text = "Sommets";
            // 
            // densiteLabel
            // 
            densiteLabel.AutoSize = true;
            densiteLabel.Location = new Point(6, 85);
            densiteLabel.Name = "densiteLabel";
            densiteLabel.Size = new Size(46, 15);
            densiteLabel.TabIndex = 1;
            densiteLabel.Text = "Densite";
            // 
            // profondeurLabel
            // 
            profondeurLabel.AutoSize = true;
            profondeurLabel.Location = new Point(6, 151);
            profondeurLabel.Name = "profondeurLabel";
            profondeurLabel.Size = new Size(67, 15);
            profondeurLabel.TabIndex = 2;
            profondeurLabel.Text = "Profondeur";
            // 
            // sommetsTrackBar
            // 
            sommetsTrackBar.Location = new Point(6, 37);
            sommetsTrackBar.Name = "sommetsTrackBar";
            sommetsTrackBar.Size = new Size(208, 45);
            sommetsTrackBar.TabIndex = 3;
            // 
            // densiteTrackBar
            // 
            densiteTrackBar.Location = new Point(6, 103);
            densiteTrackBar.Name = "densiteTrackBar";
            densiteTrackBar.Size = new Size(208, 45);
            densiteTrackBar.TabIndex = 4;
            // 
            // profondeurTrackBar
            // 
            profondeurTrackBar.Location = new Point(6, 179);
            profondeurTrackBar.Name = "profondeurTrackBar";
            profondeurTrackBar.Size = new Size(208, 45);
            profondeurTrackBar.TabIndex = 5;
            // 
            // goButton
            // 
            goButton.Location = new Point(6, 230);
            goButton.Name = "goButton";
            goButton.Size = new Size(208, 23);
            goButton.TabIndex = 6;
            goButton.Text = "GO";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += new System.EventHandler(this.go_Click);
            // 
            // traitButton
            // 
            traitButton.Location = new Point(6, 259);
            traitButton.Name = "traitButton";
            traitButton.Size = new Size(208, 23);
            traitButton.TabIndex = 7;
            traitButton.Text = "Trait";
            traitButton.UseVisualStyleBackColor = true;
            traitButton.Click += new System.EventHandler(this.trait_Click);
            // 
            // fondButton
            // 
            fondButton.Location = new Point(6, 288);
            fondButton.Name = "fondButton";
            fondButton.Size = new Size(208, 23);
            fondButton.TabIndex = 8;
            fondButton.Text = "Fond";
            fondButton.UseVisualStyleBackColor = true;
            fondButton.Click += new System.EventHandler(this.fond_Click);
            // 
            // Spirographe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 345);
            Controls.Add(SpiroGroup);
            Name = "Spirographe";
            Text = "Spirographe";
            SpiroGroup.ResumeLayout(false);
            SpiroGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sommetsTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)densiteTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)profondeurTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SpiroGroup;
        private TrackBar densiteTrackBar;
        private TrackBar sommetsTrackBar;
        private Label profondeurLabel;
        private Label densiteLabel;
        private Label sommetsLabel;
        private TrackBar profondeurTrackBar;
        private Button goButton;
        private Button fondButton;
        private Button traitButton;
    }
}