using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.BuildRobot();
            Console.Read();
        }
    }
}
