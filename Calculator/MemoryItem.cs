using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryItem
    {
        public long MemoryItemResult { get; set; }

        public MemoryItem(long x)
        {
            this.MemoryItemResult = x;
        }
        public void MemoryItemAdd(long x)
        {
            this.MemoryItemResult += x;
        }

        public void MemoryItemSubtract(long x)
        {
            this.MemoryItemResult -= x;
        }
    }
}
