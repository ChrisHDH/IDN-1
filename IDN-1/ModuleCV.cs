using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using System.Windows;
using Emgu.CV.CvEnum;

namespace IDN_1
{
    class ModuleCV
    {
        DispatcherTimer timer;
        Emgu.CV.VideoCapture camCapture;
        Form1 Frm = new Form1();
        //static int xSize = 640;
        //static int ySize = 480;
        static int xSize = 1280;
        static int ySize = 720;
        //----------------------------------------------------------------- 
        // get the image sizes 
        Image<Bgr, Byte> currentFrame = new Image<Bgr, Byte>(xSize, ySize);
        Image<Bgr, Byte> imgSrc = new Image<Bgr, Byte>(xSize, ySize);

        Image<Gray, Byte> imgGray = new Image<Gray, Byte>(xSize, ySize);
        Image<Gray, Byte> imgView = new Image<Gray, Byte>(xSize, ySize);



        Image<Gray, Byte> imgCurrent = new Image<Gray, Byte>(xSize,ySize);
        Image<Gray, Byte> imgLast = new Image<Gray, Byte>(xSize, ySize);
        Image<Gray, Byte> imgDiff = new Image<Gray, Byte>(xSize, ySize);
        Image<Gray, Byte> imgGrayFocused = new Image<Gray, Byte>(xSize, ySize);

        Image<Gray, Byte> imgThreshold = new Image<Gray, Byte>(xSize, ySize);
        
        int intFrames = 0;
        DenseHistogram histo = new DenseHistogram(256, new RangeF(0, 255));

        int matIOut = 1;
        int matJOut = 1;


        public void Startup(Form1 MainForm)
        {
            //camCapture = new Emgu.CV.VideoCapture(0);
            camCapture = new VideoCapture("c:\\xm\\imgSrc\\sany0001.mp4");
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Start();
            Frm = MainForm;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            long detectionTime = 0;
            
            Image<Bgr, Byte> currentFrame = camCapture.QueryFrame().ToImage<Bgr, Byte>();

            if (currentFrame != null)
            {
                //-- Raw Image info ---------------------------------------------------------------------------------------------
                Frm.Columns.Text = "Columns: " + currentFrame.Cols.ToString();
                Frm.Rows.Text = "Rows: " + currentFrame.Rows.ToString();
                Frm.Depth.Text = "Depth: " + " Unknown";
                Frm.Channels.Text = "Channels: " + currentFrame.NumberOfChannels;
                Frm.Frames.Text = "Frames: " + intFrames.ToString();
                Frm.imageBox1.Image = currentFrame;                
                intFrames = intFrames + 1;

                // Copy to imgSrc
                currentFrame.CopyTo(imgSrc);
                // Gray Image 
                imgGray = imgSrc.Convert<Gray, Byte>();

                imgGray._EqualizeHist();

                histo.Calculate(new Image<Gray, byte>[] { imgGray }, false, null);

                Mat m = new Mat();
                histo.CopyTo(m);

                Frm.HistBox.ClearHistogram();
                Frm.HistBox.AddHistogram("Gray", System.Drawing.Color.Blue, m, 255, new float[] { 0, 256 });
                Frm.HistBox.Refresh();

                // Do Stuff
                Track1(imgCurrent, imgLast, imgGray, imgDiff, imgThreshold, imgView, imgGrayFocused, intFrames, matIOut, matJOut, out matIOut, out matJOut);




                Frm.imageBox2.Image = imgGrayFocused;
                Frm.imageBox3.Image = imgDiff;
                Frm.imageBox4.Image = imgThreshold;

                // Google to find image match

            }

        }

        // -- Functions --------------------------------------------------------------------------------
        public static void Track1(Emgu.CV.Image<Gray, Byte> imgCurrent, Emgu.CV.Image<Gray, Byte> imgLast, Emgu.CV.Image<Gray, Byte> imgGray, Emgu.CV.Image<Gray, Byte> imgDiff, Emgu.CV.Image<Gray, Byte> imgThreshold, Emgu.CV.Image<Gray, Byte> imgView, Emgu.CV.Image<Gray, Byte> imgGrayFocused, int intFrames, int matIIn, int matJIn, out int matIOut, out int matJOut)
        {
            Mat mat = new Mat();
            int FocusSize = 120;
            double matSum = 0;
            double matMaxSum = 0;
            byte PixelValue;
            int matI = matIIn;
            int matJ = matJIn;

            // Shuffle frames
            imgCurrent.CopyTo(imgLast);
            imgGray.CopyTo(imgCurrent);
            if (imgDiff == null)
                imgCurrent.CopyTo(imgDiff);
            if (imgLast == null)
                imgLast.CopyTo(imgDiff);

            // Calculate diff
            CvInvoke.AbsDiff(imgCurrent, imgLast, imgDiff);

            // Threshold 
            CvInvoke.Threshold(imgDiff, imgThreshold, 150, 255, 0);


            // Pick a spot to focus on
            //double minVal = 0, maxVal = 0;
            //System.Drawing.Point minLoc = new System.Drawing.Point(0, 0);
            //System.Drawing.Point maxLoc = new System.Drawing.Point(0, 0);

            //CvInvoke.MinMaxLoc(imgThreshold, ref minVal, ref maxVal, ref minLoc, ref maxLoc, null);



            if (intFrames % 5 == 0)
            {
                matSum = 0;
                matMaxSum = 0;
                //matI = 1;
                //matJ = 1;

                mat = imgThreshold.Mat;
                for (int i = 0; i <= mat.Cols - FocusSize - 1; i = i + (FocusSize / 2))
                {
                    for (int j = 0; j <= mat.Rows - FocusSize - 1; j = j + (FocusSize / 2))
                    {
                        //  sum mat
                        matSum = 0;
                        for (int k = 0; k < FocusSize; k++)
                        {
                            for (int l = 0; l < FocusSize; l++)
                            {
                                PixelValue = imgThreshold.Data[j + l, i + k, 0];
                                matSum = matSum + Convert.ToInt32(PixelValue);
                            }
                        }
                        if (matMaxSum < matSum)
                        {
                            matMaxSum = matSum;
                            matI = i;
                            matJ = j;
                        }
                    }
                }
            }
            // every other frame

            // Got Google to find image match

            // Blur Image
            System.Drawing.Size BSize = new System.Drawing.Size();
            BSize.Height = 51;
            BSize.Width = 51;
            CvInvoke.GaussianBlur(imgGray, imgView, BSize, 13, 0);
            // Get ROI 
            System.Drawing.Rectangle Rect = new System.Drawing.Rectangle();
            Rect.X = matI;
            Rect.Y = matJ;
            Rect.Height = FocusSize;
            Rect.Width = FocusSize;

            System.Drawing.Rectangle Rect2 = new System.Drawing.Rectangle();
            Rect2.X = matI-5;
            Rect2.Y = matJ-5;
            Rect2.Height = FocusSize+10;
            Rect2.Width = FocusSize+10;


            CvInvoke.Rectangle(imgGrayFocused, Rect2, new Gray(0).MCvScalar, 5);
            imgGray.ROI = Rect;
            imgView.CopyTo(imgGrayFocused);
            imgGrayFocused.ROI = Rect;
            imgGray.CopyTo(imgGrayFocused);
            CvInvoke.cvResetImageROI(imgGray);
            CvInvoke.cvResetImageROI(imgGrayFocused);

            matIOut = matI;
            matJOut = matJ;


        }
        
        public static void Detect(IInputArray image, String faceFileName, String eyeFileName, List<Rectangle> faces, List<Rectangle> eyes, out long detectionTime)
        {
            Stopwatch watch;

            using (InputArray iaImage = image.GetInputArray())
            {

                {
                    //Read the HaarCascade objects
                    using (CascadeClassifier face = new CascadeClassifier(faceFileName))
                    using (CascadeClassifier eye = new CascadeClassifier(eyeFileName))
                    {
                        watch = Stopwatch.StartNew();

                        using (UMat ugray = new UMat())
                        {
                            CvInvoke.CvtColor(image, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                            //normalizes brightness and increases contrast of the image
                            CvInvoke.EqualizeHist(ugray, ugray);

                            //Detect the faces  from the gray scale image and store the locations as rectangle
                            //The first dimensional is the channel
                            //The second dimension is the index of the rectangle in the specific channel                     
                            Rectangle[] facesDetected = face.DetectMultiScale(ugray, 1.1, 10, new System.Drawing.Size(20, 20));

                            faces.AddRange(facesDetected);

                            foreach (Rectangle f in facesDetected)
                            {
                                //Get the region of interest on the faces
                                using (UMat faceRegion = new UMat(ugray, f))
                                {
                                    Rectangle[] eyesDetected = eye.DetectMultiScale(faceRegion, 1.1, 10, new System.Drawing.Size(20, 20));

                                    foreach (Rectangle e in eyesDetected)
                                    {
                                        Rectangle eyeRect = e;
                                        eyeRect.Offset(f.X, f.Y);
                                        eyes.Add(eyeRect);
                                    }
                                }
                            }
                        }
                        watch.Stop();
                    }
                }
                detectionTime = watch.ElapsedMilliseconds;
            }
        }

        [DllImport("gdi32")]
        private static extern int DeleteObject(IntPtr o);

        public static BitmapSource ToBitmapSource(IImage image)
        {
            using (System.Drawing.Bitmap source = image.Bitmap)
            {
                IntPtr ptr = source.GetHbitmap(); //obtain the Hbitmap

                BitmapSource bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ptr, IntPtr.Zero, Int32Rect.Empty, System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());

                DeleteObject(ptr); //release the HBitmap
                return bs;
            }
        }

    }
}
