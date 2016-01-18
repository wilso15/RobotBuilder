using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Feet : Legs
    {
        int numberOfFeet;
        public Feet()
        {
            numberOfFeet = 2;
        }
        public void KickBall()
        {
            Console.WriteLine("The soccer ball went so far, you can't even see it.");
        }
    }
}
