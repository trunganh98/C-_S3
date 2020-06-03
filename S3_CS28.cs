using System;

public class Class1
{
	static void Main(string[] args)
	{
		int num = 8;
		int result;
		result = Square(num);
		Console.WriteLine("Square of { 0} = { 1}", num, result);
	}
	static int Square(object inum)
	{
		return (int)inum * (int)inum;
	}
}
