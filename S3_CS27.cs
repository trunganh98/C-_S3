﻿using System;

public class Class1
{
	public Class1()
	{
		int length = 10;
		int breadth = 20;
		int area;
		area = length * breadth;
		object boxed = area;
		int num = (int)boxed;
		Console.WriteLine("Area of the rectangle = { 0}", num);
	}
}
