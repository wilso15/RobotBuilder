using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Head : Torso
    {
        int eyes;
        public Head()
        {
            eyes = 2;
        }
        public void Looking()
        {
            Console.WriteLine("See's the world.");
        }
    }
}
