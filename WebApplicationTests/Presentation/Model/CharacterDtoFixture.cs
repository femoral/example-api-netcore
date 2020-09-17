using System.Collections.Generic;
using WebApplication.Presentation.Model;

namespace WebApplicationTests.Presentation.Model
{
    internal static class CharacterDtoFixture
    {
        public static IEnumerable<CharacterDto> BuildList()
        {
            return new[]
            {
                BuildHumanCharacterDto(),
                BuildNotHumanCharacterDto()
            };
        }

        public static CharacterDto BuildHumanCharacterDto()
        {
            return new CharacterDto
            {
                Name = "Rick",
                IsHuman = true,
                Location = LocationDtoFixture.BuildOk()
            };
        }

        public static CharacterDto BuildNotHumanCharacterDto()
        {
            return new CharacterDto
            {
                Name = "Birdman",
                IsHuman = false,
                Location = LocationDtoFixture.BuildOk()
            };
        }
    }
}