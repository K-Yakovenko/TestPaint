using TestPaint.Framework.Log;
using TestPaint.Framework.Utils;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using System.Threading;

namespace TestPaint.Framework.App
{
    public class Application
    {
        public static TestStack.White.Application app;
        public static Window window;

        public static void Launch()
        {
            app = TestStack.White.Application.Launch(GetData.Config.GetValue<string>("pathToApp"));
            Nlog.log.Info($"Launch application paintdotnet");
            window = app.GetWindow("Untitled - paint.net 4.3.12");
            Nlog.log.Info($"Get window of application paintdotnet");
            window.WaitWhileBusy();
        }
        public static void CloseWindow() => window.Close();
        public static UIItem GetElementByText(string text)
        {
            Nlog.log.Info($"Get element by text {text}");
            return (UIItem)window.Get(SearchCriteria.ByText(text));
        }
        public static IUIItem GetElementById(string id)
        {
            Nlog.log.Info($"Get element by id {id}");
            return window.Get(SearchCriteria.ByAutomationId(id));
        }
        public static void SpecialKeyControl(string button)
        {
            var keyboard = Application.window.Keyboard;
            keyboard.HoldKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
            keyboard.Enter(button);
            keyboard.LeaveKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
            Thread.Sleep(100);
        }
    }
}
