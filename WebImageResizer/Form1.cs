using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WebImageResizer
{
    public partial class Form1 : Form
    {
        private const int bytesPerPixel = 4;
        public bool switcher = false;
        string watermark = "";

        public List<Image> Images = new List<Image>();
        public List<string> files = new List<string>();

        public Form1()
        {
            InitializeComponent();
            ToolTip tooltipRatio = new ToolTip();
            tooltipRatio.SetToolTip(keepRatio, "Zachowuje współczynnik proporcji zmieniając rozmiar obrazka względem dłuższego boku");
            ToolTip tooltipHelp = new ToolTip();
            tooltipHelp.SetToolTip(helpButton, "Otwórz plik pomocy...");
            ToolTip watermark = new ToolTip();
            watermark.SetToolTip(switchBox, "Umieść znak wodny...");
        }

        public static Bitmap ChangeImageOpacity(Bitmap originalImage, double opacity)
        {
            if ((originalImage.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed)
            {
                // Cannot modify an image with indexed colors
                return originalImage;
            }

            Bitmap bmp = (Bitmap)originalImage.Clone();

            // Specify a pixel format.
            PixelFormat pxf = PixelFormat.Format32bppArgb;

            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            // This code is specific to a bitmap with 32 bits per pixels 
            // (32 bits = 4 bytes, 3 for RGB and 1 byte for alpha).
            int numBytes = bmp.Width * bmp.Height * bytesPerPixel;
            byte[] argbValues = new byte[numBytes];

            // Copy the ARGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, argbValues, 0, numBytes);

            // Manipulate the bitmap, such as changing the
            // RGB values for all pixels in the the bitmap.
            for (int counter = 0; counter < argbValues.Length; counter += bytesPerPixel)
            {
                // argbValues is in format BGRA (Blue, Green, Red, Alpha)

                // If 100% transparent, skip pixel
                if (argbValues[counter + bytesPerPixel - 1] == 0)
                    continue;

                int pos = 0;
                pos++; // B value
                pos++; // G value
                pos++; // R value

                argbValues[counter + pos] = (byte)(argbValues[counter + pos] * opacity);
            }

            // Copy the ARGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(argbValues, 0, ptr, numBytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            return bmp;
        }

        public static Image ResizeImage(Image sourceImage, int maxWidth, int maxHeight, bool ratio, bool wm, string watermark, int position, double opacity)
        {
            Bitmap watermarkImg = null;
            int newWidth, newHeight;
            if (ratio)
            {
                double xRatio = (double)sourceImage.Width / maxWidth;
                double yRatio = (double)sourceImage.Height / maxHeight;
                double ratioToResizeImage = Math.Max(xRatio, yRatio);
                newWidth = (int)Math.Floor(sourceImage.Width / ratioToResizeImage);
                newHeight = (int)Math.Floor(sourceImage.Height / ratioToResizeImage);
            }
            else
            {
                newWidth = maxWidth;
                newHeight = maxHeight;
            }
            bool rotate = false;

            Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppArgb);
            if (wm)
            {
                watermarkImg = new Bitmap(Image.FromFile(watermark));
                watermarkImg = ChangeImageOpacity(watermarkImg, opacity);
            }



            using (Graphics newGraphic = Graphics.FromImage(newImage))
            {
                newGraphic.Clear(Color.Transparent);

                newGraphic.InterpolationMode = InterpolationMode.HighQualityBicubic;

                Rectangle sourceDimensions = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);
                Rectangle destinationDimensions = new Rectangle(0, 0, newWidth, newHeight);
                newGraphic.DrawImage(sourceImage, destinationDimensions, sourceDimensions, GraphicsUnit.Pixel);

                if (wm)
                {
                    Point wmPos = new Point(0, 0);
                    if (position == 1)
                        wmPos = new Point(0, newHeight - watermarkImg.Height);
                    else if (position == 2)
                        wmPos = new Point(0, 0);
                    else if (position == 3)
                        wmPos = new Point(newWidth - watermarkImg.Width, newHeight - watermarkImg.Height);
                    else if (position == 4)
                        wmPos = new Point(newWidth - watermarkImg.Width, 0);
                    newGraphic.DrawImage(watermarkImg, wmPos);
                }
            }
            return newImage;
        }

        public static ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageEncoders().ToList().Find(delegate (ImageCodecInfo codec)
            {
                return codec.FormatID == format.Guid;
            });
        }

        private List<string> LoadFiles(string path, bool setExt)
        {
            Directory.GetFiles(path);
            List<string> pliki;
            if (setExt)
            {
                pliki = Directory.GetFiles(path, "*.jpg", SearchOption.TopDirectoryOnly).ToList<string>();
            }
            else
            {
                pliki = Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly).ToList<string>();
            }
            return pliki;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            if (setJPG.Checked)
            {
                openFile.Filter = "Plik jpg (*.jpg)|*.jpg";
            }
            else
            {
                openFile.Filter = "Plik png (*.png)|*.png";
            }
            openFile.FileName = "";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string temp = openFile.FileName;
                    files.Add(temp);
                    filesCount.Text = files.Count().ToString();
                    filesPath.Text = Path.GetDirectoryName(openFile.FileName);
                    filesLoad.Items.Add(Path.GetFileName(openFile.FileName));
                    if (files.Count() != 0)
                    {
                        setJPG.Enabled = setPNG.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd w odczytaniu pliku!");
                }
            }
        }

        private void scaleSaveButton_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            infoLabel.Text = "Sprawdzanie listy plików...";
            //saveImageBar.Value = 0;
            if (files.Count() == 0)
            {
                MessageBox.Show("Najpierw wczytaj pliki aby zmienić ich rozmiar!");
            }
            else if (otherRes.Checked && (xRes.Text == "" || yRes.Text == ""))
            {
                MessageBox.Show("Wypełnij pola x i y!!");
            }
            else
            {
                infoLabel.Text = "Sprawdzanie wybranych opcji...";
                int width = 0, height = 0;
                if (smallRes.Checked)
                {
                    if (orientation.Checked)
                    {
                        width = 480;
                        height = 640;
                    }
                    else
                    {
                        width = 640;
                        height = 480;
                    }
                }
                else if (mediumRes.Checked)
                {
                    if (orientation.Checked)
                    {
                        width = 600;
                        height = 800;
                    }
                    else
                    {
                        width = 800;
                        height = 600;
                    }
                }
                else if (highRes.Checked)
                {
                    if (orientation.Checked)
                    {
                        width = 768;
                        height = 1024;
                    }
                    else
                    {
                        width = 1024;
                        height = 768;
                    }
                }
                else if (otherRes.Checked)
                {
                    width = Convert.ToInt32(xRes.Text);
                    height = Convert.ToInt32(yRes.Text);
                }
                infoLabel.Text = "Ustawianie jakości zdjęcia do zapisu...";

                EncoderParameters parameters = new EncoderParameters(1);
                parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 50L);
                switch (fileQuality.Text)
                {
                    case "10":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 10L);
                        break;
                    case "20":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 20L);
                        break;
                    case "30":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 30L);
                        break;
                    case "40":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 40L);
                        break;
                    case "50":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 50L);
                        break;
                    case "60":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 60L);
                        break;
                    case "70":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 70L);
                        break;
                    case "80":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 80L);
                        break;
                    case "90":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 90L);
                        break;
                    case "100":
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
                        break;
                    default:
                        parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 50L);
                        break;
                }
                ImageCodecInfo codecInfo = GetEncoderInfo(ImageFormat.Jpeg);
                if (setPNG.Checked)
                {
                    codecInfo = GetEncoderInfo(ImageFormat.Png);
                }

                infoLabel.Text = "Ustawianie ścieżki do zapisu...";
                if (saveFolder.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image new_image;
                        double opacity = 1.00;
                        double value = Convert.ToDouble(files.Count());
                        value = 100 / value;
                        value = Convert.ToInt32(Math.Floor(value));
                        infoLabel.Text = "Zapisywanie zdjęć...";
                        for (int i = 0; i < files.Count(); i++)
                        {
                            //value = 100 / value;
                            //if (value < 100)
                            //{
                            //    saveImageBar.Value += Convert.ToInt32(value);
                            //}
                            //else
                            //{
                            //    saveImageBar.Value = 100;
                            //}
                            infoLabel.Text = "Zapisywanie zdjęcia: " + (i + 1).ToString()+"/"+ files.Count();
                            infoLabel.Update();
                            //saveImageBar.Update();
                            int pos = 1;
                            if (lewydol.Checked)
                                pos = 1;
                            else if (lewygor.Checked)
                                pos = 2;
                            else if (prawydol.Checked)
                                pos = 3;
                            else if (prawygor.Checked)
                                pos = 4;
                            if (setOpacity.Text == "")
                            {
                                opacity = 100;
                            }   
                            else
                            {
                                opacity = Convert.ToDouble(setOpacity.Text) * 0.01;
                            }
                            
                            new_image = ResizeImage(Image.FromFile(files[i]), width, height, keepRatio.Checked, setWatermark.Checked, watermark, pos, opacity);
                            if (setPNG.Checked)
                            {
                                new_image.Save(@saveFolder.SelectedPath + "/" + (i + 1).ToString() + "-" + fileQuality.Text + ".png", codecInfo, parameters);
                            }
                            else
                            {
                                new_image.Save(@saveFolder.SelectedPath + "/" + (i + 1).ToString() + "-" + fileQuality.Text + ".jpg", codecInfo, parameters);
                            }
                            new_image.Dispose();
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            new_image = null;
                        }
                        MessageBox.Show("Pomyślnie zmieniono rozmiar wszystkich plików!");
                        filesLoad.Items.Clear();
                        filesPath.Text = "brak";
                        filesCount.Text = "0";
                        files.Clear();
                        setJPG.Enabled = setPNG.Enabled = true;
                        setWatermark.Checked = false;
                        watermark = "";
                        waterLabel.Text = "brak";
                        lewydol.Checked = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił nieoczekiwany błąd...\n\n" + ex);
                    }
                }
            }
            loadingPanel.Visible = false;
        }

        private void uploadFolderButton_Click(object sender, EventArgs e)
        {
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                files = LoadFiles(openFolder.SelectedPath, setJPG.Checked);
                try
                {
                    for (int i = 0; i < files.Count(); i++)
                    {
                        filesCount.Text = files.Count().ToString();
                        filesPath.Text = openFolder.SelectedPath;
                        int delString = openFolder.SelectedPath.Length;
                        filesLoad.Items.Add(files[i].Remove(0, delString + 1));
                    }
                    if (files.Count() != 0)
                    {
                        setJPG.Enabled = setPNG.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd w odczytaniu pliku JPG!");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void xRes_Click(object sender, EventArgs e)
        {
            otherRes.Checked = true;
        }

        private void yRes_Click(object sender, EventArgs e)
        {
            otherRes.Checked = true;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string path = @".\help\";
            try
            {
                Directory.GetFiles(path);
                List<string> pliki;
                pliki = Directory.GetFiles(path, "help.html", SearchOption.TopDirectoryOnly).ToList<string>();
                if (pliki.Count() == 1)
                {
                    System.Diagnostics.Process.Start(path + "help.html");
                }
                else
                {
                    MessageBox.Show("Nie znaleziono pliku pomocy!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!\n\nSprawdź czy w folderze domowym aplikacji istnieje folder 'help'!");
            }
        }

        private void viewPhoto_Click(object sender, EventArgs e)
        {
            if (filesLoad.SelectedIndex < 0 || filesLoad.SelectedIndex > files.Count())
            {
                MessageBox.Show("Zaznacz plik znajdujący się na liście plików!");
            }
            else
            {
                PhotoView newWindow = new PhotoView();
                newWindow.photo.Image = Image.FromFile(files[filesLoad.SelectedIndex]);
                newWindow.photo.SizeMode = PictureBoxSizeMode.StretchImage;
                newWindow.Text += filesLoad.SelectedItem;
                newWindow.ShowDialog();
                newWindow.photo.Dispose();
                newWindow.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void saveImageBar_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 667;
        }

        void sprawdzAktualizacje()
        {
            
        }

        private void powiadomienia_BalloonTipClicked(object sender, EventArgs e)
        {
            
        }

        private void wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pokazujAktualizacje_Click(object sender, EventArgs e)
        {
            
        }

        private void uploadWatermark_Click(object sender, EventArgs e)
        {
            openWatermark.Filter = "Plik png (*.png)|*.png";
            openWatermark.FileName = "";
            openWatermark.FilterIndex = 2;
            openWatermark.RestoreDirectory = true;
            if (openWatermark.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    watermark = openWatermark.FileName;
                    waterLabel.Text = Path.GetFileName(openWatermark.FileName);
                    setWatermark.Checked = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd w odczytaniu pliku!");
                }
            }
        }

        private void setWatermark_CheckedChanged(object sender, EventArgs e)
        {
            if (setWatermark.Checked == true && watermark == "")
            {
                MessageBox.Show("Wczytaj najpierw plik znaku wodnego!");
                setWatermark.Checked = false;
            }
        }

        private void switchBox_Click(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.Width == 667)
            {
                switchBox.Text = "<";
                Form1.ActiveForm.Width = 920;
            }
            else
            {
                switchBox.Text = ">";
                Form.ActiveForm.Width = 667;
            }
        }
    }
}
