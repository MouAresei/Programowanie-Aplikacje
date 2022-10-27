using System;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            Dog secondDog = new Dog("Burek", 5);

            Dog thirdDog = new Dog(secondDog);

            firstDog.ShowInfo();
            secondDog.Bark();
            thirdDog.ChasePostman();

            Cat firstCat = new Cat("Mruczek", 12);
            firstCat.ShowInfo();
            firstCat.Meow();
            firstCat.ClimbOnTree();
        }
    }
}
