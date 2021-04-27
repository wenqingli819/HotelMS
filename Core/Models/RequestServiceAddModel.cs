using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RequestServiceAddModel
    {
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public string? SDesc { get; set; }
        public DateTime? ServiceDate { get; set; }
        public DateTime? CheckIn { get; set; }
        public int? TotalPersons { get; set; }
        public int? BookingDays { get; set; }
        public decimal? Advance { get; set; }
        public decimal? Amount { get; set; }
    }
}
