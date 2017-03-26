namespace EventsCode
{
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private MultiDictionary<string, Event> titleDictionary = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> orderedByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            var newEvent = new Event(date, title, location);

            this.titleDictionary.Add(title.ToLower(), newEvent);
            this.orderedByDate.Add(newEvent);

            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            var title = titleToDelete.ToLower();
            var removed = 0;

            foreach (var eventToRemove in this.titleDictionary[title])
            {
                this.orderedByDate.Remove(eventToRemove);
                removed++;
            }

            this.titleDictionary.Remove(title);

            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.orderedByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                showed++;

                Messages.PrintEvent(eventToShow);
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}