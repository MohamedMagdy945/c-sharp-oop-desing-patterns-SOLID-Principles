namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FacadePattern
{
    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player on");
        public void Off() => Console.WriteLine("DVD Player off");
        public void Play(string movie) => Console.WriteLine($"Playing {movie}");
    }
}
