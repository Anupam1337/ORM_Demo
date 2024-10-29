using Management.Models;
using Management.Repositories.Interface;
using System.Collections.Generic;

namespace Management.Repositories.Services
{
    public class UserDataService : IUserData
    {
        public List<UserData> UserDatas(int? id)
        {
            List<UserData> Res1 = new List<UserData>();
            return Res1.ToList();
        }
    }
}
