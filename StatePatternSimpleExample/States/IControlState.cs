namespace StatePatternSimpleExample.States
{
    public interface IControlState
    {
        IControlState Start();
        IControlState Send();
        IControlState Iddle();
        IControlState Close();
        IControlState Danger();
    }
}