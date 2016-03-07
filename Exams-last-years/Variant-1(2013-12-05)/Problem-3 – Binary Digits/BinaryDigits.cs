/*Problem 3 – Binary Digits
 */
using System;
class BinaryDigits
	{
		public static void Main()
		{
			int n = 1;//int.Parse(Console.ReadLine());
			int bits = 0;

            for (int row = 0; row < 4; row++)
            {
            	for (int bit = 16; bit > 0; bit--)
                {
            	    bits = (1 << bit) & n;
            		if (bits == 0)
            		{
            			Console.Write("dm");
            		}
            		else if (bits == 1)
            		{
            			Console.Write("pp");
            		}
            	
            		
//            		
//            		if (bits == 0 || bits == 3)
//            		{
//            			Console.Write("###");
//            		}
//            		else if (bits == 1 || bits == 2)
//            		{
//            			Console.Write("#.#");
//            		}
                }
                if (bits > 0)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
    }
    
}

