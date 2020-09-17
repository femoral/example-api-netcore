using FluentAssertions;
using Moq;
using WebApplication.Domain;
using WebApplication.Presentation;
using WebApplication.Presentation.Mapper;
using WebApplicationTests.Domain.Model;
using WebApplicationTests.Presentation.Model;
using Xunit;

namespace WebApplicationTests.Presentation
{
    public class CharacterControllerTest
    {
        private const int CharacterId = 1;
        private readonly Mock<IGetCharactersUseCase> _getCharactersUseCaseMock;
        private readonly Mock<IGetCharacterByIdUseCase> _getCharacterByIdUseCaseMock;
        private readonly CharacterController _characterController;

        public CharacterControllerTest()
        {
            _getCharacterByIdUseCaseMock = new Mock<IGetCharacterByIdUseCase>();
            _getCharactersUseCaseMock = new Mock<IGetCharactersUseCase>();
            _characterController = new CharacterController(_getCharactersUseCaseMock.Object, _getCharacterByIdUseCaseMock.Object, new CharacterToCharacterDtoMapper());
        }

        [Fact]
        public void GivenGetCharacterByIdUseCaseReturnedHumanCharacter_ShouldReturnHumanCharacterDto_WhenCalledWithId()
        {
            _getCharacterByIdUseCaseMock.Setup(useCase => useCase.ExecuteWith(It.Is<int>(id => CharacterId == id)))
                .Returns(CharacterFixture.BuildHumanCharacter());

            var characters = _characterController.GetCharacterById(CharacterId);

            characters.Should().BeEquivalentTo(CharacterDtoFixture.BuildHumanCharacterDto());
        }
        
        [Fact]
        public void GivenGetCharacterByIdUseCaseReturnedNotHumanCharacter_ShouldReturnNotHumanCharacterDto_WhenCalledWithId()
        {
            _getCharacterByIdUseCaseMock.Setup(useCase => useCase.ExecuteWith(It.Is<int>(id => CharacterId == id)))
                .Returns(CharacterFixture.BuildNotHumanCharacter());

            var characters = _characterController.GetCharacterById(CharacterId);

            characters.Should().BeEquivalentTo(CharacterDtoFixture.BuildNotHumanCharacterDto());
        }
        
        [Fact]
        public void GivenGetCharactersUseCaseReturnedCharacters_ShouldReturnCharacters_WhenCalled()
        {
            _getCharactersUseCaseMock.Setup(useCase => useCase.Execute())
                .Returns(CharacterFixture.BuildListOfSingleHumanCharacters());

            var characters = _characterController.GetCharacters();

            characters.Should().BeEquivalentTo(CharacterDtoFixture.BuildList());
        }
    }
}