namespace VirtualEvent_WEB.Model
{
    public class Event
    {
        public int Id { get; set; }  // Unique identifier for the event
        public string Title { get; set; }  // Event title
        public string Description { get; set; }  // Event description
        public string ImageUrl { get; set; }  // Image URL for the event (if applicable)
        public DateTime Date { get; set; }  // Date of the event
    }
}
