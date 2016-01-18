using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Robot
    {
        Head head;
        Arms arms;
        Hands hands;
        Legs legs;
        Feet feet;
        Torso torso;
        
        public Robot()
        {
            head = new Head();
            arms = new Arms();
            hands = new Hands();
            legs = new Legs();
            feet = new Feet();
            torso = new Torso();
        }
        public void BuildRobot()
        {
            head.Looking();
            torso.OperateLimbs();
            arms.LiftLaserBeam();
            hands.ShootLaserBeam();
            legs.PowerStomp();
            feet.KickBall();
        }
    }
}
