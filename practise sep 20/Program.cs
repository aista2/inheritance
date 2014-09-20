using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_sep_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.type = "i am a cat";

            Dog d1 = new Dog();
            d1.type = "i am a dog";

            Console.WriteLine(c1.MakeNoice());
            Console.WriteLine(d1.MakeNoice());
            

            List<Dog> dogs = new List<Dog>();
            dogs.Add(d1);

            foreach (var dog in dogs)
            {
                    Console.WriteLine(dog.type);
            }


        }
    }
}
