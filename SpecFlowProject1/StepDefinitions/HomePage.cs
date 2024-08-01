using HerokuApp.Operations;

namespace HerokuApp.Implementation.Features.StepDefinitions
{
    internal class HomePage : IHerokuAppOperations
    {
        private object value;

        public HomePage(object value)
        {
            this.value = value;
        }
    }
}