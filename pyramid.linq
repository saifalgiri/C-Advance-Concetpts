<Query Kind="Program" />

public class Program {

  static void Main(string[] args)
  {
    for(int i =0; i <= 10; i++)
	{
	 for(int x = 0; x <= 10-i; x++)
	 {
	   Console.Write(" ");
	 }
	 for(int j = 0; j <= i; j++)
	 {
	  Console.Write("*");
	 }
	 Console.WriteLine();
	}
  }

}