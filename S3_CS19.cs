﻿using System;

public class Class1
{
	static void Main(string[] args)
	{
		uint num = 100; // 01100100 = 100
		uint result = num << 1; // 11001000 = 200
		Console.WriteLine("Value before left shift: " +num);
		Console.WriteLine("Value after left shift " +result);
		num = 80; // 10100000 =
		result = num >> 1; // 01010000 = 40
		Console.WriteLine("\nValue before right shift: " +num);
		Console.WriteLine("Value after right shift: " +result);
	}
}
