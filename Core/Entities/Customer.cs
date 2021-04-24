using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public ICollection<RoomService> Services { get; set; }
    }
}
