using UnityEngine;

namespace Common.MVB
{
    public class BindingsBehaviour : MonoBehaviour, IBindings, IBinding
    {
        protected readonly Bindings _bindings = new Bindings();

        public void AddBinding(IBinding binding)
        {
            _bindings.AddBinding(binding);
        }

        public bool RemoveBinding(IBinding binding)
        {
            return _bindings.RemoveBinding(binding);
        }

        public void ClearBindings()
        {
            _bindings.ClearBindings();
        }

        public void Attach()
        {
            _bindings.Attach();
        }

        public void Detach()
        {
            _bindings.Detach();
        }

        protected virtual void OnEnable()
        {
            Attach();
        }

        protected virtual void OnDisable()
        {
            Detach();
        }

        protected virtual void OnDestroy()
        {
            _bindings.Dispose();
        }
    }

    public class BindingsBehaviour<T> : BindingsBehaviour
    {
        protected T _context;

        public virtual void Setup(T context)
        {
            _context = context;
        }
    }
}
