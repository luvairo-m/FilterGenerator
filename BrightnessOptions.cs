namespace FilterGenerator
{
    public partial class BrightnessOptions : Form
    {
        public BrightnessOptions()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Current brightness: {((TrackBar)sender).Value}";
        }
    }
}