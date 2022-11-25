namespace Microsoft.StandardUI.Avalonia
{
    public interface ILogicalParent
    {
        void AddLogicalChild(object child);

        void RemoveLogicalChild(object child);
    }
}