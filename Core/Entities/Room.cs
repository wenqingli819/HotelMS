using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public bool Status { get; set; }

        //public RoomType RoomType { get; set; }
    }

}
