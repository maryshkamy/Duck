using System;

namespace Duck {
    public class TheQuack: IQuackBehavior {
        public void Quack() {
            Console.WriteLine("Quack");
        }
    }
}
