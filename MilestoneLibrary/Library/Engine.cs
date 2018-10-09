namespace Library
{
    using System;
    using System.Collections.Generic;

    using Library.Common.Contracts;
    using Library.Providers;

    public sealed class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private List<IBook> books;
        private IList<IPlayable> cds;
        private IList<IPlayable> dvds;
        private IList<IPlayable> bluRays;

        public static IEngine Instance { get; } = new Engine();

        private Engine()
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Start()
        {
            this.IntroduceMenu();
            this.GetChoice();
            this.IntroduceMenuMoods();

        }

        private void IntroduceMenu()
        {
            this.writer.WriteLine("Welcome to Milestone library!");
            this.writer.WriteLine("What is your choice? Tab '1' to Book sector or tab '2' to Disk sector: ");
        }

        private void GetChoice()
        {
            try
            {
                var choice = int.Parse(this.reader.ReadLine());

                switch (choice)
                {
                    case 1: InBookMode(); break;
                    case 2: InDiskMode(); break;
                    default: writer.WriteLine("Invalid choice"); break;
                }
            }catch(Exception exc)
            {

            }
        }

        private void IntroduceMenuMoods()
        {
            this.writer.WriteLine(@"To add book press 1,
                                    To search book press 2
                                    Go Back 3:");
        }

        private void InBookMode()
        {



        }

        private void InDiskMode()
        {

        }


    }
}
