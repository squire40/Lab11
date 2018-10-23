using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = false;
            string input = null;
            bool isValidInput = false;

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine($"There are {MovieList.Count} movies in this list.");
            do
            {
                shouldContinue = false;

                Console.WriteLine("What category are you interested in?");
                Console.WriteLine();
                DisplayCategoryMenu();
                do
                {
                    isValidInput = true;
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        DisplayMoviesByCategory("Animated");
                    }
                    else if (input == "2")
                    {
                        DisplayMoviesByCategory("Drama");
                    }
                    else if (input == "3")
                    {
                        DisplayMoviesByCategory("Horror");
                    }
                    else if (input == "4")
                    {
                        DisplayMoviesByCategory("Scifi");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                        isValidInput = false;
                    }
                } while (!isValidInput);

                Console.WriteLine();
                Console.WriteLine("Continue? (y/n)");
                input = Console.ReadLine();
                if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    shouldContinue = true;
                }
            } while (shouldContinue);
        }

        private static void DisplayMoviesByCategory(string category)
        {
            MovieList.Sort(new MovieCompare());

            foreach (Movie movie in MovieList)
            {
                if (movie.Category.Equals(category))
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        private static void DisplayCategoryMenu()
        {
            Console.WriteLine("1 Animated");
            Console.WriteLine("2 Drama");
            Console.WriteLine("3 Horror");
            Console.WriteLine("4 Scifi");
        }

        static ArrayList MovieList = new ArrayList()
        {
            new Movie("Smallfoot", "Animated"),
            new Movie("Incredibles 2", "Animated"),
            new Movie("Coco", "Animated"),
            new Movie("A Star is Born", "Drama"),
            new Movie("First Man", "Drama"),
            new Movie("Bohemian Rhapsody", "Drama"),
            new Movie("Halloween", "Horror"),
            new Movie("The Nun", "Horror"),
            new Movie("Mandy", "Horror"),
            new Movie("Venom", "Scifi")
        };
    }

}
