using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Device
    {
        public int Width;
        public int Height;
        public int Weight;
        public bool isOpened = false;
        public Device(int width, int height, int weight)
        {
            Width = width;
            Height = height;
            Weight = weight;
        }
        public void OpenDevice()
        {
            if (!isOpened)
            {
                Console.WriteLine("Device acilir...");
            }
            else
            {
                Console.WriteLine("Device artiq aciqdir.");
            }
        }
        public void CloseDevice()
        {
            if (!isOpened)
            {
                Console.WriteLine("Device baglanir...");
            }
            else
            {
                Console.WriteLine("Device artiq baglidir.");
            }
        }
    }
}
