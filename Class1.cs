﻿using System;

static class Class1
{
	static public void method()
	{
        
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        
        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is Even.");
        }
        else
        {
            Console.WriteLine(num + " is Odd.");
        }
    }
}


