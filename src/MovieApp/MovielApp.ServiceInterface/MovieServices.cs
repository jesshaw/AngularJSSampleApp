using System.Collections.Generic;
using AngularJSWebApp1.ServiceModel;

namespace MovielApp.ServiceInterface
{
    public class MovieService : BaseService
    {
        public object Any(QueryMovie request)
        {
            return new List<MovieResponse>
            {
                new MovieResponse {Id = 1, Title = "test1"},
                new MovieResponse {Id = 2, Title = "test2"}
            };
        }

        public object Any(GetMovie request)
        {
            return new Movie {Id = 1, Title = "阿凡达", Director = "卡梅伦", ReleaseYear = 2013, Genre = "dsafasf"};
        }

        public object Any(EditMovie request)
        {
            return new MovieResponse {Id = 1, Title = request.Title};
        }

        public object Any(DeleteMovie request)
        {
            return new MovieResponse {Id = 1, Title = "成功！"};
        }
    }
}