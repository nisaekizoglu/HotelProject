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
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(User entity)
        {
            _userDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _userDal.Delete(id);
        }

        public List<User> TGetAll()
        {
            return _userDal.GetAll();
        }

        public User TGetById(int id)
        {
            return _userDal.GetById(id);
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
