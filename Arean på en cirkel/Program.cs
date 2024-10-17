namespace Arean_på_en_cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arean med radien 5
            Circle circle = new Circle(5);
            Console.WriteLine($"Arean av en cirkel med radien 5 är: {circle.GetArea()}");
            // Arean med radien 6
            Circle circle2 = new Circle(6);
            Console.WriteLine($"Arean av en cirkel med radien 6 är: {circle2.GetArea()}");

        }
    }
}
