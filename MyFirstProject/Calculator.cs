using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Calculator
    {
        int arg1;
        int arg2;
        
        public int add() {
            return arg1 + arg2;
        }

        public T1 genericAdd<T1>(T1 param1, T1 Param2) {
            return param1;
        }
    }

    internal class GenericCalculator<T1> {
        T1 arg1;
        T1 arg2;

        public void add()
        {
            Console.WriteLine(arg1.GetType());
            Console.WriteLine(arg2.GetType());
            //return arg1 + arg2;
            //return param1;
        }
    }


}
