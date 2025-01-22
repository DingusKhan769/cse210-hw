using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Moive favoriteMovie = new Moive();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._runtime = 150;
        favoriteMovie._rating = "PG";

        Moive otherMovie = new Moive();
        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._runtime = 162;
        otherMovie._rating = "PG-13";

        Console.WriteLine(favoriteMovie._title);

        favoriteMovie.Display();

        DisplayMovie(favoriteMovie);
        DisplayMovie(otherMovie);
        
    }

    static void DisplayMovie(Moive aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }
}