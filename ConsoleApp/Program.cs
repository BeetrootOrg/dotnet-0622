using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Weapon[] inventory = { new M17(), new Ballista(), new Bow() };

            foreach (var item in inventory)
            {
                person.Showinfo(item);
                person.Fire(item);
            }

        }
    }

    abstract class Weapon
    {
        public abstract void Fire();
        public void Showinfo()
        {
            Console.WriteLine(GetType().Name);
        }

    }

    class Person
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void Showinfo(Weapon weapon)
        {
            weapon.Showinfo();
        }

    }

    class M17 : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("тататататата");
            Console.WriteLine();
        }
    }

    class Ballista : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("ВЖЖЖЖУУУУХ");
            Console.WriteLine();
        }
    }

    class Bow : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("ПиииууууТрррррррр");
            Console.WriteLine();
        }
    }
}


