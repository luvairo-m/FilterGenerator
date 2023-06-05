namespace FilterGenerator
{
    public partial class BrightnessOptions : Form
    {
        public BrightnessOptions() => InitializeComponent();

        private void TrackBarScrolled(object sender, EventArgs e) =>
            label.Text = $"Current brightness: {((TrackBar)sender).Value}";
    }
}