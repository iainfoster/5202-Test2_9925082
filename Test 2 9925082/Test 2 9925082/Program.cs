using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Composer Iain Foster
// This application is to help Wingspan National Bird of Prey
// manage bird more effectivly
namespace Test_2_9925082
{
    class Bird
    {
        // 5 auto implemented properties
        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Weight { get; set; }
        public string BandNo { get; set; }
        // Constructor
        public Bird(string name, string species, string sex, string weight, string bandNo)
        {
            Name = name;
            Species = species;
            Sex = sex;
            Weight = weight;
            BandNo = bandNo;
        }
        // Methord
        public string DisplayBird()
        {
            return Name + "" + Species + "" + Sex + "" + Weight + "" + BandNo;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bird object created and default data loaded...");
            Console.WriteLine("\nPLEASE UPDATE BIRD DATA");
            Console.Write("\nEnter Bird name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Species: ");
            string species = Console.ReadLine();
            Console.Write("Enter sex of Bird: ");
            string sex = Console.ReadLine();
            Console.Write("Enter weight of Bird: ");
            string weight = Console.ReadLine();
            Console.Write("Enter Band number of Bird: ");
            string bandNo = Console.ReadLine();

            Bird b1 = new Bird(name, species, sex, weight, bandNo);

            Console.WriteLine("\n**************************************");
            Console.WriteLine("BIRD OF PREY DATA OUTUT");
            Console.WriteLine($"Name: {b1.Name}\nSpecies: {b1.Species}\nSex: {b1.Sex}\nWeight: {b1.Weight}\nBandNumber: {b1.BandNo}");
            Console.WriteLine("**************************************");
            Console.ReadKey();
        }
    }
}
