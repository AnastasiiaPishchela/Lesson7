using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask7._2
{
    //Создать класс «животные», производные классы «хищники» и «травоядные», затем производные классы
    //«волк», «лиса», «заяц», «олень». Содержимое класса – на собственное усмотрение.Создать массив
    //объектов с произвольным количеством экземпляров всех указанных классов и подсчитать, сколько в
    //массиве хищников и травоядных, волков, лис, зайцев и оленей2
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal> { new Predator(), new Herbivores(), new Herbivores(), new Wolf(), new Wolf(), new Wolf(), new Fox(), new Fox(), new Fox(), new Fox(),
                new Rabbit(), new Rabbit(), new Rabbit(), new Rabbit(), new Rabbit(), new Deer(), new Deer(), new Deer(), new Deer(), new Deer(), new Deer()};
            IDictionary<string, int> table = new Dictionary<string, int>()
            {
                 { "Fox", 0},
                 { "Wolf", 0},
                 { "Rabbit", 0},
                 { "Deer", 0},
                 { "Predator", 0},
                 { "Herbivores", 0}
            };
            foreach (Animal animal in animalList)
            {
                switch (animal)
                {
                    case Fox p:
                        table["Fox"] = table["Fox"] + 1;
                        break;
                    case Wolf p:
                        table["Wolf"] = table["Wolf"] + 1;
                        break;
                    case Rabbit p:
                        table["Rabbit"] = table["Rabbit"] + 1;
                        break;
                    case Deer p:
                        table["Deer"] = table["Deer"] + 1;
                        break;
                    case Predator p:
                        table["Predator"] = table["Predator"] + 1;
                        break;
                    case Herbivores p:
                        table["Herbivores"] = table["Herbivores"] + 1;
                        break;
                }

            }
            foreach (KeyValuePair<string, int> entry in table)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                            entry.Key,
                                                            entry.Value);
            }
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string getAnimalName();
    }

    class Predator : Animal
    {
        public override string getAnimalName()
        {
            return "Predator";
        }
    }

    class Herbivores : Animal
    {
        public override string getAnimalName()
        {
            return "Herbivores";
        }

    }

    class Wolf : Predator
    {
        public override string getAnimalName()
        {
            return "Wolf";
        }

    }

    class Fox : Predator
    {
        public override string getAnimalName()
        {
            return "Fox";
        }

    }

    class Rabbit : Herbivores
    {
        public override string getAnimalName()
        {
            return "Rabbit";
        }

    }

    class Deer : Herbivores
    {
        public override string getAnimalName()
        {
            return "Deer";
        }

    }


}
