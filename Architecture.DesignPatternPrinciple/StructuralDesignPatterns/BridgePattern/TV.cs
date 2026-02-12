namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.BridgePattern
{
    public class TV : IDevice
    {
        public void SetVolume(int level)
        {
            Console.WriteLine($"TV volume = {level}");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV ON");
        }
    }
}
