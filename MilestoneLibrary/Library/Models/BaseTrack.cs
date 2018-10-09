namespace Library.Models
{
    using System.Collections.Generic;

    using Library.Common.Contracts;

    public abstract class BaseTrack : IPlayable
    {
        private string title;
        private IList<string> singers;
        private int duration;

        protected BaseTrack(string title, IList<string> singers, int duration)
        {
            this.title = title;
            this.singers = singers;
            this.duration = duration;
        }

        protected string Title { get; }

        protected IList<string> Singers { get; }

        protected int Duration { get; }

        public abstract void Play();

        public abstract void Pause();

        public abstract void Stop();
    }
}