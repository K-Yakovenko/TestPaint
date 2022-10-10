using System;
using System.IO;

namespace TestPaint.Framework.Utils
{
    public class GetPath
    {
        public static string GetImagePath()
        {
            var workingDirectory = Environment.CurrentDirectory;
            string fileName = "Penguins.jpg";
            return Path.Combine(workingDirectory, @"Resources\", fileName);
        }
    }
}
