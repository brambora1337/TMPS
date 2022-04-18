using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class GpuSystemComponent
    {
        public string Name { get; }

        public GpuSystemComponent(string name)
        {
            Name = name;
        }

        public abstract void Display(int level = 0);
    }
}
