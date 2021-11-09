using dotnet_core_api.Dtos.Character;
using dotnet_core_api.Models;
using dotnet_core_api.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            ServiceResponse<List<GetCharacterDto>> response = await _characterService.GetAllCharacters();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
            // return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)

        {
            ServiceResponse<GetCharacterDto> response = await _characterService.GetCharacterById(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
            // return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
        {
            ServiceResponse<List<GetCharacterDto>> response = await _characterService.AddCharacter(newCharacter);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
            // return Ok(_characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto newCharacter)
        {
            ServiceResponse<GetCharacterDto> response = await _characterService.UpdateCharacter(newCharacter);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCharacter(int Id)
        {
            ServiceResponse<List<GetCharacterDto>> response = await _characterService.DeleteCharacter(Id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }


}