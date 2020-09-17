using WebApplication.Presentation.Model;

namespace WebApplicationTests.Presentation.Model
{
    internal static class LocationDtoFixture
    {
        public static LocationDto BuildOk()
        {
            return new LocationDto {Current = "Alternate Earth", Original = "Earth"};
        }
    }
}