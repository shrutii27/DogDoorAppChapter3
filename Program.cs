using DogDoorAppChapter3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorAppChapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int returnBeforeDoorClose = 2000;
            int returnAfterDoorClose = 10000;
            bool ownersResponsive = true;

            DogDoorSimulator.DogDoorTestPath(returnBeforeDoorClose, ownersResponsive);
            //dog returns after door closes
            DogDoorSimulator.DogDoorTestPath(returnAfterDoorClose, ownersResponsive);

            // returns before door closes
            DogDoorSimulator.DogDoorTestPath(returnBeforeDoorClose, !ownersResponsive);

            // returns after door closes
            DogDoorSimulator.DogDoorTestPath(returnAfterDoorClose, !ownersResponsive);

            Console.WriteLine("\nTest passed! Press any key to continue.\n");

            Console.ReadKey();
        }
    }
}
