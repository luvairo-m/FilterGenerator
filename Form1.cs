using FilterGenerator.Properties;

namespace FilterGenerator
{
    public partial class Form1 : Form
    {
        private Image currentImage;
        private readonly Image defaultImage = Resources.alpha;

        private readonly Dictionary<string, Type> formTypes = new()
        {
            { "Brightness", typeof(BrightnessOptions) },
            { "Contrast", typeof(ContrastOptions) },
            { "Saturation", typeof(SaturationOptions) },
        };

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            OpenFilterOptions(new BrightnessOptions());

            openFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            openFileDialog1.Title = "Image selecting";

            saveFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            saveFileDialog1.Title = "Image saving";
            //saveFileDialog1.DefaultExt = ".jpg";
            saveFileDialog1.AddExtension = true;
        }

        private void ComboboxSelectionChanged(object sender, EventArgs e)
        {
            var filterName = ((ComboBox)sender).SelectedItem.ToString();
            OpenFilterOptions((Form)Activator.CreateInstance(formTypes[filterName]));
        }

        private void AcceptFilterButtonClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("No image to accept filter on: try to open one",
                    "Filter error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            currentImage = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = currentImage;
        }

        private void SaveMenuItemClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("No image to save: try to open one",
                    "Filter error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            currentImage.Save(saveFileDialog1.FileName);

            MessageBox.Show("Image successfully saved!",
                "Saving status: success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearMenuItemClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
                return;

            pictureBox1.Image = defaultImage;
            currentImage = null;
        }
    }
}