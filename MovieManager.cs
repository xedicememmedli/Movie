using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APA201.Services
{
    public class MovieManager
    {
        public static string path="C:\\Users\\PC\\source\\repos\\APA201\\APA201\\Data\\movie.json";
            
        public static void Add(List<Models.Movie>movies)
        {
            try
            {
                var json = JsonConvert.SerializeObject(movies, Formatting.Indented);
                using (StreamWriter sw= new StreamWriter(path))
                    {
                    sw.WriteLine(json);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<Models.Movie> Show()
        {
            try
            {
                string result;
                using (StreamReader sr = new StreamReader(path))
                {
                    result = sr.ReadToEnd();
                }
                List<Models.Movie> movies = JsonConvert.DeserializeObject<List<Models.Movie>>(result);
                return movies;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
