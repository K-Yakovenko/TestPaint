namespace TestPaint.Framework.Utils
{
    public class ImageHashCodeUtil
    {
        public static int GetImageHashCode(string imagePath) => imagePath.GetHashCode();
    }
}
