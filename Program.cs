namespace OOP_zad_rdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat1 = new Prostokat(2, 4);

            Console.WriteLine($"Pole prostokąta: {prostokat1.Pole()}");
            Console.WriteLine($"Obwód prostokąta: {prostokat1.Obwod()}");


            Trojkat trojkat1 = new Trojkat(3, 4, 5);

            Console.WriteLine($"\nPole trójkąta: {trojkat1.Pole()}");
            Console.WriteLine($"Obwód trójkąta: {trojkat1.Obwod()}");


            Kolo kolo1 = new Kolo(5.27);

            Console.WriteLine($"\nPole koła: {kolo1.Pole()}");
            Console.WriteLine($"Obwód koła: {kolo1.Obwod()}");
        }
    }
}
