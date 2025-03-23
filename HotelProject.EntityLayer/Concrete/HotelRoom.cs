using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class HotelRoom
    {
        public int HotelRoomId { get; set; }
        public int AdultCount { get; set; }
        public int ChildrenCount { get; set; }
        public int RoomCount { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
