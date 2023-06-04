namespace FilterGenerator
{
    public partial class SaturationOptions : Form
    {
        public SaturationOptions()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Current contrast: {((TrackBar)sender).Value}";
        }
    }
}