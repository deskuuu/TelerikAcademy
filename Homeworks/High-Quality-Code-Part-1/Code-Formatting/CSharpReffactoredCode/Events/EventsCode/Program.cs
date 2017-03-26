namespace EventsCode
{
    using System;
    using System.Text;

    public class Program
    {
        public Program(StringBuilder output, EventHolder events)
        {
            Output = output;
            Events = events;
        }

        public static StringBuilder Output { get; set; }

        public static EventHolder Events { get; set; }

        public static void Main()
        {
            var output = new StringBuilder();
            var events = new EventHolder();
            var program = new Program(output, events);

            while (ExecuteNextCommand())
            {
                Console.WriteLine(Output);
            }
        }

        private static bool ExecuteNextCommand()
        {
            var command = Console.ReadLine().Trim().ToUpper();
            var actualCommand = command[0];
            var hasNextCommand = false;

            switch (actualCommand)
            {
                case 'A':
                    AddEvent(command);
                    hasNextCommand = true;
                    break;
                case 'D':
                    DeleteEvents(command);
                    hasNextCommand = true;
                    break;
                case 'L':
                    ListEvents(command);
                    hasNextCommand = true;
                    break;
                default:
                    hasNextCommand = false;
                    break;
            }

            return hasNextCommand;
        }

        private static void ListEvents(string command)
        {
            var pipeIndex = command.IndexOf('|');
            var date = GetDate(command, "ListEvents");
            var countString = command.Substring(pipeIndex + 1);

            var count = int.Parse(countString);
            Events.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            var title = command.Substring("DeleteEvents".Length + 1);

            Events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);

            Events.AddEvent(date, title, location);
        }

        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            var firstPipeIndex = commandForExecution.IndexOf('|');
            var lastPipeIndex = commandForExecution.LastIndexOf('|');
            var eventTitleStartSubstrIndex = firstPipeIndex + 1;

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(eventTitleStartSubstrIndex).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(eventTitleStartSubstrIndex, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            var dateToParse = command.Substring(commandType.Length + 1, 20);
            var date = DateTime.Parse(dateToParse);

            return date;
        }
    }
}