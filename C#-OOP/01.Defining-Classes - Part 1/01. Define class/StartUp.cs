//Problem 1. Define class

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics(model, hours idle and hours talk) and display characteristics(size and number of colors).
//Define 3 separate classes(class GSM holding instances of the classes Battery and Display).
namespace DefineClasses
{
    using System;
    using MobilePhone;

    class StartUp
    {
        //test the call history functionality
        static void Main()
        {
            //Create a new mobile phone
            GSM mobile = new GSM("Xperia", "Sony", 670.99, "Kitty");

            //Get information about created mobile phone
            mobile.ToString();

            //Get information about static field iPhone
            GSM.IPhone4S.ToString();

            //Add calls and print
            mobile.AddCalls(DateTime.Now, "+359 885 440 340", 1);
            mobile.AddCalls(DateTime.Now, "+359 886 789 451", 94);
            mobile.PrintCalls();

            //Delete call and print
            mobile.DeleteCalls(2);
            mobile.PrintCalls();

            //Calculate total price
            mobile.CalculateFinalPrice(0.35);

            //Clear calls and print
            mobile.ClearCalls();
        }
    }
}
