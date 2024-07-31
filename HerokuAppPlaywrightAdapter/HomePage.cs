using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Operations;
using Microsoft.Playwright;

namespace HerokuApp.Implementation
{
    public class HomePage : HerokuApp,  IHomePageOperations
    {
       /* private IPlaywright? _tool = null;
        private IBrowser? _browser = null;
        private IPage? _page = null;*/
        //ILocator headingLocator;
        //ILocator subheadingLocator;
        ILocator exampleLocator;
        public HomePage(IPage availablePage) : base(availablePage) {

            //initializeTool().Wait();
            //this.headingLocator = Page.GetByRole(AriaRole.Heading).First;
            //this.subheadingLocator = Page.GetByRole(AriaRole.Heading).Last;
            this.exampleLocator = Page.GetByRole(AriaRole.Listitem);

        }

        public Task<int> getExampleCount()
        {
            return this.exampleLocator.CountAsync();
        }

        
        /*public Task<string> getSubHeading()
        {
            return this.subheadingLocator.InnerTextAsync();
        }

        public Task<string> getTitle()
        {
            return this.headingLocator.InnerTextAsync();
        }*/

        public IHerokuAppOperations goToExample(string exampleName)
        {
            
            switch (exampleName.ToLower())
            {
                case "addremove":
                    Page.GetByRole(AriaRole.Link, new() { Name = "Add/Remove Elements" }).ClickAsync().Wait();
                    return new AddRemovePage(Page);
                case "abtest":
                    Page.GetByRole(AriaRole.Link, new() { Name = "A/B Testing" }).ClickAsync().Wait();
                    return new ABTestPage(Page);
                default:
                    return this;
                    
            }
        }


       /* private async Task initializeTool() {
            _tool = await Playwright.CreateAsync();
            _browser = await _tool.Chromium.LaunchAsync();
            _page = await _browser.NewPageAsync();
            await _page.GotoAsync("https://the-internet.herokuapp.com/");
        }*/

       
    }
}
