using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR5
{
    //Интерфейс с методом Voice
    interface IAnimal
    {
        void Voice();
    }

    //Классы с интерфейсом IAnimal
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }

    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }

    class sheep : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("БЭЭЭЭЭЭЭ!");
        }
    }
    class pig : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("УИИИИИ! КАСПЕРСКИЙ ОБНАРУЖИЛ УГРОЗУ");
        }
    }

    class Owl : IAnimal
    {
        //Чтение времени(Часа) из файла
        private int GetCurrentTime()
        {
            return 21;
        }

        //Проверка времени и воспроизведение звука совы
        public void Voice()
        {
            int currentTime = GetCurrentTime();

            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тише, я сплю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }

    class Program
    {
        //Статический метод
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Мы гладим зверушку, а она нам говорит: ");
            animal.Voice();
        }

        static void Main(string[] args)
        {
            //Приветствие пользователя
            Console.WriteLine("Вас приветсвует наш гладильный зоопарк!");

            //Инициализация объектов с интерфейсом и дочерним классом
            Dog tuzik = new Dog();
            PetAnimal(tuzik);

            Cat boris = new Cat();
            PetAnimal(boris);

            IAnimal hewdig = new Owl();
            PetAnimal(hewdig);

            IAnimal pig = new pig();
            PetAnimal(pig);

            IAnimal sheep = new sheep();
            PetAnimal(sheep);

            Console.ReadKey(true);
        }
    }
}
