using System;

namespace Duck {
    public abstract class Duck {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public abstract void Display();

        public void PerformFly() {
            flyBehavior.Fly();
        }

        public void PerformQuack() {
            quackBehavior.Quack();
        }

        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
