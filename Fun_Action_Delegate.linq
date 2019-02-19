<Query Kind="Program" />

delegate string  NormalDelagte(string s);
public class Program
{
	static void Main(string[] args)
	{
	  Action<int> print = new Action<int>(printValue); //delegate action >> return nothing
	  print(3);
	  
	  //delegate function >> it return value
	  Func<int,int, double> calculate = new Func<int, int, double>(ReturnValue);
	  Console.WriteLine(calculate(7,3));
	  
	  NormalDelagte normal = new NormalDelagte(PrintString);
	  Console.WriteLine(normal("Saif"));
	}
	
	// Define other methods and classes here
	
	public static void printValue(int x)
	{
	  Console.WriteLine(x*2);
	}
	
	public static double ReturnValue(int x, int y)
	{
	  return (double)x*y/2;
	}
	
	public static string PrintString(string s)
	{
	  return  "how are your Mr "+s+ " ?";
	}
	
}