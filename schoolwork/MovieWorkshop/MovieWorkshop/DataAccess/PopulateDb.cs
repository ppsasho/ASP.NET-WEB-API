using DomainModels;
using DomainModels.Enums;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public static class PopulateDb
    {
        public static void Populate(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Movie>()
                .HasData(new List<Movie>()
                {
                    new Movie { Id = 90, Title = "Echo of Dreams", Description = "A thrilling adventure into the unknown.", Genre = Genre.Fantasy, Year = 2012, ReleaseDate = new DateTime(2012, 5, 15), CreatedOn = DateTime.Now },
                    new Movie { Id = 1, Title = "Mystery Unveiled", Description = "An epic story of bravery and courage.", Genre = Genre.Thriller, Year = 2007, ReleaseDate = new DateTime(2007, 11, 23), CreatedOn = DateTime.Now },
                    new Movie { Id = 2, Title = "Journey Beyond", Description = "A mysterious journey into the unknown.", Genre = Genre.Adventure, Year = 2015, ReleaseDate = new DateTime(2015, 2, 5), CreatedOn = DateTime.Now },
                    new Movie { Id = 3, Title = "Love's Echo", Description = "A tale of love and loss.", Genre = Genre.Romance, Year = 2018, ReleaseDate = new DateTime(2018, 8, 14), CreatedOn = DateTime.Now },
                    new Movie { Id = 4, Title = "Time Chronicles", Description = "A gripping narrative that will keep you on the edge of your seat.", Genre = Genre.ScienceFiction, Year = 2020, ReleaseDate = new DateTime(2020, 12, 1), CreatedOn = DateTime.Now },
                    new Movie { Id = 5, Title = "Fallen Legends", Description = "An epic tale of myth and legend.", Genre = Genre.Action, Year = 2013, ReleaseDate = new DateTime(2013, 7, 21), CreatedOn = DateTime.Now },
                    new Movie { Id = 6, Title = "The Last Frontier", Description = "A journey to the edge of the world.", Genre = Genre.Adventure, Year = 2010, ReleaseDate = new DateTime(2010, 3, 30), CreatedOn = DateTime.Now },
                    new Movie { Id = 7, Title = "Haunting Shadows", Description = "A spine-chilling tale of suspense.", Genre = Genre.Horror, Year = 2019, ReleaseDate = new DateTime(2019, 10, 13), CreatedOn = DateTime.Now },
                    new Movie { Id = 8, Title = "Rising Stars", Description = "A story of dreams and aspirations.", Genre = Genre.Musical, Year = 2016, ReleaseDate = new DateTime(2016, 6, 18), CreatedOn = DateTime.Now },
                    new Movie { Id = 9, Title = "The Forgotten Realm", Description = "An adventure into an ancient world.", Genre = Genre.Fantasy, Year = 2011, ReleaseDate = new DateTime(2011, 4, 22), CreatedOn = DateTime.Now },
                    new Movie { Id = 10, Title = "Eternal Night", Description = "A dark thriller that will keep you guessing.", Genre = Genre.Thriller, Year = 2014, ReleaseDate = new DateTime(2014, 9, 15), CreatedOn = DateTime.Now },
                    new Movie { Id = 11, Title = "Wild Hearts", Description = "A story of wild adventures and untamed spirits.", Genre = Genre.Comedy, Year = 2021, ReleaseDate = new DateTime(2021, 1, 6), CreatedOn = DateTime.Now },
                    new Movie { Id = 12, Title = "Love's Journey", Description = "A touching tale of romance and heartache.", Genre = Genre.Romance, Year = 2008, ReleaseDate = new DateTime(2008, 2, 8), CreatedOn = DateTime.Now },
                    new Movie { Id = 13, Title = "Techno Dreams", Description = "A futuristic vision of technology and society.", Genre = Genre.ScienceFiction, Year = 2022, ReleaseDate = new DateTime(2022, 7, 22), CreatedOn = DateTime.Now },
                    new Movie { Id = 14, Title = "Broken Hearts Club", Description = "A story about love and friendship.", Genre = Genre.Comedy, Year = 2017, ReleaseDate = new DateTime(2017, 11, 25), CreatedOn = DateTime.Now },
                    new Movie { Id = 15, Title = "Action Heroes", Description = "A high-octane action film.", Genre = Genre.Action, Year = 2019, ReleaseDate = new DateTime(2019, 5, 10), CreatedOn = DateTime.Now },
                    new Movie { Id = 16, Title = "City Lights", Description = "A drama set against the backdrop of a bustling city.", Genre = Genre.Drama, Year = 2018, ReleaseDate = new DateTime(2018, 8, 30), CreatedOn = DateTime.Now },
                    new Movie { Id = 17, Title = "Ancient Prophecies", Description = "A tale of ancient prophecies and forgotten lands.", Genre = Genre.Fantasy, Year = 2010, ReleaseDate = new DateTime(2010, 10, 10), CreatedOn = DateTime.Now },
                    new Movie { Id = 18, Title = "Mystic Lands", Description = "An exploration of mystical lands and hidden secrets.", Genre = Genre.Adventure, Year = 2016, ReleaseDate = new DateTime(2016, 4, 15), CreatedOn = DateTime.Now },
                    new Movie { Id = 19, Title = "Dreamweavers", Description = "A magical tale of dreamers and their dreams.", Genre = Genre.Fantasy, Year = 2014, ReleaseDate = new DateTime(2014, 6, 21), CreatedOn = DateTime.Now },
                    new Movie { Id = 20, Title = "The Haunting", Description = "A chilling horror story with unexpected twists.", Genre = Genre.Horror, Year = 2011, ReleaseDate = new DateTime(2011, 3, 16), CreatedOn = DateTime.Now },
                    new Movie { Id = 21, Title = "Uncharted Paths", Description = "An adventurous journey through uncharted territories.", Genre = Genre.Adventure, Year = 2022, ReleaseDate = new DateTime(2022, 9, 7), CreatedOn = DateTime.Now },
                    new Movie { Id = 22, Title = "City of Dreams", Description = "A drama about the pursuit of dreams in a vibrant city.", Genre = Genre.Drama, Year = 2017, ReleaseDate = new DateTime(2017, 12, 14), CreatedOn = DateTime.Now },
                    new Movie { Id = 23, Title = "The Final Frontier", Description = "A sci-fi epic exploring the final frontiers of space.", Genre = Genre.ScienceFiction, Year = 2015, ReleaseDate = new DateTime(2015, 7, 5), CreatedOn = DateTime.Now },
                    new Movie { Id = 24, Title = "Echoes of the Past", Description = "A historical drama that uncovers echoes of the past.", Genre = Genre.Drama, Year = 2021, ReleaseDate = new DateTime(2021, 4, 18), CreatedOn = DateTime.Now },
                    new Movie { Id = 25, Title = "Laughs and Tears", Description = "A comedic drama filled with laughter and tears.", Genre = Genre.Comedy, Year = 2013, ReleaseDate = new DateTime(2013, 2, 14), CreatedOn = DateTime.Now },
                    new Movie { Id = 26, Title = "Horror Unleashed", Description = "A horror film that brings nightmares to life.", Genre = Genre.Horror, Year = 2020, ReleaseDate = new DateTime(2020, 10, 30), CreatedOn = DateTime.Now },
                    new Movie { Id = 27, Title = "Star Voyagers", Description = "A science fiction saga set among the stars.", Genre = Genre.ScienceFiction, Year = 2019, ReleaseDate = new DateTime(2019, 11, 8), CreatedOn = DateTime.Now },
                    new Movie { Id = 28, Title = "The Lost World", Description = "An adventurous quest in a lost world.", Genre = Genre.Adventure, Year = 2023, ReleaseDate = new DateTime(2023, 3, 23), CreatedOn = DateTime.Now },
                    new Movie { Id = 29, Title = "Hero's Journey", Description = "A classic tale of a hero's journey and personal growth.", Genre = Genre.Action, Year = 2018, ReleaseDate = new DateTime(2018, 6, 20), CreatedOn = DateTime.Now },
                    new Movie { Id = 30, Title = "Dance of Hearts", Description = "A romantic musical that captures the dance of love.", Genre = Genre.Musical, Year = 2012, ReleaseDate = new DateTime(2012, 7, 19), CreatedOn = DateTime.Now },
                    new Movie { Id = 31, Title = "Tales of Old", Description = "A fantasy film based on old legends and tales.", Genre = Genre.Fantasy, Year = 2015, ReleaseDate = new DateTime(2015, 8, 11), CreatedOn = DateTime.Now },
                    new Movie { Id = 32, Title = "The Great Escape", Description = "A high-stakes action thriller.", Genre = Genre.Action, Year = 2014, ReleaseDate = new DateTime(2014, 10, 9), CreatedOn = DateTime.Now },
                    new Movie { Id = 33, Title = "Heartstrings", Description = "A touching drama about love and relationships.", Genre = Genre.Drama, Year = 2017, ReleaseDate = new DateTime(2017, 5, 16), CreatedOn = DateTime.Now },
                    new Movie { Id = 34, Title = "Alien Invasion", Description = "A thrilling science fiction adventure.", Genre = Genre.ScienceFiction, Year = 2021, ReleaseDate = new DateTime(2021, 8, 25), CreatedOn = DateTime.Now },
                    new Movie { Id = 35, Title = "Wilderness Quest", Description = "An adventurous journey into the wilderness.", Genre = Genre.Adventure, Year = 2020, ReleaseDate = new DateTime(2020, 2, 22), CreatedOn = DateTime.Now },
                    new Movie { Id = 36, Title = "Rising Sun", Description = "A dramatic tale set in the dawn of a new era.", Genre = Genre.Drama, Year = 2023, ReleaseDate = new DateTime(2023, 1, 30), CreatedOn = DateTime.Now },
                    new Movie { Id = 37, Title = "Comedy of Errors", Description = "A hilarious comedy about misunderstandings and mishaps.", Genre = Genre.Comedy, Year = 2018, ReleaseDate = new DateTime(2018, 9, 12), CreatedOn = DateTime.Now }
                });
        }
    }
}
