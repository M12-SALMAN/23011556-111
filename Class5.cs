﻿using System;

static class Class5
{
	static public void salman()
	{
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table of {num}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
}
}

