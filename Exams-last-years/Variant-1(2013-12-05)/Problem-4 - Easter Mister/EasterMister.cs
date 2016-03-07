/*Problem 4 - Easter Mister
 */
using System;
class EasterMister
	{
		public static void Main()
		{
			//working for n = 4;
			int n = 4; //int.Parse(Console.ReadLine());
			int width = n * 3 + 1;
			int height = n * 2;
			
			for (int i = 1; i <= height; i++)
			{
				if (i == 1 || i == height)
				{
					Console.Write(new string('.', n + 1));
				    Console.Write(new string('*', n - 1));
					Console.Write(new string('.', n + 1));
				}
				if (i == height - 1 || (i > 1 && i < 3))
				{
				    Console.Write(new string('.', n - 1));
				    Console.Write("*");
					Console.Write(new string('.', n + 1));
					Console.Write("*");
					Console.Write(new string('.', n - 1));
				}
				if (i == n / 2 + 1 || i == height / 2 + 2)
				{
					Console.Write(".");
					Console.Write("*");
					Console.Write(new string('.', n * 2 + 1));
					Console.Write("*");
				    Console.Write(".");
				}
				if (i == n || i == n + 1)
				{
					Console.Write(".");
					Console.Write("*");
					if (i % 2 == 0)
					{
						for (int j = 0; j < i; j++)
						{
							Console.Write("@");
						    Console.Write(".");
						}
						Console.Write("@");
					}
					else if (i % 2 != 0)
					{
						for (int l = 1; l < i; l++)
						{
							Console.Write(".");
						    Console.Write("@");
						}
						Console.Write(".");
					}
				    Console.Write("*");
				    Console.Write(".");
				}
				Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
}
