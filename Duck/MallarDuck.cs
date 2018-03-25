using System;

namespace Duck {
    public class MallarDuck: Duck {
        public MallarDuck() {
            quackBehavior = new TheQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
