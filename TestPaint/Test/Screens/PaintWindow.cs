using TestPaint.Framework.App;
using TestPaint.Framework.Utils;
using TestStack.White.UIItems.WindowItems;

namespace TestPaint.Test.Screens
{
    public class PaintWindow
    {
        private string DontSaveButtonDialog = "Don't Save";
        public void UploadFile()
        {
            Application.SpecialKeyControl("o");
            UploadFileUtil.UploadImage();
        }
        public void SelectAll() => Application.SpecialKeyControl("a");
        public void Cut() => Application.SpecialKeyControl("x");
        public Window GetModalWindow() => Application.window.ModalWindow("Unsaved Changes");
        public void DismissButtonClick() => Application.GetElementByText(DontSaveButtonDialog).Click();
    }
}
