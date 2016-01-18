using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Torso
    {
        int numberOfCPUs;
        bool isOn;
        public Torso()
        {
            numberOfCPUs = 1;
            isOn = true;
        }
        public void OperateLimbs()
        {
            Console.WriteLine("The arms and legs are operational.");
        }
    }
}
