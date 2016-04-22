using Emgu.CV;
using Emgu.CV.Structure;
using static Dehaze;

namespace ImageProcessing
{
    public class Processing_Emgu_DarkChannel : Processing_Emgu
    {
        public override string Name
        {
            get
            {
                return "DarkChannel";
            }
        }

        protected override IImage ProcessImage_Emgu(Image<Bgr, byte> img)
        {
            return getMedianDarkChannel(img, 5);
        }
    }
}
