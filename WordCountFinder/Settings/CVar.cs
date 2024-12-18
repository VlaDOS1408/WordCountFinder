using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountFinder.Settings
{
    internal class CVar<T>
    {
        public CVar(string name, T value, bool canChangeValue = false)
        {
            Name = name;
            _value = value;
            _canChangeValue = canChangeValue;
        }

        public string Name { get; private set; }

        private T _value;
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                // мм, ↓ хуета
                if (!_canChangeValue)
                    throw new Exception("Value is locked");
                                
                _value = value;
            }
        }

        private bool _canChangeValue;
    }
}
