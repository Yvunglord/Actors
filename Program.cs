using Actors.Readers;
using Actors.Record;
using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Actors
{
    class Program
    {
        static void Main(string[] args) 
        {
            /* string path = "C:\\Users\\k_yak\\Desktop\\ml-latest\\Ratings_IMDB.tsv";
             RatingReader ratingReader = new RatingReader();
             List<Rating> ratings = ratingReader.ReadRatings(path);

             foreach(var rating in ratings)
                 Console.WriteLine(rating);*/

            /*string path = "C:\\Users\\k_yak\\Desktop\\ml-latest\\ActorsDirectorsCodes_IMDB.tsv";
            MovieActorDirectorReader reader = new MovieActorDirectorReader();
            List<MovieActorDirector> movieActorDirectors = reader.ReadMovieActorDirector(path);
            foreach (var actor in movieActorDirectors)
            {
                Console.WriteLine(actor);
            }*/

            /* string path = "C:\\Users\\k_yak\\Desktop\\ml-latest\\ActorsDirectorsNames_IMDB.txt";
             PersonDataReader reader = new PersonDataReader();
             List<PersonData> personDatas = reader.ReadPersonData(path);
             foreach (var person in personDatas)
                 Console.WriteLine(person);*/

            /*string path = "C:\\Users\\k_yak\\Desktop\\ml-latest\\MovieCodes_IMDB.tsv";
            MovieCodeReader reader = new MovieCodeReader();
            List<MovieCode> movieCodes = reader.ReadMovieCodes(path);
            foreach (var movieCode in movieCodes) 
            {
                Console.WriteLine(movieCode);
            }*/

            /*string path = "C:\\Users\\k_yak\\Desktop\\ml-latest\\links_IMDB_MovieLens.csv";
            LinkReader reader = new LinkReader();
            List<Link> links = reader.ReadLinks(path);
            foreach (Link link in links) 
            {
                Console.WriteLine(link);
                
            }
            Console.WriteLine(links.Count);*/

            /*string path = "C:\\Users\\k_yak\\Desktop\\ml-latest\\TagCodes_MovieLens.csv";
            TagCodeReader reader = new TagCodeReader();
            List<TagCode> tagCodes = reader.ReadTagCodes(path);
            foreach (TagCode tagCode in tagCodes) 
            {
                Console.WriteLine(tagCode);
            }*/

            string path = "C:\\Users\\k_yak\\Desktop\\ml-latest\\TagScores_MovieLens.csv";
            TagScoreReader reader = new TagScoreReader();
            List<TagScore> tagScores = reader.ReadTagScores(path);
            foreach (TagScore tagScore in tagScores) 
            {
                Console.WriteLine(tagScore);
            }

        }
    }
}
