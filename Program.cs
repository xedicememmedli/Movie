using System;
using System.Security.Cryptography.X509Certificates;
using APA201.Models;
using APA201.Services;

class Program
{
    static void Main()
    {
        Movie movie = new Movie("Die Hard", 1988, Genre.Action, false);
        Movie movie_2 = new Movie("The Hangover", 2009, Genre.Comedy, false);
        Movie movie_3 = new Movie("The Shawshank Redemption", 1994, Genre.Drama, false);
        Movie movie_4 = new Movie("The Conjuring", 2013, Genre.Horror, false);

        List<Movie> movies = MovieManager.Show();
        movies.ForEach(movie => movie.DisplayInfo());

        MovieManager.Add(movies);
        //Console.WriteLine(MovieManager.Show());


        
    }
}
