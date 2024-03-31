namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mobile mobile = new Mobile(10, 5, 3, 0);
            mobile.OpenDevice();
            mobile.AddNumber(0, "070 726 77 07");
            mobile.AddNumber(0, "070 726 77 27");
            mobile.GetNumbers();
            mobile.RemoveNumber(0, "070 726 77 07");
            mobile.GetNumbers();

            mobile.CloseDevice();

            Laptop laptop = new Laptop(15, 10, 5, 4);
            Console.WriteLine($"Laptopun eni: {laptop.Width}, uzunlugu: {laptop.Height}, agirligi: {laptop.Weight}, Port Sayi: {laptop.PortCount}");
        }
    }
}

