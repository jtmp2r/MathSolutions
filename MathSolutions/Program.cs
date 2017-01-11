using System;
using System.Collections.Generic;
using System.Text;

namespace MathClass
{
	class Addition
	{
		public static void Main(string[] args)
		{
			int num1, num2, answer;

			char option;

			Console.Write("Enter first integer: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second integer: ");
			num2 = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Main Menu");
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Multiplication");
			Console.WriteLine("4. Division");
			Console.Write("Enter the Operation you want to perform : ");

			option = Convert.ToChar(Console.ReadLine());

			switch (option)
			{
				case '1':
					answer = num1 + num2;
					Console.WriteLine("The answer of Addition is : {0}", answer);
					break;
				case '2':
					answer = num1 - num2;
					Console.WriteLine("The result of Subtraction is : {0}", answer);
					break;
				case '3':
					answer = num1 * num2;
					Console.WriteLine("The answer of Multiplication is : {0}", answer);
					break;
				case '4':
					answer = num1 / num2;
					Console.WriteLine("The answer of Division is : {0}", answer);
					break;
				default:
					Console.WriteLine("Invalid Option");
					break;
			}
			Console.ReadLine();
		}
	}
}
