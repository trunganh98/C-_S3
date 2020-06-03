using System;

public class Class1
{
	public Class1()
	{
		int radius = 10;
		double area;
		area = 3.14 * radius * radius;
		object boxed = area;
		Console.WriteLine("Area of the circle = { 0}",boxed);
	}
}
