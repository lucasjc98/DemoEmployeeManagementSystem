using DEMS.BaseLibrary.DTOs;
using DEMS.BaseLibrary.Responses;

namespace DEMS.ApiLibrary.Repositories.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAsync(RegisterDTO user);
        Task<LoginResponse> SignInAsync(LoginDTO user);
        Task<LoginResponse> RefreshTokenAsync(RefreshTokenDTO token);
    }
}
