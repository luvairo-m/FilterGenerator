using FilterGenerator.Properties;
using System.ComponentModel;

namespace FilterGenerator
{
    public partial class Form1 : Form
    {
        private Image currentImage;
        private readonly Image defaultImage = Resources.alpha;
        private const string fileMask = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";

        private readonly Dictionary<string, Type> formTypes = new()
        {
            { "Brightness", typeof(BrightnessOptions) },
            { "Contrast", typeof(ContrastOptions) },
            { "Saturation", typeof(SaturationOptions) },
            { "GrayScale", typeof(GrayScaleOptions) },
        };

        public Form1()
        {
            InitializeComponent();
            OpenFilterOptions(new BrightnessOptions());
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
            //currentFilter = (Form)Activator.CreateInstance(formTypes[filterName], new[] { currentImage });
            OpenFilterOptions((Form)Activator.CreateInstance(formTypes[filterName]));
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

            // filtering logic here
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