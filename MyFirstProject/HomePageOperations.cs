using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class HomePageOperations
    {
        // EdgeDriver
        // ChromeDriver
        // FirefoxDriver

        // IWebdriver browser = new ChromeDriver()
        // browser = new FrierfoxDriver()
        public HomePageOperations(string browsername) {
            switch (browsername)
            {
                default:
                    break;
            }
        }
        public string getTitle() { return "Heroku app"; }
    }
}
