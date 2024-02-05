using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProxy
{
    internal class HighResolutionImage : IImage
    {

        private string components;

        public HighResolutionImage(String imageURL)
        {
            this.DownloadImage(imageURL);
        }


        public void DownloadImage(String imageURL)
        {
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(100);
            this.components = "Cat Image";
            Console.WriteLine("Done");
        }

        public void ShowImage()
        {
            Console.WriteLine(components);
        }
    }
}
