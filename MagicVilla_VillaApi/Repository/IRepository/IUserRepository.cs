using System;
using MagicVilla_VillaApi.Models.Dto;
using System.Threading.Tasks;
using MagicVilla_VillaApi.Models;

namespace MagicVilla_VillaApi.Repository.IRepository
{
	public interface IUserRepository
	{
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}

