using System;

namespace Duck
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallarDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck redhead = new RedheadDuck();
            redhead.PerformQuack();
            redhead.PerformFly();

            Duck rubber = new RubberDuck();
            rubber.PerformQuack();
            rubber.PerformFly();

            Duck decoy = new DecoyDuck();
            decoy.PerformQuack();
            decoy.PerformFly();
        }
    }
}
