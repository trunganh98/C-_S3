using System;

public class Class1
{
	public Class1()
	{
		float radius = 4.5F;
		double circumference;
		circumference = 2 * 3.14 * radius;
		object boxed = (object)circumference;
		Console.WriteLine("Circumference of the circle = { 0}", circumference);
	}
}
