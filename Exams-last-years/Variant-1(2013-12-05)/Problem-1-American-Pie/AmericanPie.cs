/*Problem-1-American-Pie
 */
using System;
class AmericanPie
	{
		public static void Main()
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());
			decimal sum = 0;
			
			if (b == d)
			{
				sum = a + c;
			    Console.WriteLine("{0:0}",sum / (b * d));
				Console.WriteLine("{0}/{1}",sum,b * d);
			}
			else if (b != d)
			{
				a = a * d;
				c = c * b;
				sum = a + c;
				if (sum / (b * d) != 0)
				{
					Console.WriteLine("{0:F20}",sum / (b * d));
				}
				Console.WriteLine("{0}/{1}",sum,b * d);
			}
			Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
