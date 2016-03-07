/*Problem-2-Apples or oranges
 */
using System;
class ApplesOrOranges
	{
		public static void Main()
		{
			string n = Console.ReadLine();
			int number = 0;
			int oddSum = 0;
			int evenSum = 0;
			
			for (int i = 0; i < n.Length; i++)
			{
				number = n[i] - '0';
				if (number % 2 == 0)
				{
					evenSum += number;
				}
				else
				{
					oddSum += number;
				}
			}
			
		    if (evenSum > oddSum)
			{
				Console.Write("apples {0}",evenSum);
			}
			else if (oddSum > evenSum)
			{
				Console.Write("oranges{0}",oddSum);
			}
			else if (oddSum == evenSum)
			{
				Console.Write("both {0}",oddSum);
			}
		    Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
