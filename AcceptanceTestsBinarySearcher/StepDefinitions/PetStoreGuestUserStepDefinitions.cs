using System;
using TechTalk.SpecFlow;

namespace AcceptanceTestsBinarySearcher.StepDefinitions
{
    [Binding]
    public class PetStoreGuestUserStepDefinitions
    {
        private string name;
        private string userid;
        private string[]? itemsincart;
        private int totalbalance;
        [Given(@"PetStore is opened")]
        public void GivenPetStoreIsOpened()
        {
            throw new PendingStepException();
        }

        [When(@"a guest user visits")]
        public void WhenAGuestUserVisits()
        {
            name = string.Empty;
            userid = string.Empty;
            totalbalance = 0;
            itemsincart = null;
            // navigate to https://petstore.octoperf.com/actions/Catalog.action
        }

        [Then(@"shopping cart is empty")]
        public void ThenShoppingCartIsEmpty()
        {
            itemsincart.Should().BeEmpty();
        }

        [When(@"a guest user adds|buys (.*)")]
        public void WhenAGuestUserAddsFish(string p0)
        {
            itemsincart.SetValue(p0, 0); 
        }

        [Then(@"shopping cart should have (.*)")]
        public void ThenShoppingCartShouldHaveFish(string p0)
        {
            // click on the fish link
            // click on angel fish
            // add to cart
            itemsincart.GetValue(0).Should().Be(p0);
        }

        [Given(@"the following users exist:")]
        public void GivenTheFollowingUsersExist(Table table)
        {
            //table.
            throw new PendingStepException();
        }


    }
}
