using Management.Models;
using Management.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Management.Controllers
{
    public class UserDataController : Controller
    {
        private readonly IUserData _userData;
        public UserDataController(IUserData userData)
        {
            _userData = userData;
        }
        [HttpGet(Name = "UserData")]
        public List<UserData> UserDatas(int? id)
        {
            return _userData.UserDatas(id);
        }
    }
}
