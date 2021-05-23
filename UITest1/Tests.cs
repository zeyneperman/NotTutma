using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> GirisButton = c => c.Marked("GirişButonu");
        static readonly Func<AppQuery, AppQuery> EmailEditor = c => c.Marked("EmailEditor").Text("");
        static readonly Func<AppQuery, AppQuery> ŞifreEditor = c => c.Marked("ŞifreEditor").Text("");

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] result = app.Query(EmailEditor);
            AppResult[] result1 = app.Query(ŞifreEditor);

            app.Tap(GirisButton);

            result = app.Query(EmailEditor);
            Assert.IsEmpty(result, "Email boş döndürülemez!");

            result1 = app.Query(ŞifreEditor);
            Assert.IsEmpty(result, "Şifre boş döndürülemez!");


            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");

            //Assert.IsTrue(results.Any());
        }
    }
}
