using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class RoomService
    {
        public int Id { get; set; }
        public int ?RoomId { get; set; }
        public int ?CustomerId { get; set; }
        public string ?SDesc { get; set; }
        public DateTime ?ServiceDate { get; set; }
        public DateTime? CheckIn { get; set; }
        public int? TotalPersons { get; set; }
        public int? BookingDays { get; set; }
        public decimal? Advance { get; set; }
        public decimal? Amount { get; set; }


        public Room Room { get; set; }
    }
}
