using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Generator
{
    public partial class frmMain : Form
    {
        string _filename;
        Point _rectStartPoint;
        Rectangle _rect = new Rectangle();
        public Brush SelectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnChooseImage_Click(object sender, EventArgs e)
        {
            OpnFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (OpnFile.ShowDialog() == DialogResult.OK)
            {
                _filename = OpnFile.FileName;

                picBox.Image = new Bitmap(OpnFile.FileName);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            _rectStartPoint = e.Location;
            Invalidate();
        }

        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            var tempEndPoint = e.Location;
            _rect.Location = new Point(
                Math.Min(_rectStartPoint.X, tempEndPoint.X),
                Math.Min(_rectStartPoint.Y, tempEndPoint.Y));
            _rect.Size = new Size(
                Math.Abs(_rectStartPoint.X - tempEndPoint.X),
                Math.Abs(_rectStartPoint.Y - tempEndPoint.Y));
            picBox.Invalidate();
        }

        private void PicBox_Paint(object sender, PaintEventArgs e)
        {
            if (picBox.Image != null)
            {
                if (_rect.Width > 0 && _rect.Height > 0)
                {
                    e.Graphics.FillRectangle(SelectionBrush, _rect);
                }
            }
        }

        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (_rect.Contains(e.Location))
                {
                    Debug.WriteLine("Right click");
                }
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            if (fontDFontFam.ShowDialog() == DialogResult.OK)
                txtNames.Font = fontDFontFam.Font;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDFont.ShowDialog();

            txtNames.ForeColor = colorDFont.Color;
        }

        private void BtnStartGenerate_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Brush b = new SolidBrush(colorDFont.Color);

                var x = (_rect.X * picBox.Image.Width) / picBox.Width;
                var y = (_rect.Y * picBox.Image.Height) / picBox.Height;

                var w = (_rect.Width * picBox.Image.Width) / picBox.Width;
                var h = (_rect.Height * picBox.Image.Height) / picBox.Height;


                //for (int i = 0; i < SName.Length; i++)
                foreach (string n in txtNames.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var image = new Bitmap(picBox.Image);

                    var graphics = Graphics.FromImage(image);


                    var s = graphics.MeasureString(n, fontDFontFam.Font);


                    RectangleF RectF = new RectangleF(x + (w - s.Width), y, w, h);

                    graphics.DrawString(n, fontDFontFam.Font, b, RectF);

                    image.Save($"{folderBrowserDialog1.SelectedPath}\\{n}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                MessageBox.Show("Done");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fontDFontFam.Font = new Font("TimesNewRoman", 25);
            colorDFont.Color = Color.Black;
        }
    }
}
