namespace FilterGenerator
{
    public partial class ContrastOptions : Form
    {
        public ContrastOptions()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Current contrast: {((TrackBar)sender).Value}";
        }
    }
}