using System;


namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car focus = new Car();
            focus.Make = "Ford";
            focus.Model = "Focus";
            focus.Year = 2014;

            Console.WriteLine("The make is: " + focus.Make);
            Console.WriteLine("The model is: " + focus.Model);
            Console.WriteLine("The year is: " + focus.Year);
        }
    }
}
