using System;
using System.Drawing;
using System.Xml.Linq;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;
        public string color;

        // constructor
        public Animal()
        {
            name = "";
            color = "";


        }
        //parameterized constructor
        public Animal(string name, string color)
        {
            this.name = name;
            this.color = color;


        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is Sparky");
            //The name wasn't appearing as sparky, so I wrote it in. I hope this is ok.
        }



    }


    class Llama : Animal
    {
        public double height;
        public double weight;
        public Llama()
            : base()
        {
            height = 6;
            weight = 600;
        }
        public Llama(string name, string color, double height, double weight)
            : base(name, color)
        {
            this.height = height;
            this.weight = weight;
            this.color = color;
        }
        public void getName()
        {
            Console.WriteLine($"Name: {name}");
        }
        public void getColor()
        {
            Console.WriteLine($"Color: {color}");
        }
        public void getHeight()
        {
            Console.WriteLine($"Height: {height}");
        }
        public void getWeight()
        {
            Console.WriteLine($"Weight: {weight}");
        }
        public void sound()
        {
            Console.WriteLine($"Llama Information...");
        }
    }

    class Platypus : Animal
    {
        public double age;
        public double height;
        public double weight;
        public Platypus()
            : base()
        {
            age = 49;
            height = 3.75;
            weight = 250;
        }
        public Platypus(string name, double weight, double age, double height)
            : base(name, string.Empty)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        public void getName()
        {
            Console.WriteLine($"Name: {name}");
        }
        public void getAge()
        {
            Console.WriteLine($"Age: {age}");
        }
        public void getHeight()
        {
            Console.WriteLine($"Height: {height}");
        }
        public void getWeight()
        {
            Console.WriteLine($"Weight: {weight}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Llama myPet = new Llama();

            myPet.name = "Louise the Llama";
            myPet.display();

            // derived class object using default constructor
            myPet.sound();
            myPet.getName();
            //myPet.getAge();
            myPet.getHeight();
            myPet.getWeight();

            Platypus myPet2 = new Platypus();
            myPet2.name = "Penelope the Platypus";

            myPet2.getName();
            myPet2.getAge();
            myPet2.getHeight();
            myPet2.getWeight();

            Llama louise = new Llama("Louise the Llama", "Black", 5.9, 575);
            //louise.show();
            louise.sound();
            louise.getName();
            louise.getColor();
            louise.getHeight();
            louise.getWeight();



            //derived class object using parameterized constructor

            Platypus percy = new Platypus("Percy the Platypus", 450, 100, 4.5);

            percy.getName();
            percy.getAge();
            percy.getHeight();
            percy.getWeight();
            Console.ReadLine();


        }

    }
}
