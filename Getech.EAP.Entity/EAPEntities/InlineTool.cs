namespace Getech.EAP.Entity
{
    public class InlineTool
    {
        public InlineTool()
        { }
        public string LineID { get; set; }
        public ControlState ControlState { get; set; }
        public ControlState NextControlState { get; set; }
        public bool IsConnected { get; set; }
        public bool IsOffLine()
        {
            if (ControlState != ControlState.OffLine)
                return false;
            else
                return true;
        }

    }
}
