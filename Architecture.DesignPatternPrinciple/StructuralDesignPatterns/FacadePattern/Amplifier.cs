namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FacadePattern
{
    public class Amplifier
    {
        public void On() => Console.WriteLine("Amplifier on");
        public void Off() => Console.WriteLine("Amplifier off");
        public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
    }
}
