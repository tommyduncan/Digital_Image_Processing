using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw1
{
    class Utilities
    {
        public static void ConvertCoordinates(PictureBox pic, out int xi, out int yi, int xp, int yp)
           {
               int pic_hgt = pic.ClientSize.Height;
               int pic_wid = pic.ClientSize.Width;
               int img_hgt = pic.Image.Height;
               int img_wid = pic.Image.Width;
    
               xi = xp;
               yi = yp;
               switch (pic.SizeMode)
               {
                   case PictureBoxSizeMode.AutoSize:
                       break;
                   case PictureBoxSizeMode.Normal:
                       break;
                   case PictureBoxSizeMode.CenterImage:
                       xi = xp - (pic_wid - img_wid) / 2;
                       yi = yp - (pic_hgt - img_hgt) / 2;
                       break;
                   case PictureBoxSizeMode.StretchImage:      // 目前使用中
                       // image coordinates(xi, yi),  picture coordinates(xp, yp)
                       xi = (int)(img_wid* xp / (float)pic_wid);
                       yi = (int)(img_hgt* yp / (float)pic_hgt);
                       break;
                   case PictureBoxSizeMode.Zoom:
                       float pic_aspect = pic_wid / (float)pic_hgt;
                       float img_aspect = img_wid / (float)img_wid;
                       if (pic_aspect > img_aspect)
                       {
                           // The PictureBox is wider/shorter than the image.
                           yi = (int)(img_hgt* yp / (float)pic_hgt);
    
                           // The image fills the height of the PictureBox.
                           // Get its width.
                           float scaled_width = img_wid * pic_hgt / img_hgt;
                           float dx = (pic_wid - scaled_width) / 2;
                           xi = (int)((xp - dx) * img_hgt / (float)pic_hgt);
                       }
                       else
                       {
                           // The PictureBox is taller/thinner than the image.
                           xi = (int)(img_wid* xp / (float)pic_wid);
    
                           // The image fills the height of the PictureBox.
                           // Get its height.
                           float scaled_height = img_hgt * pic_wid / img_wid;
                           float dy = (pic_hgt - scaled_height) / 2;
                           yi = (int)((yp - dy) * img_wid / pic_wid);
                       }
                       break;
               }
           }
    }
}
