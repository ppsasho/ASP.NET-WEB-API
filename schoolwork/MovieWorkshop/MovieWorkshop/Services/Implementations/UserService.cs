using DataAccess.Interfaces;
using DomainModels;
using DTOs.User;
using Mappers;
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
        private readonly IUserDbRepository _userRepository;
        public UserService(IUserDbRepository repo)
        {
            _userRepository = repo;
        }
        public bool ValidateCredentials(string username, string password) => _userRepository.Any(username) 
                                                                          && password.Length > 7; 
        public string GenerateToken(User user)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] secretKeyBytes = Encoding.ASCII.GetBytes("this is my custom Secret key for authentication");

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddMinutes(1),
                // Configure signature
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                                            SecurityAlgorithms.HmacSha256Signature),
                // Payload
                Subject = new ClaimsIdentity(
                new[]
                {
                    new Claim(ClaimTypes.Name, user.Username),
                        new Claim("userFullName", $"{user.FirstName}{user.LastName}")
                    })
            };

            // 5. Generate Token
            var token =  tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        public string HashPassword(string password)
        {
            MD5 md5CryptoService = MD5.Create();

            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

            byte[] hashBytes = md5CryptoService.ComputeHash(passwordBytes);

            return Encoding.ASCII.GetString(hashBytes);
        }
        public UserLoginResponseDto LoginUser(string username, string password)
        {
                if (!ValidateCredentials(username, password))
                return new UserLoginResponseDto();

                var hashedPassword = HashPassword(password);

                var user = _userRepository.Login(username, hashedPassword);
                if (user != null)
                {
                    var token = GenerateToken(user);

                    return user.ToModel(token);
                }
                return new UserLoginResponseDto();
        }

        public bool RegisterUser(RegisterUserDto registerUserDto)
        {
            if (_userRepository.Any(registerUserDto.Username))
                return false;
            
            registerUserDto.Password = HashPassword(registerUserDto.Password);

            return _userRepository.Register(registerUserDto.ToModel());
        }
    }
}
