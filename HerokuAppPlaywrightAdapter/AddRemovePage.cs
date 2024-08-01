using HerokuApp.Operations;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HerokuApp.Implementation
{
    public class AddRemovePage : HerokuApp, IAddRemoveOperations
    {
        private readonly ILocator headingLocator;
        private readonly ILocator addElementLocator;
        private readonly ILocator removeElementLocator; 

        public AddRemovePage(IPage availablePage) : base(availablePage)
        {
            this.headingLocator = Page.GetByRole(AriaRole.Heading);
            this.addElementLocator = Page.GetByRole(AriaRole.Button, new() { Name = "Add" });
            this.removeElementLocator = Page.GetByRole(AriaRole.Button, new() { Name = "Delete" });
        }

        public Task AddElement()
        {
            return this.addElementLocator.ClickAsync();
        }

        public Task<int> GetElementCount()
        {
            return this.removeElementLocator.CountAsync();
        }

        public Task<string> GetHeading()
        {
            return this.headingLocator.InnerTextAsync();
        }

        public Task RemoveElement()
        {
            return this.removeElementLocator.ClickAsync();
        }
    }
}
