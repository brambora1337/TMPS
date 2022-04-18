using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder GPU = new Folder("GPU");

            Gpu gpunvdia1 = new Gpu("GEFORCE RTX 3090");
            Gpu gpunvdia2 = new Gpu("GEFORCE RTX 3080");
            Gpu gpunvdia3 = new Gpu("GEFORCE RTX 3070");
            Folder NVIDIA = new Folder("NVIDIA");

            Gpu gpuamd1 = new Gpu("AMD Radeon RX 6900 XT");
            Gpu gpuamd2 = new Gpu("AMD Radeon RX 6800 XT");
            Gpu gpuamd3 = new Gpu("AMD Radeon RX 6800");
            Folder AMD = new Folder("AMD");

            NVIDIA.AddComponent(gpunvdia1);
            NVIDIA.AddComponent(gpunvdia2);
            NVIDIA.AddComponent(gpunvdia3);
            GPU.AddComponent(NVIDIA);

            AMD.AddComponent(gpuamd1);
            AMD.AddComponent(gpuamd2);
            AMD.AddComponent(gpuamd3);
            GPU.AddComponent(AMD);

            GPU.Display();

            
        }
    }
}
