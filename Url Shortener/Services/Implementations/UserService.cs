using AgendaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Url_Shortener.Data;
using Url_Shortener.Entities;
using Url_Shortener.Models;

namespace Url_Shortener.Services.Implementations
{
    public class UserService : IUserService
    {
        private UrlContext _context;
        public UserService(UrlContext context)
        {
            _context = context;
        }

        public User? ValidateUser(AuthenticationRequestDto authRequestBody)
        {
            return _context.Users.FirstOrDefault(p => p.Password == authRequestBody.Password);
        }
        public void Create(UserForCreationDto dto)
        {
            User newUser = new User()
            {
                Password = dto.Password,
                UserName = dto.UserName,


            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
    }
}
