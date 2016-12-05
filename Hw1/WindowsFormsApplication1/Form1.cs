using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Runtime.InteropServices;
using Hw1;
using Emgu.CV.OCR;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Capture capture = null;
        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Rectangle RealImageRect = new Rectangle();
        private int thickness = 5;
        private Image<Bgr, byte> m_img = null;
        private Image<Bgr, byte> m_img_cpy = null;
        private static Tesseract _ocr;
        public Form1()
        {
            InitializeComponent();

            capture = new Capture(0);
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 480);
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 360);
            Application.Idle += new EventHandler(Application_Idle);
        }

        /* ========== Button Click Event ========== */
        private void convertToGrey_Click(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Application_Idle_Gray);
        }       

        private void convertToBinarization_Click(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Application_Idle_Binarization);
        }    

        private void sobelOperator_Click(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Application_Idle_Sobel_Operator);
        }

        private void convertToNegative_Click(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Application_Idle_Negative);
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Application_Idle_Rotate);
        }

        private void captureImage_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> frame = capture.QueryFrame();
            captureOutput.Image = frame;
            m_img = frame;
            m_img_cpy = m_img.Clone();
        }

        private void ocr_Click(object sender, EventArgs e)
        {
           try
            {
                _ocr = new Tesseract(@"D:\Program Files\EmguCV\bin\tessdata", "eng", Tesseract.OcrEngineMode.OEM_TESSERACT_CUBE_COMBINED);
                _ocr.SetVariable("tessedit_char_whitelist", "0123456789X");

                Bitmap bitmap = chooseImage.Image.Bitmap;
                string result = ORC(bitmap);
                resultTextBox.Text = result;

                _ocr.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /* ========== Aplication Idle Event ========== */
        void Application_Idle(object sender, EventArgs e)
        {
            Image<Bgr, Byte> frame = capture.QueryFrame();
            if (frame != null)
            {
                webcam.Image = frame.ToBitmap();
            }
        }

        void Application_Idle_Gray(object sender, EventArgs e)
        {
            Image<Gray, Byte> frame = new Image<Gray, byte>(capture.QueryFrame().ToBitmap());
            if (frame != null)
            {
                output.Image = frame.ToBitmap();
            }
        }

        void Application_Idle_Binarization(object sender, EventArgs e)
        {
            Gray thresholdValue = new Gray(127);

            Image<Gray, Byte> frame = new Image<Gray, byte>(capture.QueryFrame().ToBitmap());

            if (frame != null)
            {
                Image<Gray, Byte> thresholdImage = frame.ThresholdBinary(thresholdValue, new Gray(255));
                output.Image = thresholdImage.ToBitmap();
            }
        }

        void Application_Idle_Sobel_Operator(object sender, EventArgs e)
        {   
            Image<Gray, Single> frame = new Image<Gray, Single>(capture.QueryFrame().ToBitmap());            

            if (frame != null)
            {
                Image<Gray, Single> edgeImage = (frame.Sobel(1, 0, 3));

                output.Image = edgeImage.ToBitmap();
            }
        }

        void Application_Idle_Negative(object sender, EventArgs e)
        {
            Image<Bgr, Byte> frame = new Image<Bgr, byte>(capture.QueryFrame().ToBitmap());

            if (frame != null) {
                Image<Bgr, Byte> negativeImage = frame.Not();

                output.Image = negativeImage.ToBitmap();
            }
        }

        void Application_Idle_Rotate(object sender, EventArgs e)
        {
            Image<Bgr, Byte> frame = new Image<Bgr, byte>(capture.QueryFrame().ToBitmap());

            if (frame != null)
            {
                Image<Bgr, Byte> rotateImage = frame.Rotate(180, new Bgr(Color.Black));

                output.Image = rotateImage.ToBitmap();
            }
        }

        /* ========== Mouse Event ========== */
        private void webcam_MouseDown(object sender, MouseEventArgs e)
        {
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void webcam_MouseMove(object sender, MouseEventArgs e)
       {
           int X0, Y0;
            // 滑鼠座標: picture coordinates(e.X, e.Y) 
            // 影像座標: image coordinates(X0, Y0)
            Utilities.ConvertCoordinates(captureOutput, out X0, out Y0, e.X, e.Y);
           //labelPostionXY.Text = "影像座標: X:" + X0.ToString() + "  Y:" + Y0.ToString();
           //labelPicPosXY.Text = "圖片座標: X:" + e.X.ToString() + "  Y:" + e.Y.ToString();
           //Coordinates at input picture box
           if (e.Button != MouseButtons.Left)   // 如果移動中同時按下左鍵繼續往下, 否則離開
               return;
           Point tempEndPoint = e.Location;
           // ROI左上角座標 (picture coordinates)
           Rect.Location = new Point(
               Math.Min(RectStartPoint.X, tempEndPoint.X),
               Math.Min(RectStartPoint.Y, tempEndPoint.Y));
           // ROI寬度和高度 (picture coordinates)
           Rect.Size = new Size(
               Math.Abs(RectStartPoint.X - tempEndPoint.X),
               Math.Abs(RectStartPoint.Y - tempEndPoint.Y));

           Utilities.ConvertCoordinates(captureOutput, out X0, out Y0, RectStartPoint.X, RectStartPoint.Y);
           int X1, Y1;
           Utilities.ConvertCoordinates(captureOutput, out X1, out Y1, tempEndPoint.X, tempEndPoint.Y);
           RealImageRect.Location = new Point(
               Math.Min(X0, X1),
               Math.Min(Y0, Y1));
           RealImageRect.Size = new Size(
               Math.Abs(X0 - X1),
               Math.Abs(Y0 - Y1));
            m_img_cpy.ROI = System.Drawing.Rectangle.Empty;
            m_img = m_img_cpy.Clone();
            m_img.Draw(RealImageRect, new Bgr(Color.White), thickness);   // 在image上繪製ROI, 並顯示在imageBoxOutputROI
                                                                          //imageBoxOutputROI.Image = m_img;
            captureOutput.Image = m_img;

           ((PictureBox)sender).Invalidate();
       }

        private void webcam_MouseUp(object sender, MouseEventArgs e)
        {
            if (RealImageRect.Width > 0 && RealImageRect.Height > 0)
            {
                m_img_cpy.ROI = RealImageRect;
                chooseImage.Image = m_img_cpy;
            }
        }

        /* ========== Tesseract OCR ========== */
        private string ORC(Bitmap img) {
            string result = "";

            if (img == null)
                return result;
            else
            {
                Bgr drawColor = new Bgr(Color.Blue);
                try
                {
                    Image<Bgr, Byte> image = new Image<Bgr, byte>(img);

                    using (Image<Gray, byte> gray = image.Convert<Gray, Byte>())
                    {
                        _ocr.Recognize(gray);
                        Tesseract.Charactor[] charactors = _ocr.GetCharactors();
                        foreach (Tesseract.Charactor c in charactors)
                        {
                            image.Draw(c.Region, drawColor, 1);
                        }

                        result = _ocr.GetText();
                    }
                    return result;
                }
                catch (Exception ex){
                    return result;
                }
            }
        }        
    }
}
