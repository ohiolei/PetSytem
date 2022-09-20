using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{

    abstract class pets
    {
        public string name { get; set; }
        public string color { get; set; }
        public int legs { get; set; }
        public string sex { get; set; }
        public int Speed { get; set; }
        public abstract void Name(string Name);
        public abstract void Color(string Color);
        public virtual int Legs(int legs)
        {
            this.legs = legs;
            return legs;
        }
        public abstract void Sex(string sex);
        public abstract void Movement(int Speed);
        public abstract void display();
    }
    class dogs : pets
    {
        public override void Name(string Name)
        {
            name = Name;
        }
        public override void Color(string Color)
        {
            color = Color;
        }
        public override void Sex(string Sex)
        {
            sex = Sex;
        }
        public override int Legs(int Legs)
        {
            legs = Legs;
            return legs;
        }
        public override void Movement(int speed)
        {
            this.Speed = speed;
        }
           

        public override void display()
        {
            
            Console.WriteLine("dog name is {0}, dog color {1}, dog sex is {2}, dog has {3} legs", name, color, sex, legs);

            if (Speed <= 6)
            {
                Console.WriteLine("the dog is walking");
            }
            else if (Speed < 0)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine("the dog is moving fast");
            }
        }
    

    }
    class cats : pets
    {
        public override void Name(string Name)
        {
            name = Name;
        }
        public override void Color(string Color)
        {
            color = Color;
        }
        public override void Sex(string Sex)
        {
            sex = Sex;
        }
        public override int Legs(int Legs)
        {
            legs = Legs;
            return legs;
        }
        public override void Movement(int speed)
        {
            this.Speed = speed;
          
        }
        public override void display()
        {

            Console.WriteLine("cat name is {0}, cat color {1}, cat sex is {2}, cat has {3} legs", name, color, sex, legs);
            if (Speed <= 6)
            {
                Console.WriteLine("the cat is walking");
            }
            else if (Speed < 0)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine("the cat is moving fast");
            }
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            int NumberOfTimes = GetInt("How many pets do you want to store");

            List<pets> pets = new List<pets>();
            for (int i = 0; i < NumberOfTimes; i++)
            {
                Console.WriteLine("press 1 for a dog and 2 for a cat");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    dogs dog = new dogs();
                    dog.Name(GetString("name of pet"));
                    dog.Legs(GetInt("number of legs"));
                    dog.Sex(GetString("sex"));
                    dog.Color(GetString("color"));
                    dog.Movement(GetInt("what is the speed"));
                    pets.Add(dog);
                }
                else if (choice == 2)
                {
                    cats cat = new cats();
                    cat.Name(GetString("name of pet"));
                    cat.Legs(GetInt("number of legs"));
                    cat.Sex(GetString("sex"));
                    cat.Color(GetString("color"));
                    cat.Movement(GetInt("what is the speed"));
                    pets.Add(cat);
                }

                
            }
            if (pets.Count > 0)
            {
                while (true)
                {
                    Console.WriteLine("press 1 to view list and 2 to remove from list");
                    int action = int.Parse(Console.ReadLine());
                    if (action == 1)
                    {
                        foreach (pets pet in pets)
                        {
                            pet.display();
                        }
                    }
                    if (action == 2)
                    {
                        pets.RemoveAt(GetInt("index to remove"));
                    }

                }
            }
        }




        public static int GetInt(string Prompt)
        {
            Console.WriteLine("{0}", Prompt);
            return int.Parse(Console.ReadLine());
        }

        public static string GetString(string prompt)
        {
            Console.WriteLine("{0}", prompt);
            return Console.ReadLine();
        }

        public static bool GetBool(string prompt)
        {
            Console.WriteLine("{0}", prompt);
            return bool.Parse(Console.ReadLine());
        }

    }



}


