using System;
using System.Drawing;
using System.IO;

namespace EditMe
{
    public static class ImageEditor
    {
        public static Bitmap ResizeImage(String path, int width, int height)
        {
            var originalImage = Image.FromFile(path);

            return new Bitmap(originalImage, new Size(width, height)); 
        }


        public static Bitmap RotateImage(String path, RotateFlipType rotation)
        {

            var originalImage = Image.FromFile(path);
            
            originalImage.RotateFlip(rotation);

            return new Bitmap(originalImage);
        }

        /// <summary>
        /// Returns a Bitmap image with a timestamp consisting of the current date and time
        /// </summary>
        public static Bitmap AddTimestamp(String imagePath, PointF location, Brush color)
        {
            var image = new Bitmap(imagePath);

            var graphicsObject = Graphics.FromImage(image);
            
            graphicsObject.DrawString(DateTime.Now.ToString(), new Font("Arial", 10), color, location);

            return image;
        }





    }
}
