using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Hands : Arms
    {
        int numberOfHands;
        public Hands()
        {
            numberOfHands = 2;
        } 
        public void ShootLaserBeam()
        {
            Console.WriteLine("Pew, pew, pew!");
        }
    }
}
