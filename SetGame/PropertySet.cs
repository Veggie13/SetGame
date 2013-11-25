using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGame
{
    public class PropertySet
    {
        private Dictionary<PropertyTypes, int> _valueMap = new Dictionary<PropertyTypes, int>();

        public PropertySet(params int[] values)
        {
            for (int i = 0; i + 1 < values.Length; i += 2)
            {
                _valueMap[(PropertyTypes)values[i]] = values[i + 1];
            }
        }

        public int this[PropertyTypes prop]
        {
            get
            {
                return _valueMap[prop];
            }
        }

        public override int GetHashCode()
        {
            return _valueMap.Values.Select((v, i) => v * (1 << (4 * i))).Sum();
        }
    }
}
