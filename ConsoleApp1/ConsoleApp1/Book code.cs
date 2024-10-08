﻿int choice = 0;

int[] numbers = { 10, 11, 12, 13, 14, 15 };
Console.Write("Please enter the index of the array:");

try
{
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("numbers [{0}]) = {1}", choice, numbers[choice]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Error: Index should be from 0 to 5");
}
catch (FormatException)
{
    Console.WriteLine("Error: You did not write an integer");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}