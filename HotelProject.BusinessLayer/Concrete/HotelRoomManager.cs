using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class HotelRoomManager:IHotelRoomService
    {
        private readonly IHotelRoomDal _hotelRoomDal;

        public HotelRoomManager(IHotelRoomDal hotelRoomDal)
        {
            _hotelRoomDal = hotelRoomDal;
        }

        public void TAdd(HotelRoom entity)
        {
            _hotelRoomDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _hotelRoomDal.Delete(id);
        }

        public List<HotelRoom> TGetAll()
        {
            return _hotelRoomDal.GetAll();
        }

        public HotelRoom TGetById(int id)
        {
            return _hotelRoomDal.GetById(id);
        }

        public void TUpdate(HotelRoom entity)
        {
            _hotelRoomDal.Update(entity);
        }
    }
}
