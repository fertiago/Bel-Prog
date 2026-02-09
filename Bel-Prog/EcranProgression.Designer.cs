namespace Bel_Prog
{
    partial class EcranProgression
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
            totalProgressBar = new ProgressBar();
            sequentielleProgressBar = new ProgressBar();
            debuterButton = new Button();
            quitterButton = new Button();
            totaleLabel = new Label();
            sequentielleLabel = new Label();
            SuspendLayout();
            // 
            // totalProgressBar
            // 
            totalProgressBar.Location = new Point(30, 39);
            totalProgressBar.Name = "totalProgressBar";
            totalProgressBar.Size = new Size(345, 47);
            totalProgressBar.TabIndex = 0;
            // 
            // sequentielleProgressBar
            // 
            sequentielleProgressBar.Location = new Point(28, 128);
            sequentielleProgressBar.Name = "sequentielleProgressBar";
            sequentielleProgressBar.Size = new Size(345, 47);
            sequentielleProgressBar.TabIndex = 1;
            // 
            // debuterButton
            // 
            debuterButton.Location = new Point(30, 181);
            debuterButton.Name = "debuterButton";
            debuterButton.Size = new Size(94, 29);
            debuterButton.TabIndex = 2;
            debuterButton.Text = "Debuter";
            debuterButton.UseVisualStyleBackColor = true;
            // 
            // quitterButton
            // 
            quitterButton.Location = new Point(279, 181);
            quitterButton.Name = "quitterButton";
            quitterButton.Size = new Size(94, 29);
            quitterButton.TabIndex = 3;
            quitterButton.Text = "Quitter";
            quitterButton.UseVisualStyleBackColor = true;
            // 
            // totaleLabel
            // 
            totaleLabel.AutoSize = true;
            totaleLabel.Location = new Point(28, 16);
            totaleLabel.Name = "totaleLabel";
            totaleLabel.Size = new Size(124, 20);
            totaleLabel.TabIndex = 4;
            totaleLabel.Text = "Indexation Totale";
            totaleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // sequentielleLabel
            // 
            sequentielleLabel.AutoSize = true;
            sequentielleLabel.Location = new Point(28, 105);
            sequentielleLabel.Name = "sequentielleLabel";
            sequentielleLabel.Size = new Size(165, 20);
            sequentielleLabel.TabIndex = 5;
            sequentielleLabel.Text = "Indexation Sequentielle";
            // 
            // EcranProgression
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 222);
            Controls.Add(sequentielleLabel);
            Controls.Add(totaleLabel);
            Controls.Add(quitterButton);
            Controls.Add(debuterButton);
            Controls.Add(sequentielleProgressBar);
            Controls.Add(totalProgressBar);
            Name = "EcranProgression";
            Text = "EcranProgression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar totalProgressBar;
        private ProgressBar sequentielleProgressBar;
        private Button debuterButton;
        private Button quitterButton;
        private Label totaleLabel;
        private Label sequentielleLabel;
    }
}