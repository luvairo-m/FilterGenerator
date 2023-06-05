using FilterGenerator.Properties;

namespace FilterGenerator
{
    public partial class Form1 : Form
    {
        private Image currentImage;
        private Form currentFilter;

        private readonly Image defaultImage = Resources.alpha;
        private const string fileMask = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";

        private readonly Dictionary<string, Type> formTypes = new()
        {
            { "Brightness filter", typeof(BrightnessOptions) },
            { "Contrast filter", typeof(ContrastOptions) },
            { "GrayScale filter", typeof(GrayScaleOptions) },
            { "Negative filter", typeof(NegativeOptions) },
            { "Blur filter", typeof(BlurOptions) },
        };

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            openFileDialog.Filter = fileMask;
            openFileDialog.Title = "Image selecting";

            saveFileDialog.Filter = fileMask;
            saveFileDialog.Title = "Image saving";
            saveFileDialog.AddExtension = true;
            saveFileDialog.OverwritePrompt = true;

            stretchToolStripMenuItem.Checked = true;
        }

        private void ComboboxSelectionChanged(object sender, EventArgs e)
        {
            var filterName = ((ComboBox)sender).SelectedItem.ToString();
            currentFilter = (Form)Activator.CreateInstance(formTypes[filterName]);
            OpenFilterOptions(currentFilter);
        }

        private void AcceptFilterButtonClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show(
                    "No image to accept filter on: try to open one",
                    "Filter error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            currentImage = ((IFilter)currentFilter).GetFilteredImage(currentImage);
            pictureBox.Image = currentImage;
        }

        private void OpenFilterOptions(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            optionsPanel.Controls.Clear();
            optionsPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void OpenMenuItemClicked(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            currentImage = Image.FromFile(openFileDialog.FileName);
            pictureBox.Image = currentImage;
        }

        private void SaveMenuItemClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show(
                    "No image to save: try to open one",
                    "Filter error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            currentImage.Save(saveFileDialog.FileName);

            MessageBox.Show(
                "Image successfully saved!",
                "Saving status: success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ClearMenuItemClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
                return;

            pictureBox.Image = defaultImage;
            currentImage = null;
        }

        private void ZoomMenuItemClicked(object sender, EventArgs e)
        {
            var toolItem = (ToolStripMenuItem)sender;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            (stretchToolStripMenuItem.Checked, toolItem.Checked) = (false, true);
        }

        private void StretchMenuItemClicked(object sender, EventArgs e)
        {
            var toolItem = (ToolStripMenuItem)sender;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            (zoomToolStripMenuItem.Checked, toolItem.Checked) = (false, true);
        }
    }
}