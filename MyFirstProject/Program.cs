using Calculations;
using System.Linq;
namespace MyFirstProject
{
    delegate void myDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //LambdaDemo();
            GenericCalculator<int> intcalc = new GenericCalculator<int>();
            GenericCalculator<float> flcalc = new GenericCalculator<float>();
            intcalc.add();
            flcalc.add();
            List<int> list = new List<int>();
            Calculator cal = new Calculator();
            Console.WriteLine(cal.genericAdd<int>(1, 2));
            Console.WriteLine(cal.genericAdd<float>(12.0f, 12.1f));
        }

        private static void LambdaDemo()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            double[] numbers2 = { 1.2, 1.3, 1.3 };
            //DelegatsDemo();
            Console.WriteLine(numbers.Aggregate(Multiplier));
            Console.WriteLine(numbers.Aggregate(Adder));
            Console.WriteLine(numbers.Aggregate((a, b) => 2 * a + 2 * b));
            Console.WriteLine(numbers.All(a => a % 2 == 0));
            Console.WriteLine(numbers.All(a => a < 10));
            numbers2.Aggregate((a,b) => a+b);
        }

        private static int Multiplier(int a, int b) {
            return a * b;
        }

        private static int Adder(int a, int b)
        {
            return a + b;
        }

        private static void DelegatsDemo()
        {
            myDelegate myDelegate = someOtherMethod;
            myDelegate(10, 20);
            myMethodInvoker(myDelegate);
            Action<int, int> myaction = someOtherMethod;
            myaction(10, 20);
            Func<string, int, bool, int> myfunc = methodWithParams;
            myfunc("suresh", 10, true);
        }

        private static void myMethodInvoker(myDelegate fn) {
            Console.WriteLine("Doing somethings extra before method call");
            fn(10,20);
            Console.WriteLine("After Invoke I do something extra");
        }

        private static void someMethod() { }

        private static int methodWithParams(string a, int b, bool x) {
            Console.WriteLine($"{a} and {b} and {x}");
            return 0;
        }

        private static void someOtherMethod(int a, int b) {
            Console.WriteLine($"{a} and {b}");
        }

        private static void interfaces_demo()
        {
            //old_code_demo();
            string[] names = { "suresh", "kiran", "vaibav", "saket", "mayuri" };
            //Console.WriteLine(names.Aggregate());
            Console.WriteLine("BEFORE Sorting");
            foreach (var item in names)
            {
                Console.WriteLine(item);

            }
            Array.Sort(names);
            Console.WriteLine("AFTER Sorting");
            foreach (var item in names)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("AFTER CUSTOM SORT");
            Array.Sort(names, new MyComparer());
            foreach (var item in names)
            {
                Console.WriteLine(item);

            }
        }

        private static void NewMethod()
        {
            int[] numbers = { 1, 5, 4, 3, 2, 0, };
            MyClass[] myclasscollection = { new MyClass(1, "one"), new MyClass(0, "zero"), new MyClass(-1, "minus") };
            Console.WriteLine("Before sorting");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
            foreach (var item in myclasscollection)
            {
                Console.WriteLine(item);
            }
            Array.Sort(numbers);
            Array.Sort(myclasscollection);
            Console.WriteLine("After Sorting");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
            foreach (var item in myclasscollection)
            {
                Console.WriteLine(item);
            }
        }

        private static void old_code_demo()
        {
            // Value Type 
            // Reference Types
            CreateObjects();
            Car mycar = new Car();
            mycar.start();
            mycar.open_boot();

            bike mybike = new bike();
            mybike.start();

            MyAbstract[] collection = new MyAbstract[] { new MyConcrete(), new OneMoreConcrete() };
            MyConcrete[] collect1;
            OneMoreConcrete[] collect2;


            foreach (var item in collection)
            {
                MyConcrete? obj = item as MyConcrete;
                if (obj != null) { }
                int? number = null;
            }
            int[] mynumbers = new int[] { 1, 2, 3, 4, 5 };
        }

        private static void CreateObjects() {
            DemoClass demo = new DemoClass();
            string value = demo.Name;
            demo.MyProperty = -1;
            demo.MyProperty = 3;
            Console.WriteLine(demo.MyProperty);
            DemoClass demo2 = new DemoClass("suresh", 10);

        }
    }
}
