using System.Threading;
using AutoIt;

namespace TestPaint.Framework.Utils
{
    public class UploadFileUtil
    {
        public static void UploadImage()
        {
            var testFile = GetPath.GetImagePath();
            AutoItX.WinActivate("Открытие");
            AutoItX.Send(testFile);
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
        }
    }
}
