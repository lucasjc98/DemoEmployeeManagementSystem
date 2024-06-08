using DEMS.BaseLibrary.DTOs;
using DEMS.BaseLibrary.Responses;

namespace DEMS.AppLibrary.Services.Contracts
{
    public interface IUserAccountService
    {
        Task<GeneralResponse> CreateAsync(RegisterDTO user);
        Task<LoginResponse> SignInAsync(LoginDTO user);
        Task<LoginResponse> RefreshTokenAsync(RefreshTokenDTO token);
        Task<WeatherForecastDTO[]> GetWeatherForecast();
    }
}
