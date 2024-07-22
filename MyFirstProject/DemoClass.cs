using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class DemoClass
    {
        internal const int MAX_VALUE = 100;
        public DemoClass()
        {
            
        }

        public DemoClass(string name, int value)
        {
            MyProperty = value;
            Name = name;
            Console.WriteLine(MAX_VALUE);
        }
        // Field
        private int ctr;
        public string Name { get; }
        private int myVar;

        // Property
        public int MyProperty
        {
            get { return myVar; }
            set { if (value < 0) {
                    Console.WriteLine("Invalid Data cannot be negative");
                } else 
                { myVar = value; 
                } 
            }  
        }

         ~DemoClass() { }


    }
}
