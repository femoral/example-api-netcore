namespace WebApplication.Domain.Model
{
    public class Character
    {
        private readonly int _id;
        private readonly string _name;
        private readonly string _species;
        private readonly Location _location;

        public int Id => _id;
        public string Name => _name;
        public string Species => _species;
        public string OriginalLocation => _location.Original;
        public string CurrentLocation => _location.Current;

        public Character(int id, string name, string species, Location location)
        {
            _id = id;
            _name = name;
            _species = species;
            _location = location;
        }
    }
}