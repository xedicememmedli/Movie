using APA201.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APA201.Models
{
   
    public class Movie : Media, IPlayable
    {
        public Genre Genre { get; set; }
        public bool Watched { get; set; }

        public Movie( string Title, int year, Genre Genre, bool Watched)

        {
            this.Title = Title;
            this.Year = year;
            this.Genre = Genre;
            this.Watched = Watched;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Title} | {Genre} | {Watched}");
        }

        public void MarkAsWatched()
        {
            Watched = true;
            Console.WriteLine($"(Title) izlenilib deye isarelendi.");
        }

        public void MarkAsUnwatched()
        {
            Watched = false;
            Console.WriteLine($"(Title) izlenilmeyib deye isarelendi.");
        }


    }
}
