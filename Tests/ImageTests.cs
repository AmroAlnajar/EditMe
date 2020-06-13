using NUnit.Framework;
using EditMe;
using System;
using System.IO;
using System.Drawing;

namespace Tests
{
    public class ImageTests
    {
        static string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\testImage.jpg"));


         [Test]
        public void Should_Resize_Image_When_Called()
        {
            var width = 233;
            var height = 300;

            var newImage = ImageEditor.ResizeImage(path, width,height);        

            Assert.AreEqual(newImage.Width, width);
            Assert.AreEqual(newImage.Height, height);

        }

        [Test]
        public void Should_Rotate_Image_When_Called()
        {
            var originalWidth = Image.FromFile(path).Width;
            var originalHeight = Image.FromFile(path).Height;

            var rotatedImage = ImageEditor.RotateImage(path, RotateFlipType.Rotate90FlipNone);

            Assert.AreNotEqual(originalWidth, rotatedImage.Width);
            Assert.AreNotEqual(originalHeight, rotatedImage.Height);
            Assert.AreEqual(originalWidth, rotatedImage.Height);
            Assert.AreEqual(originalHeight, rotatedImage.Width);
            
        }

       
    }
}