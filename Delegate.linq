<Query Kind="Program" />

delegate int Test(int x);
void Main()
{
	
	int[] arr = new int[3]{3,5,7};
	
	Transform(arr, One);
	foreach(int i in arr)
	{
	 Console.WriteLine(i);
	}
}

static int One (int x) =>  x * x;

static void Transform (int[] values, Test test)
{
 for(int i = 0; i < values.Length; i++)
 {
   values[i] =  test(values[i]);
 }
}
// Define other methods and classes here