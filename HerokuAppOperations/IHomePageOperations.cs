using HerokuApp.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Implementation.Operations
{
    public interface IHomePageOperations
    {
        //Task<string> getTitle();
        //Task<string> getSubHeading();
        // int getExampleCount();
        Task<int> getExampleCount();
        IHerokuAppOperations goToExample(string exampleName);
    }
}
