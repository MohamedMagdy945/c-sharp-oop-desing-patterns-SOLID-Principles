namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.BridgePattern
{
    public class Radio : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Radio ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio OFF");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Radio volume = {level}");
        }
    }

}
