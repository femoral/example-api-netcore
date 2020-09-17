using WebApplication.Domain.Model;

namespace WebApplication.Domain
{
    public class GetCharacterByIdUseCaseMock : IGetCharacterByIdUseCase
    {
        public Character ExecuteWith(int characterId)
        {
            return new Character(1, "Rick", "human", new Location("Earth", "Alternate Earth"));
        }
    }
}