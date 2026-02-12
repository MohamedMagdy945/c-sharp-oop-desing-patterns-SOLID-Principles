namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.BridgePattern
{
    public class RemoteAccess
    {
        protected IDevice device;
        public RemoteAccess(IDevice device)
        {
            this.device = device;
        }
        public void PowerOn()
        {
            device.TurnOn();
        }
        public void PowerOff()
        {
            device.TurnOff();
        }
    }
}
