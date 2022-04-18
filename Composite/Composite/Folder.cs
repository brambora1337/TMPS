using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Folder : GpuSystemComponent
    {
        private List<GpuSystemComponent> _components = new List<GpuSystemComponent>();

        public Folder(string name) : base(name)
        {

        }

        public override void Display(int level = 0)
        {
            string spaces = new string(' ', level);

            Console.WriteLine(spaces + "└ " + Name);
            foreach (var component in _components)
                component.Display(level + 1);
        }

        public void AddComponent(GpuSystemComponent component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(GpuSystemComponent component)
        {
            _components.Remove(component);
        }
    }
}
