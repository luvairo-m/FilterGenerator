namespace FilterGenerator
{
    public partial class ContrastOptions : Form
    {
        public ContrastOptions() => InitializeComponent();

        private void TrackBarScrolled(object sender, EventArgs e) =>
            label.Text = $"Current contrast: {((TrackBar)sender).Value}";
    }
}