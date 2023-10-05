using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorAppChapter3.Model
{
    internal class BarkRecognizer
    {
        private DogDoor _door;
        public BarkRecognizer(DogDoor door)
        {
            _door = door;
        }
        public void recognize(string bark)
        {
            Console.WriteLine("BarkRecognizer: Heard a '" + bark + "'");
            _door.open();
        }
    }
}
