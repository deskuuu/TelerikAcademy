namespace EventsCode
{
    using System;

    public static class Messages
    {
        public static void EventAdded()
        {
            Program.Output.Append("Event added" + Environment.NewLine);
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Program.Output.Append($"{x} events deleted" + Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            Program.Output.Append("No events found" + Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Program.Output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}
