using System;

namespace Midterm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string movieName, mainActor, genre, director;

            MovieList movieList = new MovieList();

            movieList.InitializeMovieList();

            do
            {
                menu = MenuInstructions();

                switch (menu)
                {
                    case 1: //Display movies
                        movieList.DisplayMovieList();
                        break;
                    case 2: //Sort movies
                        SortSwitch(movieList); //Selects the correct sort
                        movieList.DisplayMovieList();
                        break;
                    case 3: //Search movies
                        SearchAndDisplaySwitch(movieList);
                        break;
                    case 4: //Add a movie
                        movieName = StrInput("Please enter Movie Name >> ");
                        mainActor = StrInput("Please enter Lead Actor/Actress's Name >> ");
                        genre = StrInput("Please enter Movie Genre >> ");
                        director = StrInput("Please enter the Movie's Director >> ");
                        movieList.AddMovieToList(movieName, mainActor, genre, director);
                        Console.WriteLine("Your movie was added to the bottom of the list!");
                        break;
                    case 5: //Quit program
                        Console.WriteLine("\nThank you for stopping by, have a great day!\n");
                        break;
                    default:
                        Console.WriteLine("\n\n***Input not accepted, returning to main menu***\n\n");
                        break;
                }
            } while (menu != 5);
        }
        private static void SearchAndDisplaySwitch(MovieList movieList)
        {
            int searchMenu;
            string searchInput;

            searchMenu = IntInput("1. Search by Name\n2. Search by Genre\n3. Search by Director\n4. Search by Actor\n >> ");
            switch (searchMenu)
            {
                case 1:
                    searchInput = StrInput("Enter Movie Name >> ");
                    movieList.SearchByNameAndDisplay(searchInput);
                    break;
                case 2:
                    searchInput = StrInput("Enter Genre >> ");
                    movieList.SearchByGenreAndDisplay(searchInput);
                    break;
                case 3:
                    searchInput = StrInput("Enter Director Name >> ");
                    movieList.SearchByDirectorAndDisplay(searchInput);
                    break;
                case 4:
                    searchInput = StrInput("Enter Actor Name >> ");
                    movieList.SearchByActorAndDisplay(searchInput);
                    break;
                default:
                    Console.WriteLine("\n\n***Input not accepted, returning to main menu***\n\n");
                    break;
            }
        }
        private static void SortSwitch(MovieList movieList)
        {
            int sortMenu;

            sortMenu = IntInput("1. Sort by Name\n2. Sort by Genre\n3. Sort by Director\n4. Sort by Actor\n >> ");
            switch (sortMenu)
            {
                case 1:
                    movieList.MovieSortByName();
                    break;
                case 2:
                    movieList.MovieSortByGenre();
                    break;
                case 3:
                    movieList.MovieSortByDirector();
                    break;
                case 4:
                    movieList.MovieSortByActor();
                    break;
                default:
                    Console.WriteLine("\n\n***Input not accepted, returning to main menu***\n\n");
                    break;
            }
        }
        private static int MenuInstructions()
        {
            return IntInput($"{"MENU", 12}\n-==================-\n1. Display Movies\n2. Sort Movies\n3. Search Movies\n" +
                "4. Add A Movie\n5. Quit\n >> ");
        }
        private static int IntInput(string text)
        {
            Console.Write($"{text}");
            string s = Console.ReadLine();
            bool worked = int.TryParse(s, out int x);

            while (!worked)
            {
                Console.Write($"\n**Input not accepted**\n{text}");
                s = Console.ReadLine();
                worked = int.TryParse(s, out x);
            }
            return x;
        }
        private static string StrInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
    }
}
