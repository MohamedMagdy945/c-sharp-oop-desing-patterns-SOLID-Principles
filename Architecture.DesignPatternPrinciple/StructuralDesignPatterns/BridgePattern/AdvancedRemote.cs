namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.BridgePattern
{
    internal class AdvancedRemote : RemoteAccess
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }
        public void Mute()
        {
            device.SetVolume(0);
        }
    }
}
