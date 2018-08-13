using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public abstract class Animal
    {
        // Name is the species family of the animal 
        public string Name { get; set; }

        // Life Span is the number of years the animal lives for
        public int LifeSpan { get; set; }
        // Hunger is measured from 1-100 (1 being "eats infrequently" and 100 being "eats constantly")
        public int Hunger { get; set; }
        public abstract void Move();
        public abstract void Poop();
        public virtual void Feed()
        {
            Console.WriteLine("nom");
        }
        public Animal(string name, int lifespan, int hunger)
        {
            this.Name = name;
            this.LifeSpan = lifespan;
            this.Hunger = hunger;
        }
    }

    public abstract class Mammal : Animal
    {
        // The number of legs 
        public int Legs { get; set; }
        // The number of eyes
        public int Eyes { get; set; }
        public Mammal(int legs, int eyes) : base("mammal", 10, 56)
        {
            this.Legs = legs;
            this.Eyes = eyes;
        }
    }
    public abstract class Reptile : Animal
    {
        // Number of legs
        public int Legs { get; set; }
        // Number of scales
        public int Scales { get; set; }
        public Reptile(int legs, int scales) : base("reptile", 7, 33)
        {
            this.Legs = legs;
            this.Scales = scales;
        }

    }
    public class Doggo : Mammal
    {
        // Breed of the dog
        public string Breed { get; set; }
        // Sound of the animal's feces
        public override void Poop()
        {
            Console.WriteLine("splat");
        }
        // Sound of the movement
        public override void Move()
        {
            Console.WriteLine("pitter patter");
        }
        // Sound of food being eaten
        public override void Feed()
        {
            Console.WriteLine("crunch");
        }
        public Doggo(string breed) : base(4, 2)
        {
            this.Breed = breed;
        }
    }
    public class Pusspuss : Mammal
    {
        // Breed of the cat
        public string Breed { get; set; }
        // Sound of the animal's feces
        public override void Poop()
        {
            Console.WriteLine("plop");
        }
        // Sound of the movement
        public override void Move()
        {
            Console.WriteLine("whoosh");
        }
        // Sound of food being eaten
        public override void Feed()
        {
            Console.WriteLine("chomp");
        }
        public Pusspuss(string breed) : base(4, 2)
        {
            this.Breed = breed;
        }
    }
    public abstract class Snake : Reptile
    {
        // Subspecies of Snake
        public string Subspecies { get; set; }
        // Sound of the animal's feces
        public override void Poop()
        {
            Console.WriteLine("ooze");
        }
        // Sound of the animal's movement
        public override void Move()
        {
            Console.WriteLine("slither");
        }
        // Sound of food being eaten
        public override void Feed()
        {
            Console.WriteLine("hissss");
        }
        public Snake(string subspecies, int poop, string move, string food) : base(0, 2)
        {
            this.Subspecies = subspecies;
        }
    }
}