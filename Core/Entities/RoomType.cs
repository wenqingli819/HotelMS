using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public enum RTdesc { Standard, Deluxe, Suite }

    public class RoomType
    {
        public int Id { get; set; }
        public string ?RTDesc { get; set; }
        public decimal ?Rent { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }

}
