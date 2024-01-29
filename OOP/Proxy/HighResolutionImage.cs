using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class HighResolutionImage : IImage
    {
        String contents = "";

        public HighResolutionImage(string imageURL)
        {
            this.DownloadImage(imageURL);
        }

        private void DownloadImage(string imageURL)
        {
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(2000);
            this.contents = "Cat picture.";
            Console.WriteLine("Done");
        }

        public void ShowImage()
        {
            Console.WriteLine(contents);
        }
    }
}
