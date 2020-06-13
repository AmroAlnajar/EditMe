using NUnit.Framework;
using EditMe;
using System;
using System.IO;

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

       
    }
}