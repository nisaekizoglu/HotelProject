using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Context;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfHotelRoomDal:GenericRepository<HotelRoom>,IHotelRoomDal
    {
        public EfHotelRoomDal(ApiContext context) : base(context)
        {
        }
    }
}
