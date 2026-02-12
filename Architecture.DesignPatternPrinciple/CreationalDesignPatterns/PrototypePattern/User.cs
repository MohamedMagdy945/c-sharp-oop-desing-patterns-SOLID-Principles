namespace Architecture.DesignPatternPrinciple.Creational_Design_Patterns.PrototypePattern
{
    public class User : IPrototype<User>
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public User(string name , string role , string department)
        {
            Name = name;
            Role = role;
            Department = department;
        }
        public User Clone ()
        {
            return new User(Name, Role, Department);
        }
    }
}
