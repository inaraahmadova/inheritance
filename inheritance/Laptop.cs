using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Laptop : Device
    {
        public int PortCount;
        public Laptop(int width, int height, int weight, int portCount) : base(width, height, weight)
        {
            PortCount = portCount;
        }
    }
}
