﻿using System;

public class Class1
{
	public Class1()
	{
		int valueOne = 10;
		Console.WriteLine((4 * 5 - 3) / 6 + 7 - 8 % 5);
		Console.WriteLine((32 < 4) || (8 == 8));
		Console.WriteLine(((valueOne *= 6) > (valueOne += 5)) &&
		((valueOne /= 2) != (valueOne -= 5)));
	}
}
