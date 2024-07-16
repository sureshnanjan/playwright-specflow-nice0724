using utilities.math;
namespace training{
public class HelloCSharp{
public static void Main(){
	System.Console.WriteLine("Hello Shrikant Welcome to CSharp, this is your first sample script");
	Calculator mycal = new Calculator();
	mycal.add();
	mycal.subtract();
	mycal.division();
	mycal.multiplication();
}
}
}