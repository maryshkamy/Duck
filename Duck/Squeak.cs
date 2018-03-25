using System;

namespace Duck {
    public class Squeak: IQuackBehavior {
        public void Quack() {
            Console.WriteLine("Squeak");
        }
    }
}
