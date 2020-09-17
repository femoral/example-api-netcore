using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Common;
using WebApplication.Domain;
using WebApplication.Domain.Model;
using WebApplication.Presentation.Model;

namespace WebApplication.Presentation
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly IGetCharactersUseCase _getCharacterUseCase;
        private readonly IGetCharacterByIdUseCase _getCharacterByIdUseCase;
        private readonly AbstractMapper<Character, CharacterDto> _characterMapper;

        public CharacterController(IGetCharactersUseCase getCharacterUseCase,
            IGetCharacterByIdUseCase getCharacterByIdUseCase, AbstractMapper<Character, CharacterDto> characterMapper)
        {
            _getCharacterUseCase = getCharacterUseCase;
            _getCharacterByIdUseCase = getCharacterByIdUseCase;
            _characterMapper = characterMapper;
        }

        [HttpGet]
        public IEnumerable<CharacterDto> GetCharacters()
        {
            return _characterMapper.MapList(_getCharacterUseCase.Execute());
        }
        
        [HttpGet("{characterId}")]
        public CharacterDto GetCharacterById(int characterId)
        {
            return _characterMapper.Map(_getCharacterByIdUseCase.ExecuteWith(characterId));
        }
    }
}