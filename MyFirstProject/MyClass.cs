using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class MyClass : IComparable<MyClass>
    {
        int[] numbers = {1,2,3,4,5,6};
        
        private int rank;
        private string name;
        public MyClass(int prank, string name)
        {
            
            this.rank = prank;
            this.name = name;
        }
        public int CompareTo(MyClass other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return $"{this.rank}-{this.name}";
        }
    }
    internal class MyComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x[x.Length-1].CompareTo(y[y.Length-1]);
        }
    }
}
