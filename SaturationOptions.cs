namespace FilterGenerator
{
    public partial class SaturationOptions : Form
    {
        public SaturationOptions() => InitializeComponent();

        private void TrackBarScrolled(object sender, EventArgs e) =>
            label.Text = $"Current contrast: {((TrackBar)sender).Value}";
    }
}