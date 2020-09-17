using WebApplication.Domain.Model;

namespace WebApplicationTests.Domain.Model
{
    internal static class LocationFixture
    {
        public static Location BuildOk()
        {
            return new Location("Earth", "Alternate Earth");
        }
    }
}