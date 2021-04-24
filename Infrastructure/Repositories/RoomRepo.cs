using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RoomRepo : EfRepo<Room>, IRoomRepo
    {
        public RoomRepo(HotelDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<Room>> ListAllAsync()
        {
            var rooms = await _dbContext.Rooms
                .ToListAsync();
            return rooms;
        }

       


    }
}
