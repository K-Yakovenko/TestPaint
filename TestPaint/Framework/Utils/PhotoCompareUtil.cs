using Codeuctivity.ImageSharpCompare;

namespace TestPaint.Framework.Utils
{
    public class PhotoCompareUtil
    {
        public static bool PhotosCompare(string firstPhoto, string secondPhoto) => 
            ImageSharpCompare.ImagesAreEqual(firstPhoto, secondPhoto);
    }
}
