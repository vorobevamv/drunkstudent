using System;

namespace drunkstudent
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.Name = "Petya";
            student.Age = 18;
            student.StudentBag = new();
            student.StudentBag.Capacity = 25;

            Console.WriteLine("How many bottles of beer do you want to take?");
            int beer = int.Parse(Console.ReadLine());
            bool status = student.StudentBag.AddBeer(beer, student.StudentBag);

            if (!status)
            {
                Console.WriteLine("There is not enought place in bag.");
            }
            else
            {
                Console.WriteLine("Beer added to bag.");
                Console.WriteLine("How many pieces of pizza do you want to take?");
                int pizza = int.Parse(Console.ReadLine());
                status = student.StudentBag.AddPizza(pizza, student.StudentBag);
                if (!status)
                {
                    Console.WriteLine("There is not enought place in bag.");
                }
                else
                {
                    Console.WriteLine("Pizza added to bag.");
                    string drunk = student.CountDrunk(student);
                    string satiety = student.CountSatiety(student);

                    Console.WriteLine($"Student {student.Name} bought {student.StudentBag.PizzaPieces} pieces of pizza and {student.StudentBag.BeerBottles} bottles of beer" +
                        $" and result is '{drunk}' and '{satiety}'");
                }
            }
        }
    }
}
