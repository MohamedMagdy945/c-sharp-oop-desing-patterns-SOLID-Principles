namespace Architecture.src.SOLID.Dependency_Inversion_Principle
{
    public class UserService
    {
        private ILogger logger;
        public UserService(ILogger logger) 
        {
            this.logger = logger;
        }
        public void CreateUser()
        {
            logger.Log("User craeted");
        }
    }
}
