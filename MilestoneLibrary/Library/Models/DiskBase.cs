namespace Library.Models
{
    using System.Collections.Generic;

    using Library.Common.Contracts;

    public abstract class DiskBase : BaseItem
    {
        private IList<IPlayable> audioTracks;
        private IList<IPlayable> videoTracks;

        protected DiskBase(string title) : base(title)
        {
        }

        protected abstract void AddTrack(IPlayable trackToAdd);

        protected abstract void DeleteTrack(IPlayable trackToDelate);

        protected abstract void SearchTrack(IPlayable trackToSearch);
    }
}
