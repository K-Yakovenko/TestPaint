using NUnit.Framework;
using TestPaint.Framework.App;
using TestPaint.Framework.Base;
using TestPaint.Framework.Utils;
using TestPaint.Test.Screens;

namespace TestPaint.Test.Tests
{
    [TestFixture]
    public class Tests: BaseTest
    {
        private readonly PaintWindow paint = new PaintWindow();
        [Test]
        public void TestCase()
        {
            Application.Launch();
            Assert.IsNotNull(Application.app, "Application isn't open");
            paint.UploadFile();
            var firstImage = GetPath.GetImagePath().GetHashCode();
            paint.SelectAll();
            paint.Cut();
            Application.window.Close();
            Assert.IsNotNull(paint.GetModalWindow(), "Window isn't exist");
            paint.DismissButtonClick();
            var secondImage = GetPath.GetImagePath().GetHashCode();
            Assert.AreEqual(firstImage, secondImage, "Images are different");
        }
    }
}