using System;

namespace Duck {
    public class RedheadDuck: Duck {
        public RedheadDuck(){
            quackBehavior = new TheQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Redhead duck");
        }
    }
}
