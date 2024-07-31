using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Operations
{
    public interface IHerokuAppOperations
    {
        Task CloseBrowser();
        Task TakeScreenShot();
        Task<string> GetHeading();
        Task<string> GetSubHeading();

    }
}
