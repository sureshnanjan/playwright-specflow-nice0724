using HerokuApp.Operations;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Implementation
{
    public class ABTestPage : HerokuApp, IABTestOperation
    {
        ILocator paragraphLocator;
        public ABTestPage(IPage browser): base(browser) {
            this.paragraphLocator = Page.GetByRole(AriaRole.Paragraph);
        }
        public void DisableABTest()
        {
            var cook = new Cookie();
            cook.Name = "optimizelyOptOut";
            cook.Value = "true";
            Page.Context.AddCookiesAsync(new[] { cook });
            Page.ReloadAsync().Wait();
            var result = Page.Context.CookiesAsync().Result;
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} : {item.Value}");
            }
        }

        public string getDescriptionText()
        {
            return paragraphLocator.InnerTextAsync().Result;
        }
    }
}
