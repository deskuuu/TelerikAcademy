namespace MilestoneLibrary
{
    using Library;
    using Library.Common.Contracts;

    class Startup
    {
        static void Main()
        {
            IEngine engine = Engine.Instance;
            engine.Start();
        }
    }
}
