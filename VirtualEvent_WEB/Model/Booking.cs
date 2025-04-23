using System;
namespace VirtualEvent_WEB.Model
{
    public class Booking
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserEmail { get; set; }
        public DateTime Date { get; set; }
        public bool IsConfirmed { get; set; } = false;
        public bool IsCanceled { get; set; } = false;
    }

}
