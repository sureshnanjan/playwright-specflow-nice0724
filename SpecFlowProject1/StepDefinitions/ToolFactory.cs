using HerokuApp.Operations;

namespace HerokuApp.Implementation.Features.StepDefinitions
{
    internal class ToolFactory
    {
        internal static IHerokuAppOperations GetHomePage()
        {
            return new HomePage(null);
        }
    }
}