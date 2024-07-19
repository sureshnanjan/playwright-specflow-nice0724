namespace MyFirstProject
{
    internal class Vehicle
    {
        int enginecc;
        string model;
        int tyres;

        public void accelerate() { }
        public void start() { }
        public void stop() { }
    }

    internal abstract class MyAbstract {
        public abstract void myMethod();
        public void print() {
            Console.WriteLine("PRINTING THIS");
        }
    }

    internal class MyConcrete : MyAbstract
    {
        public override void myMethod()
        {
            Console.WriteLine("My Method is doing with STRING manipulation");
        }
        public void specialMethod() { }
    }

    internal class OneMoreConcrete : MyAbstract
    {
        public override void myMethod()
        {
            Console.WriteLine("I am doing this Dirrent from the other");
        }

        public void specialMethod() { }
    }

    internal interface IPremiumCalculator { }

    internal class MyCar : Vehicle, IPremiumCalculator
    {
        
    }
}