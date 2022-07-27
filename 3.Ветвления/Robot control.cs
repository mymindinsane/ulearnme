using System;

namespace Robot_control
{
    class Program
    {
        static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        { 
            return enemyInFront && ((enemyName == "boss") && (robotHealth >= 50)) || (enemyInFront && enemyName != "boss");
        }
    }
}