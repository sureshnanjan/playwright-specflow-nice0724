using HerokuAppOperations;
using Microsoft.Playwright;
using System.Runtime.CompilerServices;
namespace HerokuAppSystemTest
{
    [TestClass]
    public class HerokuAppTests
    {
        [TestMethod]
        public void PlaywrightTest()
        {
            PlaywrightBasicDemo pbdDemo = new PlaywrightBasicDemo();

        }
        [TestMethod]
        public void HomePage_Title_Is_Correct()
        {
            /// A
            IHomePageOperations aut;
            string expectedResult = "Welcome to the-internet";
            /// A
            //string actualTitle = aut.GetTitle();
            /// A
            //Assert.AreEqual(expectedResult, actualTitle);
        }
        [TestMethod]
        public void HomePage_Title_SubTitle_Is_Correct()
        {
        }
        [TestMethod]
        public void HomePage_Has_Correct_Number_of_Examples()
        {
            IHomePageOperations aut;
            int expectedResult = 44;
            //int actualCount = (aut.GetAvailableExamples()).Length;
        }

        [TestMethod]
        public void HomePage_can_navigate_to_Example()
        {
            IHomePageOperations aut;
            string expectedTitle = "Opening a new window";
            //aut.GoToExample("multiple windows");
            //string actualTitle = aut.GetTitle();
        }

        [TestMethod]
        public async Task MyTest()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();
            var Page = await context.NewPageAsync();
            await Page.GotoAsync("https://the-internet.herokuapp.com/");
            await Page.GetByRole(AriaRole.Heading, new() { Name = "Welcome to the-internet" }).ClickAsync(new LocatorClickOptions
            {
                Button = MouseButton.Right,

            });
            string? title = await Page.GetByRole(AriaRole.Heading, new() { Name = "Welcome to the-internet" }).TextContentAsync();
            await Page.GetByRole(AriaRole.Heading, new() { Name = "Available Examples" }).ClickAsync(new LocatorClickOptions
            {
                Button = MouseButton.Right,
            });
            await Page.GetByRole(AriaRole.Heading, new() { Name = "Available Examples" }).ClickAsync();
            await Page.GetByRole(AriaRole.Link, new() { Name = "A/B Testing" }).ClickAsync();
            await Page.GetByRole(AriaRole.Heading, new() { Name = "A/B Test Variation" }).ClickAsync(new LocatorClickOptions
            {
                Button = MouseButton.Right,
            });
        }


    }
}