using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconMaker
{
    public partial class Form1 : Form
    {
        private string currentDirectory;
        private string exportDirFile;
        public Form1()
        {
            InitializeComponent();
        }
        private void SetButtonBorders(Color color, int size)
        {
            Button[] btns = { selectExportDirBtn, selectFileBtn };
            foreach (Button btn in btns)
            {
                btn.FlatAppearance.BorderColor = color;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            exportDirFile = Path.Combine(@currentDirectory, "exportDir.txt");
            SetButtonBorders(Color.BlueViolet, 5);
        }
        private string GetExportPath()
        {
            if (File.Exists(exportDirFile))
            {
                string dir = File.ReadAllText(exportDirFile);
                if (Directory.Exists(dir)) return dir;
            }
            return @"C:\";
        }
        private void selectFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string uniqueName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".ico";
                string icoFilesDir = GetExportPath();
                string fullPath = Path.Combine(icoFilesDir, uniqueName);
                using (FileStream stream = File.OpenWrite(fullPath))
                {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    Bitmap resizedImage = ResizeImage(image, 128);
                    Icon.FromHandle(resizedImage.GetHicon()).Save(stream);
                    return;
                }
            };
        }
        private void selectExportDir(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                if (Directory.Exists(path)) File.WriteAllText(exportDirFile, path);
                else MessageBox.Show("Directory doesn't exist");
            };
        }
        public static Bitmap ResizeImage(Image image, int size)
        {
            var destRect = new Rectangle(0, 0, size, size);
            var destImage = new Bitmap(size, size);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}