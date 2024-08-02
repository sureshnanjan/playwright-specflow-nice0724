using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JPetStoreOperations;

namespace HerokuAppSystemTest
{
    [TestClass]
    public class PetstoreHomePageTests
    {
        [TestMethod]
        public void LogoHasCorrectPosition() {
            /// AAA
            IHomePageOperations aut;
            string expected = "TOP-LEFT";
            string actual = aut.getLogoDetails();
        }

        [TestMethod]
        public void LogoHasCorrectFont()
        {
            /// AAA
            IHomePageOperations aut;
            string expected = "TOP-LEFT";
            string actual = aut.getLogoDetails();
        }

        [TestMethod]
        public void LogoHasCorrectLinkonClick()
        {
            /// AAA
            IHomePageOperations aut;
            string expected = "TOP-LEFT";
            LogoDetails actual = new LogoDetails();
            // NO assert for LInk
            actual.
        }
    }
}
