using Calculator;
namespace training
{
    public class HelloCSharp
    {
        public static void Main()
        {
            System.Console.WriteLine("=============Hello Kiran Welcome to CSharp=================\n");

            Calculate mycal = new Calculate();
            System.Console.WriteLine("Addition is "+mycal.add(1,2));
            System.Console.WriteLine("Subtraction is "+mycal.subtract(5,4));
            System.Console.WriteLine("Multiplication is "+mycal.multiply(5,4));
            System.Console.WriteLine("Division is "+mycal.divide(10,2));


            System.Console.WriteLine("=============Assignment_1=================\n");

            Assignment_1 assignment_1 = new Assignment_1();
            assignment_1.Background();
            assignment_1.Foreground();
            assignment_1.ConsoleBeepThreeTimes();
            assignment_1.MachineName();
            assignment_1.UserName();
            assignment_1.Is64BitOS();

            System.Console.WriteLine("=============Assignment_2=================\n");

            string directoryPath = "C:\\Users\\Khirulkar\\OneDrive - Nice Systems Ltd\\Documents\\Training_Playwrite_C#\\Files";
            Assignment_2 assignment_2 = new Assignment_2();
            assignment_2.EnsureDirectoryExists(directoryPath);
            assignment_2.CreateTextFiles(directoryPath);
            assignment_2.DisplayFileDetails(directoryPath);

        }
    }
}