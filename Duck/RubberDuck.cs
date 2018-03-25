using System;

namespace Duck {
    public class RubberDuck: Duck {
        public RubberDuck() {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Rubber duck");
        }
    }
}
