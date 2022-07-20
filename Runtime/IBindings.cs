namespace Common.MVVM
{
    public interface IBindings
    {
        void AddBinding(IBinding binding);

        bool RemoveBinding(IBinding binding);

        void ClearBindings();
    }
}
