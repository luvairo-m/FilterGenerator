using FilterGenerator.Filters;
using FilterGenerator.Properties;
using System.ComponentModel;
using System.Diagnostics;

namespace FilterGenerator
{
    public partial class Form1 : Form
    {
        private BackgroundWorker worker = new();

        private Image? currentImage;
        private Form? currentFilter;

        private readonly Image defaultImage = Resources.alpha;
        private const string fileMask = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";

        private readonly Dictionary<string, Type> formTypes = new()
        {
            { "Яркость", typeof(BrightnessOptions) },
            { "Контрастность", typeof(ContrastOptions) },
            { "Оттенки серого", typeof(GrayScaleOptions) },
            { "Инверсия цветов", typeof(NegativeOptions) },
            { "Размытие", typeof(BlurOptions) },
            { "Повышение качества", typeof(QualityOptions) },
            { "Прозрачность", typeof(AlphaOptions) },
            { "Лапласское тиснение", typeof(EmbossOptions) },
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

            worker.WorkerReportsProgress = true;
            worker.DoWork += AsyncImageFiltration;
            worker.ProgressChanged += ProgressChanged;
            worker.RunWorkerCompleted += FiltrationCompleted;
        }

        public void ChangeImage(Image image)
        {
            currentImage = image;
            pictureBox.Image = image;
        }

        private void FiltrationCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Visible = false;
        }

        private void ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 100)
                return;

            progressBar.Value = e.ProgressPercentage;

            if (progressBar.Value > 1)
                progressBar.Value = e.ProgressPercentage - 1;
        }

        private void AsyncImageFiltration(object? sender, DoWorkEventArgs e)
        {
            currentImage = ((IFilter)currentFilter!).GetFilteredImage(currentImage!);
            pictureBox.Image = currentImage;
        }

        private void ComboboxSelectionChanged(object sender, EventArgs e)
        {
            var filterName = ((ComboBox)sender).SelectedItem.ToString();
            currentFilter = (Form)Activator.CreateInstance(formTypes[filterName!], new object[] { worker, this })!;
            OpenFilterOptions(currentFilter!);
        }

        private void AcceptFilterButtonClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show(
                    "Сначала выберите изображение.",
                    "Ошибка фильтрации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (worker.IsBusy)
            {
                MessageBox.Show(
                    "Дождитесь обработки изображения.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            progressBar.Visible = true;
            worker.RunWorkerAsync();
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
            ComboboxSelectionChanged(comboBox1, new EventArgs());
        }

        private void SaveMenuItemClicked(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show(
                    "Нечего сохранять: изображение не выбрано.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            currentImage.Save(saveFileDialog.FileName);

            MessageBox.Show(
                "Изображение сохранено!",
                "Сохранение изображения",
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

        private void RepositoryHrefClicked(object sender, EventArgs e)
        {
            var href = (sender as ToolStripItem).Text;
            Process.Start(new ProcessStartInfo(href) { UseShellExecute = true });
        }
    }
}