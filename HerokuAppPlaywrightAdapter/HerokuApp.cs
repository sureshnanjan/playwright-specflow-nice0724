using HerokuApp.Operations;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

=======
using Utilities;
using Microsoft.Playwright;
>>>>>>> origin/suresh-trainer

namespace HerokuApp.Implementation
{
    public class HerokuApp : IHerokuAppOperations
    {
        private IPlaywright? _tool = null;
        private IBrowser? _browser = null;
        private IPage? _page = null;
        ILocator headingLocator;
        ILocator subheadingLocator;
        private IPage browser;

        public HerokuApp(IPage availablePage)
        {
            if (availablePage is null)
            {
                initializeTool().Wait();
            }
            else 
            {
                _page = availablePage;
            }
            this.headingLocator = Page.GetByRole(AriaRole.Heading).First;
            this.subheadingLocator = Page.GetByRole(AriaRole.Heading).Last;

        }

        public HerokuApp(IPage browser) => this.browser = browser;

        private async Task initializeTool()
        {
            _tool = await Playwright.CreateAsync();
            switch (Utilities.BrowserSettings.getBrowserName().ToLower())
            {
                case "chrome":
                    // Google Chrome, Microsoft Edge and other Chromium-based browsers
                    // available channels are chrome, msedge, chrome-beta, msedge-beta or msedge-dev
                    _browser = await _tool.Chromium.LaunchAsync( new() {Headless = false});
                    break;
                case "webkit":
                    _browser = await _tool.Webkit.LaunchAsync();
                    break;
                case "firefox":
                    _browser = await _tool.Firefox.LaunchAsync();
                    break;
                default:
                    _browser = await _tool.Chromium.LaunchAsync();
                    break;
            }
            
            _page = await _browser.NewPageAsync();
            object ap1 = await _page.GotoAsync(Utilities.ApplicationSettings.getAppUrl());
        }

        public Task CloseBrowser()
        {
            throw new NotImplementedException();
        }

        public Task TakeScreenShot()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetHeading()
        {
            return this.headingLocator.InnerTextAsync();
        }

        public Task<string> GetSubHeading()
        {
            return this.subheadingLocator.InnerTextAsync();
        }

        protected IPlaywright? PlaywrightInstance { get { return this._tool;}}

        protected IBrowser? Browser { get { return this._browser;}}

        protected IPage? Page { get { return this._page; } }

        public object Utilities { get; private set; }
    }
}
