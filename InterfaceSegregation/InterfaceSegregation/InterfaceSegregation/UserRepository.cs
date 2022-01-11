namespace InterfaceSegregation
{
    public class UserRepository : IReadable, IWriteable, IRemovable
    {
        public void Create() { }
        public void Update() { }
        public void Remove(int id) { }
        public void Get(int id) { }
        public void GetAll() { }
    }
}
