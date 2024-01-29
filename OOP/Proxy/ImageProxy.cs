using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ImageProxy : IImage
    {
        HighResolutionImage image = null;
        String imageURL;
        public ImageProxy(string imageURL) {
        this.imageURL = imageURL;
        }

        public void ShowImage()
        {
            if(this.image == null) {
                this.image = new HighResolutionImage(this.imageURL);
            }
            this.image.ShowImage();
        }
    }
}
