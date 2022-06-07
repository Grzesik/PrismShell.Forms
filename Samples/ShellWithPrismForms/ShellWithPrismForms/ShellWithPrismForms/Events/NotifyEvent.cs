using Prism.SystemEvents;

namespace ShellWithPrismForms.Events
{
    public class NotifyEvent : PubSubEvent<NotifyEventData>
    {
    }

    public class NotifyEventData
    {
        public int SelectedId { get; set; }

        public string Title { get; set; }
    }
}
