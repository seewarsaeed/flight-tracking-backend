using Final_Project.Core.Repository;
using Final_Project.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Core.DTO;
using Final_Project.Core.Models;

namespace Final_Project.Infra.Service
{
    public class JWTService : IJWTService
    {
        private readonly IJWTRepository reposiytory;
        public JWTService(IJWTRepository reposiytory)
        {
            this.reposiytory = reposiytory;
        }
        public string Auth(User login)
        {
            var result = reposiytory.Auth(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                    new Claim("name", result.User_Name),
                    new Claim("role", result.Role_Id.ToString()),
                    new Claim("userId", result.User_Id.ToString())


                };
                var tokeOptions = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddHours(24),
                    signingCredentials: signinCredentials
                    );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return tokenString;
            }
        }

    }
}
