﻿namespace Library.Models
{
    using System;

    using Library.Common.Contracts;

    public class DVD : DiskBase
    {
        public DVD(string title) : base(title)
        {
        }

        public override void DownloadItem()
        {
            throw new NotImplementedException();
        }

        protected override void AddTrack(IPlayable trackToAdd)
        {
            throw new NotImplementedException();
        }

        protected override void DeleteTrack(IPlayable trackToDelate)
        {
            throw new NotImplementedException();
        }

        protected override void SearchTrack(IPlayable trackToSearch)
        {
            throw new NotImplementedException();
        }
    }
}
