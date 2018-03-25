using System;

namespace Duck {
    public class DecoyDuck: Duck {
        public DecoyDuck() {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Decoy duck");
        }
    }
}
