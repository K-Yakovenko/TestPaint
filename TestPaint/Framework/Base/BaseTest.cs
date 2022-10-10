using NUnit.Framework;
using System.Diagnostics;
using TestPaint.Framework.Log;
using Application = TestPaint.Framework.App.Application;

namespace TestPaint.Framework.Base
{
    public class BaseTest
    {
        [SetUp]
        public void Init()
        {
            Process[] processes = Process.GetProcessesByName("paintdotnet");
            if (processes.Length != 0)
            {
                Application.app = TestStack.White.Application.Attach("paintdotnet");
                Nlog.log.Info($"Close application paintdotnet");
                Application.app.Close();
            }
        }

        [TearDown]
        public void Cleanup()
        {
            Nlog.log.Info($"Close application paintdotnet");
            Application.app.Close();
        }
    }
}