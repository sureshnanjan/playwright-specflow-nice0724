using utilities.math;
namespace training{
public class HelloCSharp{
public static void Main(){
	System.Console.WriteLine("Hello Suresh Welcome to CSharp");
	Calculator mycal = new Calculator();
	mycal.add();
	mycal.subtract();
	mycal.Add(1,2);
	mycal.Subtract(3,4);
	mycal.Multiply(3,4);
	mycal.Divide(4,2);
}
}
}