using FilterGenerator.Extra;
using FilterGenerator.Filters;
using FilterGenerator.Properties;
using System.ComponentModel;
using System.Diagnostics;

namespace FilterGenerator
{
    public partial class Form1 : Form
    {
        const string secretHref = "https://www.youtube.com/watch?v=V4Zt2hZLwcY";

        private BackgroundWorker worker = new();

        private Image? currentImage;
        private Form? currentFilter;

        private readonly Image defaultImage = Resources.alpha;
        private const string fileMask = "JPG-файлы|*.jpg|PNG-файлы (*.png)|*.png|ICO-файлы|*.ico";

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
            openFileDialog.Title = "Выбор изображения";

            saveFileDialog.Filter = fileMask;
            saveFileDialog.Title = "Сохранение изображения";
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
                MessageBoxUtils.CreateErrorMessageBox("Сначала выберите изображение.",
                    "Ошибка фильтрации");
                return;
            }

            if (worker.IsBusy)
            {
                MessageBoxUtils.CreateWarningMessageBox("Дождитесь обработки изображения.",
                    "Предупреждение");
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
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                currentImage = Image.FromFile(openFileDialog.FileName);
                pictureBox.Image = currentImage;
                ComboboxSelectionChanged(comboBox1, new EventArgs());

            }
            catch
            {
                MessageBoxUtils.CreateErrorMessageBox("Неизвестная ошибка при открытии файла.",
                    "Ошибка открытия");
            }
        }

        private void SaveMenuItemClicked(object sender, EventArgs e)
        {
            try
            {
                if (currentImage == null)
                {
                    MessageBoxUtils.CreateErrorMessageBox("Нечего сохранять: изображение не выбрано.",
                        "Ошибка сохранения");
                    return;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                currentImage.Save(saveFileDialog.FileName);

                MessageBoxUtils.CreateInfoMessageBox("Изображение сохранено!",
                    "Сохранение изображения");
            }
            catch
            {
                MessageBoxUtils.CreateErrorMessageBox("Неизвестная ошибка при сохранении файла.",
                    "Ошибка сохранения");
            }
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
            try
            {
                var href = (sender as ToolStripItem).Text;
                Process.Start(new ProcessStartInfo(href) { UseShellExecute = true });
            }
            catch { }
        }

        private void DeveloperItemClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(secretHref) { UseShellExecute = true });
            }
            catch { }
        }
    }
}