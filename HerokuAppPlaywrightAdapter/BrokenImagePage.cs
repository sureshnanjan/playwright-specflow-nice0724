using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Implementation;
using HerokuApp.Operations;
using HerokuApp.Operations;
using Microsoft.Playwright;

namespace HerokuApp.Implementation
{
    public class BrokenImagePage : HerokuApp, IBrokenImageOperations
    {
        
        ILocator locatorImage1;
        ILocator locatorImage2;
        ILocator locatorImage3;
        public BrokenImagePage(IPage browser): base(browser) { }
        {
            
        }
        public string getImage1Details()
        {
            this.Page
        }

        public string getImage2Details()
        {
          
        }

        public string getImage3Details()
        {
            throw new NotImplementedException();
        }
    }
}
