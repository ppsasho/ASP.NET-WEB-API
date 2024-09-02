using Data_Access.Interfaces;
using DTOs.User;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using Services.Mappers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository repo)
        {
            _userRepository = repo;
        }

        public string LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) 
                throw new ArgumentNullException("Username and password are required");

            // Hash password
            MD5 md5CryptographyService = MD5.Create();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

            byte[] hashBytes = md5CryptographyService.ComputeHash(passwordBytes);
            
            string hashedPassword = Encoding.ASCII.GetString(hashBytes);

            var user = _userRepository.Login(username, hashedPassword);
            if (user == null)
                throw new Exception("User wasn't found!");

            //  Configure Token

            JwtSecurityTokenHandler tokenHandler = new();

            byte[] secretKeyBytes = Encoding.ASCII.GetBytes("Our very custom and very secure secret key that is used for authentication");

            SecurityTokenDescriptor tokenDescriptor = new()
            {
                //  Configure Signature
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                                                            SecurityAlgorithms.HmacSha256Signature),
                //  Payload
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new(ClaimTypes.Name, user.Username),
                        new("userFullName", user.FullName)
                    })
            };

            //  Generate Token
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            //  Return Token

            return tokenHandler.WriteToken(token);
        }

        public bool Register(RegisterUserDto user)
        {
            if (user == null) throw new ArgumentNullException("user is invalid!");

            MD5 md5CryptographyService = MD5.Create();

            byte[] passwordBytes = Encoding.ASCII.GetBytes(user.Password);

            byte[] hashBytes = md5CryptographyService.ComputeHash(passwordBytes);

            user.Password = Encoding.ASCII.GetString(hashBytes);


            return _userRepository.Add(user.ToModel());
        }
    }
}
