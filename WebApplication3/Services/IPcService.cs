using WebApplication3.DTOs;

namespace WebApplication3.Services;

public interface IPcService
{
    Task<IEnumerable<PCListDto>> GetAllAsync();
    Task<PCDetailDto?> GetByIdWithComponentsAsync(int id);
    Task<PCListDto> AddAsync(PCCreateUpdateDto dto);
    Task<bool> UpdateAsync(int id, PCCreateUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}