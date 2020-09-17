namespace WebApplication.Domain.Model
{
    public class Location
    {
        private readonly string _original;
        private readonly string _current;

        public string Original => _original;
        public string Current => _current;

        public Location(string original, string current)
        {
            _original = original;
            _current = current;
        }
    }
}