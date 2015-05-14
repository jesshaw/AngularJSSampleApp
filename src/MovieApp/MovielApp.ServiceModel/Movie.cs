using ServiceStack;

namespace AngularJSWebApp1.ServiceModel
{
    public class MovieResponse
    {
        public string Title { get; set; }
        public int Id { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Title { get; set; }
    }


    [Route("/movies")]
    public class QueryMovie : IReturn<MovieResponse>
    {
    }

    [Route("/movies/{Id}")]
    public class GetMovie : IReturn<Movie>
    {
        public int Id { get; set; }
    }

    [Route("/movies", "POST")]
    [Route("/movies", "PUT")]
    public class EditMovie : IReturn<MovieResponse>
    {
        public int Id { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Title { get; set; }
    }

    [Route("/movies/{Id}", "DELETE")]
    public class DeleteMovie : IReturn<MovieResponse>
    {
        public int Id { get; set; }
    }
}