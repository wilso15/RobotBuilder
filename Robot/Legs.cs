using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Legs
    {
        int numberOfLegs;
        public Legs()
        {
            numberOfLegs = 2;
        }
        public void PowerStomp()
        {
            Console.WriteLine("Pavement is destroyed from the force of the stomp.");
        }
    }
}
