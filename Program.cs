using System;

namespace uppgift1
{
    class Program
{
    static void Main()
    {
        Console.WriteLine("Skriv ett ord med max 9 bokstäver: ");
        string ord = Console.ReadLine();

        Console.WriteLine("skriv antal upprepning du vill ha: ");
        int antalUpprepning = int.Parse(Console.ReadLine());

        if (ord.Length > 9 || antalUpprepning > 9)
        {
            Console.WriteLine("Glöm inte att antal upprepning och bokstäver är max 9");
        }
        else
        {
            for (int i = 0; i < antalUpprepning; i++)
            {
                Console.WriteLine(ord + " ");
            }
        }
    }
}
}




