using DTOs.User;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public List<UserDto> GetAll();
        public UserDto GetById(int id);
        public bool Any(int id);
        public bool Any(string email);
        public bool Register(UserCreateDto entity);
        public bool Update(UserCreateDto entity, int id);
        public bool Delete(int id);
        public UserLoginResponseDto Login(UserLoginDto entity);
    }
}
