using WorkingBees.Core.Interfaces;
using WorkingBees.Core.Models;

namespace WorkingBees.Core.Services
{
    public class UserInfoService : IService<UserInfo>
    {
        public readonly IRepository<UserInfo> _userRepository;
        public UserInfoService(IRepository<UserInfo> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserInfo> ListAll()
        {
            return _userRepository.ListAll();
        }
        public List<UserInfo> Listallbyuserid(long userId)
        {
            return _userRepository.ListAllByUserId(userId);
        }
        public bool Insert(UserInfo user)
        {
            return _userRepository.Insert(user);
        }
        public bool Update(long id, UserInfo user)
        {
            return _userRepository.Update(id, user);
        }

        public bool Delete(long id)
        {
            return _userRepository.Delete(id);
        }
    }
}
