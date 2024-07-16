using System;
namespace utilities.math{
public class Calculator{
	public int add(){
	System.Console.WriteLine("Doing addition");
	return 0;
	}
	public int subtract(){
	System.Console.WriteLine("Doing Subtraction");
	return 0;
	}
	public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }    

    public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }    

    public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }    

}
}