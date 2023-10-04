using System;

namespace ArdalisRating
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lisseth Tatiana Quilindo Patiño (506222011)
            //Daniel Esteban Torres Triana (506222711)
            Console.WriteLine("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine();
            engine.Rate();

            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }

        }
    }
}
