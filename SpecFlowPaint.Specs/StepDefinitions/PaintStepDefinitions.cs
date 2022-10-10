using FluentAssertions;
using TechTalk.SpecFlow;
using TestPaint.Framework.App;
using TestPaint.Framework.Base;
using TestPaint.Framework.Utils;
using TestPaint.Test.Screens;

namespace SpecFlowPaint.Specs.StepDefinitions
{
    [Binding]
    public sealed class PaintStepDefinitions
    {
        private readonly BaseTest _baseTest;
        private readonly PaintWindow _paint;
        private int firstImage;
        private int secondImage;
        public PaintStepDefinitions(BaseTest baseTest, PaintWindow paintWindow)
        {
            _baseTest = baseTest;
            _paint = paintWindow;
        }

        [Given(@"Paint was opened")]
        public void GivenPaintWasOpened()
        {
            _baseTest.Init();
            Application.Launch();
        }

        [Given(@"Image was uploaded")]
        public void GivenImageWasUploaded()
        {
            _paint.UploadFile();
            firstImage = GetPath.GetImagePath().GetHashCode();
        }

        [Given(@"Image was cutted")]
        public void GivenImageWasCutted()
        {
            _paint.SelectAll();
            _paint.Cut();
        }

        [When(@"The user closes paint")]
        public void WhenTheUserClosesPaint()
        {
            Application.CloseWindow();
        }

        [When(@"The user doesn't save the changes")]
        public void WhenTheUserDoesntSaveTheChanges()
        {
            _paint.DismissButtonClick();
            secondImage = GetPath.GetImagePath().GetHashCode();
        }

        [Then(@"The original image is the same")]
        public void ThenTheOriginalImageIsTheSame()
        {
            firstImage.Should().Be(secondImage);
        }
    }
}