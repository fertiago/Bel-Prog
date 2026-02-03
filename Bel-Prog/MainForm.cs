namespace Bel_Prog
{
    public partial class MainForm : Form
    {
        private Image[] images = new Image[2];
        private int indexLeft = 0;
        private int indexRight = 1;

        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            images[0] = PictureLeft.Image;
            images[1] = PictureRight.Image;
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            int tempIndex = indexLeft;
            indexLeft = indexRight;
            indexRight = tempIndex;

            PictureLeft.Image = images[indexLeft];
            PictureRight.Image = images[indexRight];
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment quitter l'application ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            ControlsForm window = new ControlsForm();
            window.Show();
            //this.Hide();
        }
    }
}
