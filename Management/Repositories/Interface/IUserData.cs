using Management.Models;

namespace Management.Repositories.Interface
{
    public interface IUserData
    {
        List<UserData> UserDatas(int? id);
    }
}
