using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Assignment_1
    {
        // Print the Background Color
        public void Background()
        {
            Console.WriteLine("Background Color: " + Console.BackgroundColor);
        }

        // Print the Foreground Color
        public void Foreground()
        {
            Console.WriteLine("Foreground Color: " + Console.ForegroundColor);
        }

        // Make the console beep 3 times
        public void ConsoleBeepThreeTimes()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Beep();
                System.Threading.Thread.Sleep(500); // Adding a small delay between beeps
            }
        }

        // Print the machine name
        public void MachineName()
        {
            Console.WriteLine("Machine Name: " + Environment.MachineName);
        }

        // Print the logged in user name
        public void UserName()
        {
            Console.WriteLine("Logged in User Name: " + Environment.UserName);
        }

        // Print whether the machine is 64-bit or not
        public void Is64BitOS()
        {
            Console.WriteLine("Is 64-bit OS: " + Environment.Is64BitOperatingSystem);
        }
    }
}
