
using Url_Shortener.Entities;
using Url_Shortener.Models;

namespace AgendaApi.Services.Interfaces
{
    public interface IUserService
    {
        public void Create(UserForCreationDto dto);

        public User? ValidateUser(AuthenticationRequestDto authRequest);
    }
}