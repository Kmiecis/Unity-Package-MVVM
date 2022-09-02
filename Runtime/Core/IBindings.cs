namespace Common.MVB
{
    public interface IBindings
    {
        void AddBinding(IBinding binding);

        bool RemoveBinding(IBinding binding);

        void ClearBindings();
    }
}
