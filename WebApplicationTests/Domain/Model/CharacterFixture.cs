using System.Collections.Generic;
using WebApplication.Domain.Model;

namespace WebApplicationTests.Domain.Model
{
    public static class CharacterFixture
    {
        public static IEnumerable<Character> BuildListOfSingleHumanCharacters()
        {
            return new []
            {
                BuildHumanCharacter(),
                BuildNotHumanCharacter()
            };
        }

        public static Character BuildHumanCharacter()
        {
            return new Character(1, "Rick", "human", LocationFixture.BuildOk());
        }
        
        public static Character BuildNotHumanCharacter()
        {
            return new Character(1, "Birdman", "birdman", LocationFixture.BuildOk());
        }
    }
}