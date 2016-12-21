namespace Defining_Classes___Part_1
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void Main()
        {
            var gsm = new GSM("iphone", "Apple", "Desi", 1500M);

            var callWithMarto = new Call(DateTime.Now, "15:30", "08812345678", 14);
            var callWithDani = new Call(DateTime.Now.AddMinutes(32.54), "17:26", "0781234567", 1);

            gsm.AddCall(callWithMarto);
            gsm.AddCall(callWithDani);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call.ToString());
                Console.WriteLine(new string('-', 20));
            }

            var totalPrice = gsm.CallPrice();
            Console.WriteLine($"The total price is: {totalPrice}$");

            var longestDuration = 0M;
            var longestCall = new Call(DateTime.Now, "12:13", "+34354", 0);
            foreach (var call in gsm.CallHistory)
            {
                if (longestDuration < call.Duration)
                {
                    longestDuration = call.Duration;
                    longestCall = call;
                }
            }

            gsm.CallHistoryField.Remove(longestCall);

            var totalPriceWithoutLongestCall = gsm.CallPrice();
            Console.WriteLine($"The total price withouth longest call is: {totalPrice}$");

            gsm.ClearCalls();
            var callsCounter = gsm.CallHistory.Count;
            Console.WriteLine($"After clearing calls history the calls are: {callsCounter}");
        }
    }
}
