using WebApplication.Common;
using WebApplication.Domain.Model;
using WebApplication.Presentation.Model;

namespace WebApplication.Presentation.Mapper
{
    public class CharacterToCharacterDtoMapper : AbstractMapper<Character, CharacterDto>
    {
        public override CharacterDto Map(Character character)
        {
            return new CharacterDto()
            {
                Name = character.Name,
                IsHuman = "human".Equals(character.Species),
                Location = new LocationDto()
                {
                    Current = character.CurrentLocation,
                    Original = character.OriginalLocation
                }
            };
        }
    }
}