using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Operations;
namespace HerokuAppWebdriverAdapter
{
    public class HomePage : IHomePageOperations
    {
        public Task<int> getExampleCount()
        {
            throw new NotImplementedException();
        }

        public IHerokuAppOperations goToExample(string exampleName)
        {
            throw new NotImplementedException();
        }
    }
}
