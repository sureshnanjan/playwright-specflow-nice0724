using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Operations
{
    public interface IAddRemoveOperations
    {
        Task<string> GetHeading();
        Task AddElement();
        Task RemoveElement();
        Task<int> GetElementCount();
    }
}
