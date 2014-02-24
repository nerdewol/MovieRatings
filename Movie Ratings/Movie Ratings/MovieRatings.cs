using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MovieRatings
    {
        static void Main(string[] args)
        {
            string caseSwitch = Console.ReadLine();
            //Initial movie list and ratings
            Dictionary<string, int> movies = new Dictionary<string, int>();
            movies.Add("Memento", 4);
            movies.Add("The Big Lebowski", 4);
            movies.Add("The Princess Bride", 5);
            

            while (caseSwitch != "Exit")
            {


                //Writes inital options
                Console.WriteLine("Please select one of the following:");
                Console.WriteLine("Add");
                Console.WriteLine("Update");
                Console.WriteLine("Display");
                Console.WriteLine("Delete");
                Console.WriteLine("Exit");

                //reads case option
                caseSwitch = Console.ReadLine();

                switch (caseSwitch.ToLower())
                {
                    //Adds a new record to the dictionary
                    case "add":
                        Console.WriteLine("What movie would you like to add?");
                        string movieName = Console.ReadLine();
                        string rating = "";
                        if (!movies.ContainsKey(movieName))
                        {
                            Console.WriteLine("On a scale of 1 to 5, how would you rate this film?");
                            rating = Console.ReadLine();
                            movies.Add(movieName, Convert.ToInt32(rating));
                            Console.WriteLine(movieName + " has been added to the database with a rating of " + rating);
                        }
                        else
                        {
                            Console.WriteLine("That movie is already in the database.");
                        }
                        break;
                    //Changes the rating of an existing movie
                    case "update":
                        Console.WriteLine("What movie would you like to update?");
                        movieName = Console.ReadLine();

                        if (!movies.ContainsKey(movieName))
                        {
                            Console.WriteLine("This movie is not in the database.");
                        }
                        else
                        {
                            //Deletes movie to update and re-adds with new rating
                            Console.WriteLine("What is your new rating on a scale of 1 to 5?");
                            string newRating = Console.ReadLine();
                            movies.Remove(movieName);
                            movies.Add(movieName, Convert.ToInt32(newRating));

                            Console.WriteLine(movieName + " now has a rating of " + newRating);
                        }
                        break;
                    //Displays all movies in database
                    case "display":
                        foreach (KeyValuePair<string, int> pair in movies)
                        {
                            Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                        }
                        break;
                    //Removes a movie from the dictionary
                    case "delete":
                        Console.WriteLine("What movie would you like to delete?");
                        movieName = Console.ReadLine();
                        break;
                    //The exit Case
                    case "exit":
                        Console.WriteLine("Thank you for using this program.  It will now close.");
                        break;
                    //The Default/Error case
                    default:
                        Console.WriteLine("That selection is invalid.  Please try again.");
                        break;

                }


                Console.ReadLine();

                
            }
        }
    }
}
