using Data_Access.Implementations;
using Data_Access.Interfaces;
using Domain_Models;
using DTOs.Beverage;
using DTOs.User;
using Mappers;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;
        public UserService(IUserRepository repo, IConfiguration config)
        {
            _userRepository = repo;
            _config = config;

        }
        public bool Any(int id) => _userRepository.Any(id);
        public bool Any(string email) => _userRepository.Any(email);

        public bool Delete(int id)
        {
            if(Any(id)) 
                return _userRepository.Delete(id);

            return false;
        }

        private string GenerateToken(User user)
        {
            JwtSecurityTokenHandler tokenHandler = new();
            byte[] secretKeyBytes = Encoding.ASCII.GetBytes(_config["SecretKey:Key"]);

            SecurityTokenDescriptor tokenDescriptor = new()
            {
                Expires = DateTime.UtcNow.AddMinutes(5),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                                            SecurityAlgorithms.HmacSha256Signature),
                Subject = new ClaimsIdentity(
                new[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                        new Claim("userFullName", user.FullName)
                    })
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        private string HashPassword(string password)
        {
            MD5 md5CryptoService = MD5.Create();

            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

            byte[] hashBytes = md5CryptoService.ComputeHash(passwordBytes);

            return Encoding.ASCII.GetString(hashBytes);
        }

        public List<UserDto> GetAll() => 
              _userRepository.GetAll().Select(x => x.ToModel()).ToList();
        public UserDto GetById(int id) 
        {
            var found = _userRepository.GetById(id);

            if (found is not null) return found.ToModel();

            return new UserDto();
        }

        public UserLoginResponseDto Login(UserLoginDto entity)
        {
            if (!Any(entity.Email)) return new UserLoginResponseDto();

            var user = _userRepository.Login(entity.Email, HashPassword(entity.Password));

            if (user == null)
                return new UserLoginResponseDto();
            
            var token = GenerateToken(user);

            return user.ToModel(token);
        }

        public bool Register(UserCreateDto entity)
        {
            if (_userRepository.Any(entity.Email))
                return false;

            var hashedPassword = HashPassword(entity.Password);

            return _userRepository.Add(entity.ToModel(hashedPassword));
        }

        public bool Update(UserCreateDto entity, int id)
        {
            var found = GetById(id);

            if (found == null) return false;

            return _userRepository.Update(entity.ToModel());
        }
    }
}
