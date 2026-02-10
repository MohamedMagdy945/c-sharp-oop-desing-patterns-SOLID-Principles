namespace Architecture.src.SOLID.Dependency_Inversion_Principle
{
    public class BadUserService
    {
        public void CreateUser()
        {
            FileLogger file = new FileLogger();
            file.Log("User Created");
        }
    }
}
