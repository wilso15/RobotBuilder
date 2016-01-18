using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Arms
    {
        int numberOfArms;
        public Arms()
        {
            numberOfArms = 2;
        }
        public void LiftLaserBeam()
        {
            Console.WriteLine("Aiming the laser beam.");
        }

    }
}
