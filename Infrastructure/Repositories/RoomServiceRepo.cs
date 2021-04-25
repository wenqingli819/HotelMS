using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.RepositoryInterfaces;
using Core.ServiceInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class RoomServiceRepo : EfRepo<RoomService>, IRoomServiceRepo
    {
        public RoomServiceRepo(HotelDbContext dbContext) : base(dbContext)
        {
        }
    }
}
