using System;
using System.Collections.Generic;

namespace Common.MVVM
{
    public class Bindings : IBinding, IDisposable
    {
        protected readonly List<IBinding> _bindings = new List<IBinding>();
        protected bool _attached;

        public void AddBinding(IBinding binding)
        {
            _bindings.Add(binding);

            if (_attached)
            {
                binding.Attach();
            }
        }

        public bool RemoveBinding(IBinding binding)
        {
            var removed = _bindings.Remove(binding);
            if (removed && _attached)
            {
                binding.Detach();

                if (_bindings.Count == 0)
                {
                    _attached = false;
                }
            }
            return removed;
        }

        public void ClearBindings()
        {
            Detach();

            _bindings.Clear();
        }

        public void Attach()
        {
            if (!_attached)
            {
                foreach (var binding in _bindings)
                {
                    binding.Attach();
                }
                _attached = true;
            }
        }

        public void Detach()
        {
            if (_attached)
            {
                foreach (var binding in _bindings)
                {
                    binding.Detach();
                }
                _attached = false;
            }
        }

        public virtual void Dispose()
        {
            ClearBindings();
        }
    }

    public class Bindings<T> : Bindings
    {
        protected readonly T _context;

        public Bindings(T context)
        {
            _context = context;
        }
    }
}
