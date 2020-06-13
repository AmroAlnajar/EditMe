using System;
using System.Drawing;

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



    }
}
