using dotnet_core_api.Dtos.Character;
using dotnet_core_api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_core_api.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int Id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto character);

        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int Id);
    }
}