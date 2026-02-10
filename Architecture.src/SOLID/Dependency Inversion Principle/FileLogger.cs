namespace Architecture.src.SOLID.Dependency_Inversion_Principle
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
