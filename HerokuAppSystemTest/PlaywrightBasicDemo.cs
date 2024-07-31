using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
namespace HerokuAppSystemTest
{
    internal class PlaywrightBasicDemo
    {
        public PlaywrightBasicDemo()
        {
            Task.Run(Initialize);
        }

        async Task Initialize()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();
            await page.GotoAsync("https://the-internet.herokuapp.com/");
            await page.GetByRole(AriaRole.Heading, new() { Name = "Welcome to the-internet" }).ClickAsync(new LocatorClickOptions
            {
                Button = MouseButton.Right,
            });
            await page.GetByRole(AriaRole.Heading, new() { Name = "Available Examples" }).ClickAsync(new LocatorClickOptions
            {
                Button = MouseButton.Right,
            });
            await page.GetByRole(AriaRole.Heading, new() { Name = "Available Examples" }).ClickAsync();
            await page.GetByRole(AriaRole.Link, new() { Name = "A/B Testing" }).ClickAsync();
            await page.GetByRole(AriaRole.Heading, new() { Name = "A/B Test Variation" }).ClickAsync(new LocatorClickOptions
            {
                Button = MouseButton.Right,
            });
        }
    

    }
}
