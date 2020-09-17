using System.Collections.Generic;
using WebApplication.Domain.Model;

namespace WebApplication.Domain
{
    public class GetCharactersUseCaseMock : IGetCharactersUseCase
    {
        public IEnumerable<Character> Execute()
        {
            return new []
            {
                BuildHumanCharacter(),
                BuildNotHumanCharacter()
            };
        }
        
        private static Character BuildHumanCharacter()
        {
            return new Character(1, "Rick", "human", BuildOk());
        }
        
        private static Character BuildNotHumanCharacter()
        {
            return new Character(1, "Birdman", "birdman", BuildOk());
        }
        
        private static Location BuildOk()
        {
            return new Location("Earth", "Alternate Earth");
        }
    }
}