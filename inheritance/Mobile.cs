using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Mobile : Device
    {
        public string[] SimCards;
        public Mobile(int width, int height, int weight, int simCardCount) : base(width, height, weight)
        {
            if (simCardCount < 0 || simCardCount > 2)
            {
                Console.WriteLine("simcard'in sayi 1 ve ya 2 olmalidir.");
            }
            else if (simCardCount == 0)
            {
                SimCards = new string[simCardCount];
            }
            else if (simCardCount == 1)
            {
                SimCards = new string[simCardCount];
            }
            else if (simCardCount == 2)
            {
                Console.WriteLine("simCard ucun yer yoxdur.");
            }
        }
        public void AddNumber(int simCardCoint, string number)
        {
            if (simCardCoint < 0)
            {
                Console.WriteLine("Uygun olmayan indeks.");
            }
            else if (simCardCoint == 0 || simCardCoint == 1)
            {
                Array.Resize(ref SimCards, SimCards.Length + 1);
                SimCards[SimCards.Length - 1] = number;
            }
        }
        public void RemoveNumber(int index, string number)
        {
            string[] newArr = new string[SimCards.Length - 1];
            int index1 = 0;
            for (int i = 0; i < SimCards.Length; i++)
            {
                if (SimCards[i] == number)
                {
                    continue;
                }
                newArr[index] = SimCards[i];
                index++;
            }
            SimCards = newArr;
            Console.WriteLine($"silinen nomre {number}-dir");
        }
        public void GetNumbers()
        {
            foreach (string number in SimCards)
            {
                Console.WriteLine(number);
            }
        }
    }
}
