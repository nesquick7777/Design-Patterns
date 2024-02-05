using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProxy
{
    internal class ImageProxy : IImage
    {
        HighResolutionImage image;
        String imageURl;


        public ImageProxy(String imageURl)
        {
            this.imageURl = imageURl;
        }

        public void ShowImage()
        {
            if(this.image == null) {
                this.image = new HighResolutionImage(this.imageURl);
            }
            this.image.ShowImage();
        }
    }
}
