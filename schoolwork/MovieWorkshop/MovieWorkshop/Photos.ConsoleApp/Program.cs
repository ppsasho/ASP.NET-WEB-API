using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Photos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Photo> photos = GetPhotos();

            foreach (Photo photo in photos) Console.WriteLine($"" +
                $"AlbumId: {photo.AlbumId}\n" +
                $"Id: {photo.Id}\n" +
                $"Title: {photo.Title}\n" +
                $"Url: {photo.Url}\n" +
                $"ThumbnailUrl: {photo.ThumbnailUrl}\n\n"
                );

                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
                return;
        }

        static List<Photo> GetPhotos()
        {
            string url = "https://jsonplaceholder.typicode.com/photos";
            using(HttpClient client = new HttpClient()) 
            {
                var response = client.GetAsync(url).Result;
                List<Photo> photos = JsonConvert.DeserializeObject<List<Photo>>(response.Content.ReadAsStringAsync().Result);
                return photos;
            }
        }
    }
}
